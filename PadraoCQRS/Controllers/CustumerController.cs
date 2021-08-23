using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PadraoCQRS.Domain;
using PadraoCQRS.Domain.Commands;
using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Repository;
using System.Collections.Generic;

namespace PadraoCQRS.Controllers
{


	[ApiController]
	[Route("api/custumer")]
	public class CustumerController : ControllerBase
	{

		private readonly CreateCustumerRequest _request;
		private readonly CreateCustumerHandler _handler;
		private readonly CustumerRepository _repository;
		private readonly ILogger<CustumerController> _ilogger;

		public CustumerController(CreateCustumerHandler response, CustumerRepository repository, ILogger<CustumerController> logger)
		{
			_handler = response;
			_repository = repository;
			_ilogger = logger;
		}

		[HttpPost]
		public IActionResult Post()
		{

			var custumers = new Custumer(_request);
			_repository.Save(custumers);

			_handler.Handler(custumers);

			return Ok();
		}

		[HttpGet]
		[ProducesResponseType((200),Type = typeof(List<Custumer>))]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		public IActionResult Get()
		{

			var custumer = _repository.FindAll();

			return Ok(custumer);
		}


	}
}
