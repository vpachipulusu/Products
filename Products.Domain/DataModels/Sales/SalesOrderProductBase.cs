using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Products.Domain.DataModels.Sales
{
	public class SalesOrderProductBase
	{
		[Key]
		public int OrderProductKey { get; set; }
		public int? ProductKey { get; set; }
		public int? Quantity { get; set; }
		public int? NetPrice { get; set; }
		public int? SalesOrderProductStatusKey { get; set; }
		[Required]
		[Column(TypeName = "datetime")]
		public DateTime CreatedDate { get; set; }
		[Required]
		[Column(TypeName = "datetime")]
		public DateTime ModifiedDate { get; set; }
		[Required]
		public int OrganisationKey { get; set; }
	}


}
