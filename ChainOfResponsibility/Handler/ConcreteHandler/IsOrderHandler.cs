using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handler.ConcreteHandler
{
	public class IsOrderHandler : Handler
	{
		public override string Process(Order order)
		{
			string result = String.Empty;

			if (order != null)
				result = base.Process(order);

			return result;
		}
	}
}
