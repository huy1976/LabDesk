using LabDesk.SeedWork.Domain;
using LabDesk.SeedWork.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MongoDB.Bson.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabDesk.SeedWork.Infrastructure.Persistence
{
    public class DispatchDomainEventsInterceptor : SaveChangesInterceptor
    {
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            DbContext? dbContext = eventData.Context;

            if (dbContext is null)
            {
                return base.SavingChangesAsync(eventData, result, cancellationToken);
            }

            // 1. Lấy tất cả AggregateRoot đang giữ DomainEvents
            var aggregates = dbContext.ChangeTracker
                .Entries<AggregateRoot<Guid>>()
                .Select(x => x.Entity)
                .Where(x => x.DomainEvents.Any())
                .ToList();

            // 2. Gom tất cả Domain Events
            var domainEvents = aggregates
                .SelectMany(x => x.DomainEvents)
                .ToList();

            // 3. Xóa Events trên Aggregate Root sau khi đã nhặt ra
            aggregates.ForEach(x => x.ClearDomainEvents());

            // 4. Chuyển thành OutboxMessage để lưu cùng Transaction DB
            var outboxMessages = domainEvents.Select(domainEvent => new OutboxMessage
            {
                Id = Guid.NewGuid(),
                OccurredOnUtc = DateTimeOffset.UtcNow,
                Type = domainEvent.GetType().Name,
                Content = Newtonsoft.Json.JsonConvert.SerializeObject(
        domainEvent,
        new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        })
            }).ToList();
            if (outboxMessages.Any())
            {
                dbContext.Set<OutboxMessage>().AddRange(outboxMessages);
            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
