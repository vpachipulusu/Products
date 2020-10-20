using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Products.Domain.DataModels.Users
{
	public class UserBase
	{
		[Key]
		public int UserKey { get; set; }
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
		[Column(TypeName = "datetime")]
		public DateTime CreatedDate { get; set; }
		[Column(TypeName = "datetime")]
		public DateTime? ModifiedDate { get; set; }
		[Required]
		public int OrganisationKey { get; set; }
	}

}
