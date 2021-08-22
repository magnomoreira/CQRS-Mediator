using System;

// Resposta para o cliente 
namespace PadraoCQRS.Domain.Commands.Response
{
	public class CreateCustumerResponse
	{

		public int Id{ get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime Date { get; set; }

	}
}
