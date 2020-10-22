using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Organization
{
    public class OrganizationBase : EntityModelBase
    {
        [Required]
        [MaxLength(150)]
        public string OrganizationName { get; set; }
        [Required]
        public int Active { get; set; }
        [Required]
        public int SystemAdminId { get; set; }
        [MaxLength(8000)]
        public string OAuthKey { get; set; }
    }
}
