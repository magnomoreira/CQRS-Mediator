using MediatR;
using PadraoCQRS.Domain.Commands.Response;

namespace PadraoCQRS.Domain.Commands.Request
{
	// Requisição do cliente 
	public class CreateCustumerRequest : IRequest<CreateCustumerResponse>
	{
		public string  FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

	}
}
