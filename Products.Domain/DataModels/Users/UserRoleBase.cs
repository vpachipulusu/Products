using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Users
{
    public class UserRoleBase : EntityModelBase
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
