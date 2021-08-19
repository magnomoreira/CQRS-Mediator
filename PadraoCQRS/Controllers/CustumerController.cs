using MediatR;
using Microsoft.AspNetCore.Mvc;
using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using PadraoCQRS.Domain.Handler;
using System.Threading.Tasks;

namespace PadraoCQRS.Controllers
{

	
	[ApiController]
	[Route("api/custumer")]
	public class CustumerController : ControllerBase
	{

		[HttpPost]
		public Task <CreateCustumerResponse> Create(
			[FromServices] IMediator mediator,
			[FromBody] CreateCustumerRequest command
			)
		{
			return mediator.Send(command);
		}

		
	}
}
