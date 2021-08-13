using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using System;

namespace PadraoCQRS.Domain.Handler
{
	public class CreateCustumerHandler : ICreateCustumerHandler
	{
		public CreateCustumerResponse Handle(CreateCustumerRequest request)
		{
			// Verificar se o cliente ja esta cadastrado
			// validar os dados
			// Inserir um cliente
			// Enviar email de boas vindas

			return new CreateCustumerResponse
			{
				Id = Guid.NewGuid(),
				Name = "MAgno Moreira",
				Email = "Magno@yahoo.com",
				Date = DateTime.Now

			};
		}
	}
}
