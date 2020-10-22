using System;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels
{
    public abstract class EntityModelBase
    {
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public int Id { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
