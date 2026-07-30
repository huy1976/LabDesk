using LabDesk.SeedWork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabDesk.SeedWork.Domain
{
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    {
        // Để trống hoặc thêm các logic liên quan đến Versioning/Concurrency Token nếu cần sau này
    }
}
