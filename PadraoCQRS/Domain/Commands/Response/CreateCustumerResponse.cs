using System;

// Resposta para o cliente 
namespace PadraoCQRS.Domain.Commands.Response
{
	public class CreateCustumerResponse
	{
		public CreateCustumerResponse(Custumer custumer)
		{
			ExternalId = custumer.Id;
			FirstName = custumer.FirstName;
			LastName = custumer.LastName;
			Email = custumer.Email;
			Date = custumer.Date;
		}

		public CreateCustumerResponse()
		{

		}

		public int ExternalId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string Email { get; set; }
		public DateTime Date { get; set; }


		public CreateCustumerResponse UpdateResponse(Custumer custumer)
		{
			return new CreateCustumerResponse()
			{
				ExternalId = custumer.Id,
				LastName = custumer.LastName,
				FirstName = custumer.FirstName,
				Email = custumer.Email,
				Date = custumer.Date

			};
		}




	}
}
