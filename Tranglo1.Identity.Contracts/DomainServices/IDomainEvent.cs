using System;
using System.Collections.Generic;
using System.Text;

namespace Tranglo1.Identity.Contracts.DomainServices
{
    public interface IDomainEvent
    {
        public long EventId { get; set; }
        public abstract void MaterializeEvent();
    }
}