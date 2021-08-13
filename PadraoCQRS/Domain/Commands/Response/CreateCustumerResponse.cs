using System;

// Resposta para o cliente 
namespace PadraoCQRS.Domain.Commands.Response
{
	public class CreateCustumerResponse
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime Date { get; set; }

	}
}
