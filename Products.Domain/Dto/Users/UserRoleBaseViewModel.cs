using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Users
{
    public class UserRoleBaseViewModel : EntityViewModelBase
    {
        [Required]
        [MaxLength(150)]
        public string Role { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        [Required]
        public int SystemAdminId { get; set; }
    }
}
