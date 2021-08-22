using PadraoCQRS.Domain.Commands.Response;
using System;

namespace PadraoCQRS.Domain.Commands
{
	public class CreateCustumerHandler
	{
		public CreateCustumerResponse Handler( Custumer custumer)
		{
			return new CreateCustumerResponse
			{
				Id = custumer.Id,
				FirstName = custumer.FirstName,
				LastName = custumer.LastName,
				Email = custumer.Email,
				Date = DateTime.Now
			};
		}
	}
}
