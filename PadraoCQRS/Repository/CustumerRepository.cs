using PadraoCQRS.Domain;
using System.Collections.Generic;

namespace PadraoCQRS.Repository
{
	public class CustumerRepository
	{
		public static IList<Custumer> custumers = new List<Custumer>();

		public IList<Custumer> FindAll()
		{
			return custumers;
		}

		public bool Save(Custumer custumer)
		{
			custumers.Add(custumer);
			return true;
		}

	}
}
