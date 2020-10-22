using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Customer
{
    public class CustomerBase : EntityModelBase
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
        public virtual OrganizationBase OrganizationBase { get; set; }
    }
}
