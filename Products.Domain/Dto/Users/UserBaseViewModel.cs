using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Users
{
    public class UserBaseViewModel : EntityViewModelBase
    {
        [Required]
        public int UserRoleBaseId { get; set; }
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
    }
}
