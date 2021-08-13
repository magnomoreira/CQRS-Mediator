using PadraoCQRS.Domain.Commands.Request;
using PadraoCQRS.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoCQRS.Domain.Handler
{
	public class CreateCustumerHandler
	{
		public CreateCustumerResponse Handle(CreateCustumerRequest)
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
