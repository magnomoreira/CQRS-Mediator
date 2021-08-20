using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoCQRS.Domain.Commands
{
	public class CreateCustumerHandler
	{
		public CreateCustumerResponse Handler( Custumer custumer)
		{
			return new CreateCustumerResponse
			{
				Id = Guid.NewGuid(),
				FirstName = custumer.FirstName,
				LastName = custumer.LastName,
				Email = custumer.Email,
				Date = DateTime.Now
			};
		}
	}
}
