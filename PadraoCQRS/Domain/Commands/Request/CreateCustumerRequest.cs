namespace PadraoCQRS.Domain.Commands.Request
{
	// Requisição do cliente 
	public class CreateCustumerRequest 
	{
		public string  FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

	}
}
