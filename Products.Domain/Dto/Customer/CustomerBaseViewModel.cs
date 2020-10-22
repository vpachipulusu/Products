using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Customer
{
    public class CustomerBaseViewModel : EntityViewModelBase
    {
        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(250)]
        public string CustomerKeyContact { get; set; }
        [Required]
        [MaxLength(15)]
        public string CustomerMobile { get; set; }
        [Required]
        [MaxLength(150)]
        public string CustomerEmail { get; set; }
        [Required]
        [MaxLength(250)]
        public string CustomerWeb { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }
}
