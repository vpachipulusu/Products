using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Products.Domain.DataModels.Address
{
	public class AddressBase
	{
		[Key]
		public int AddressKey { get; set; }
		[Required]
		public int AddressTypeKey { get; set; }
		public int? EntityKey { get; set; }
		[MaxLength(120)]
		public string AddressL1 { get; set; }
		[Required]
		[MaxLength(120)]
		public string AddressL2 { get; set; }
		[MaxLength(120)]
		public string AddressL3 { get; set; }
		[MaxLength(120)]
		public string AddressL4 { get; set; }
		[MaxLength(120)]
		public string AddressL5 { get; set; }
		[MaxLength(80)]
		public string AddressL6 { get; set; }
		[MaxLength(80)]
		public string AddressL7 { get; set; }
		[Required]
		public int AddressStatus { get; set; }
		[Required]
		[Column(TypeName = "datetime")]
		public DateTime CreatedDate { get; set; }
		[Column(TypeName = "datetime")]
		public DateTime? ModifiedDate { get; set; }
		[Required]
		public int OrganisationKey { get; set; }
	}


}
