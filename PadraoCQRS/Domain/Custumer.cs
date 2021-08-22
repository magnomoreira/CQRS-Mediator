using PadraoCQRS.Domain.Commands.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoCQRS.Domain
{
	[Table("custumer")]
	public class Custumer
	{
		[Key]
		public int Id{ get; set; }
		[Column("first_name")]
		public string FirstName { get; set; }
		[Column("last_name")]
		public string LastName { get; set; }
		[Column("email")]
		public string Email { get; set; }
		[Column("launch_time")]
		public DateTime Date { get; set; }
	}
}
