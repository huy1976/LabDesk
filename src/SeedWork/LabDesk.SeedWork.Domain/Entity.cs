using LabDesk.SeedWork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabDesk.SeedWork.Domain
{
    public abstract class Entity<TId>
    {
        public TId Id { get; protected set; } = default!; //Avoid Nullable Warning
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; }

        //Interact with module (Transactional Outbox Pattern)
        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        //Create and Clear Event
        protected void AdđomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
        protected void ClearDomainEvent()
        {
            _domainEvents.Clear();
        }
    }
}
