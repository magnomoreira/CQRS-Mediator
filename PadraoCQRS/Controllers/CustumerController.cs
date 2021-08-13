using Microsoft.AspNetCore.Mvc;
using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using PadraoCQRS.Domain.Handler;

namespace PadraoCQRS.Controllers
{
	[ApiController]
	[Route("api/custumer")]
	public class CustumerController : ControllerBase
	{
		[HttpPost]
		public CreateCustumerResponse Create(
			[FromServices] ICreateCustumerHandler handler,
			[FromBody] CreateCustumerRequest command)
		{
			return handler.Handle(command);
		}
	}
}
