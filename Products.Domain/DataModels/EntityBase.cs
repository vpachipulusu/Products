using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels
{
    public class EntityBase : EntityModelBase
    {
        [Required]
        [MaxLength(150)]
        public string Entity { get; set; }
        [Required]
        [MaxLength(100)]
        public string EntityName { get; set; }
        [Required]
        [MaxLength(50)]
        public string EntityType { get; set; }
        [Required]
        [MaxLength(1000)]
        public string EntityDescription { get; set; }
        [Required]
        [MaxLength(50)]
        public string EntityStatus { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
        [Required]
        public int SystemAdminId { get; set; }
    }
}
