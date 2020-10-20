using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Products.Domain.DataModels.Sales
{
	public class SalesOrderBase
	{
		[Key]
		public int SalesOrderKey { get; set; }
		[Required]
		public int SalesOrderStatusKey { get; set; }
		[Required]
		public int CustomerKey { get; set; }
		[Required]
		[Column(TypeName = "datetime")]
		public DateTime SalesOrderDate { get; set; }
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
