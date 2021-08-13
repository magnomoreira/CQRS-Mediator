using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoCQRS.Domain.Handler
{
	public interface ICreateCustumerHandler
	{
		CreateCustumerResponse Handle(CreateCustumerRequest request);
	}
}
