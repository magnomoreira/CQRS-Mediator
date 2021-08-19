using MediatR;
using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PadraoCQRS.Domain.Handler
{
	public class CreateCustumerHandler : IRequestHandler<CreateCustumerRequest, CreateCustumerResponse>
	{
		public Task<CreateCustumerResponse> Handle(CreateCustumerRequest request, CancellationToken cancellationToken)
		{
			var resposta = new CreateCustumerResponse
			{
				Id = Guid.NewGuid(),
				Name = request.Name,
				Email = request.Email,
				Date = DateTime.Now

			};

			return Task.FromResult(resposta);

		}
	}
}
