using PadraoCQRS.Data;
using PadraoCQRS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PadraoCQRS.Repository
{
	public class CustumerRepository
	{
		private AplicationContext _context;

		public CustumerRepository(AplicationContext context)
		{
			_context = context;
		}

		public IList<Custumer> FindAll()
		{
			return _context.Custumers.ToList();
		}

		public Custumer Save(Custumer custumer)
		{
			try
			{
				_context.Add(custumer);
				_context.SaveChanges();

			}
			catch (Exception)
			{

				throw;
			}
			return custumer;
		}

	}
}
