using PadraoCQRS.Domain.Commands.Request;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PadraoCQRS.Domain
{
	[Table("custumer")]
	public class Custumer
	{
		public Custumer(CreateCustumerRequest request)
		{
			Id = request.Id;
			FirstName = request.FirstName;
			LastName = request.LastName;
			Email = request.Email;
			Date = DateTime.Now;
		}

		[Key]
		public int Id { get; set; }
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
