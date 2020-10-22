using System;

namespace Products.Domain.Dto
{
    public abstract class EntityViewModelBase
    {
        public int Id { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
