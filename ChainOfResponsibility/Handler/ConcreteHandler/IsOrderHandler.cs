using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handler.ConcreteHandler
{
	public class IsOrderHandler : AbstractHandler
	{
		public override string Handler(Order order)
		{
			string result = String.Empty;

			if (order != null)
				result = base.Handler(order);

			return result;
		}
	}
}
