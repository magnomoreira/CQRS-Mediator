using System;

namespace PadraoCQRS.Domain.Commands.Request
{
	// Requisição do cliente 
	public class CreateCustumerRequest 
	{
		public int Id { get; set; }
		public string  FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime Data { get; set; }

	}
}
