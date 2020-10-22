using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Organization
{
    public class OrganizationBaseViewModel : EntityViewModelBase
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
