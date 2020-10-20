using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Products.Domain.DataModels.Address
{
	public class AddressTypeBase
	{
		[Key]
		public int AddressTypeKey { get; set; }
		[Required]
		[MaxLength(50)]
		public string AddressType { get; set; }
		[Required]
		[Column(TypeName = "datetime")]
		public DateTime CreatedDate { get; set; }
		[Column(TypeName = "datetime")]
		public DateTime? ModifiedDate { get; set; }
		[Required]
		public int OrganisationKey { get; set; }
	}
}
