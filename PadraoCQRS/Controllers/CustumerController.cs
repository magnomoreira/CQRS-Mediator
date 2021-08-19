using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PadraoCQRS.Domain;
using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using PadraoCQRS.Repository;

namespace PadraoCQRS.Controllers
{


	[ApiController]
	[Route("api/custumer")]
	public class CustumerController : ControllerBase
	{

		private readonly CreateCustumerResponse _response;
		private readonly CustumerRepository _repository;
		private readonly ILogger _ilogger;

		public CustumerController(CreateCustumerResponse response, CustumerRepository repository, ILogger ilogger)
		{
			_response = response;
			_repository = repository;
			_ilogger = ilogger;
		}

		[HttpPost]
		public IActionResult Post(CreateCustumerRequest request)
		{

			var custumers = new Custumer(request);

			_response.UpdateResponse(custumers);

			return Ok();
		}

		[HttpGet]
		public IActionResult Get()
		{

			_repository.FindAll();

			return Ok();
		}


	}
}
