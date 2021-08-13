namespace PadraoCQRS.Domain.Commands.Request
{
	// Requisição do cliente 
	public class CreateCustumerRequest
	{
		public string  Name { get; set; }
		public string Email { get; set; }

	}
}
