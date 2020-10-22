using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Users
{
    public class UserBase : EntityModelBase
    {
        [Required]
        public int UserRoleBaseId { get; set; }
        public virtual UserRoleBase UserRoleBase { get; set; }
        [Required]
        [MaxLength(60)]
        public string UserLogin { get; set; }
        [Required]
        [MaxLength(30)]
        public string UserPassword { get; set; }
        [Required]
        [MaxLength(120)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(20)]
        public string UserType { get; set; }
        [Required]
        public int UserStatus { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }

}
