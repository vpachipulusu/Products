using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Products.Domain.DataModels.Sales
{
	public class SalesOrderStatusBase
	{
		[Key]
		public int SalesOrderStatusKey { get; set; }
		[Required]
		[MaxLength(150)]
		public string SalesOrderStatus { get; set; }
		[Required]
		public int SalesOrderStatusSequence { get; set; }
		[Required]
		[Column(TypeName = "datetime")]
		public DateTime CreatedDate { get; set; }
		[Column(TypeName = "datetime")]
		public DateTime? ModifiedDate { get; set; }
		[Required]
		public int OrganisationKey { get; set; }
	}

}
