using PadraoCQRS.Domain.Commands.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoCQRS.Domain
{
	public class Custumer
	{
		public Custumer(CreateCustumerRequest requeste)
		{
			FirstName = requeste.FirstName;
			LastName = requeste.LastName;
			Email = requeste.Email;
			Date = new DateTime();
		}

		public int Id { get; set; }
		public int ExternalId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime Date { get; set; }
	}
}
