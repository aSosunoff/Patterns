using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handler
{
	public class ManagerOrderHandler
	{
		private AbstractHandler _cainOfResponsibiliti;
		public void AddHundler(AbstractHandler handler)
		{
			if (_cainOfResponsibiliti == null)
			{
				_cainOfResponsibiliti = handler;
			}
			else
			{
				AbstractHandler last = _GetLastHandler(_cainOfResponsibiliti);
				last.SetNext(handler);
			}
		}

		private AbstractHandler _GetLastHandler(AbstractHandler handler)
		{
			if (handler == null || !handler.isNextHandler)
				return handler;

			return _GetLastHandler(handler.GetNextHandler);
		}

		public string Execute(Order order)
		{
			return _cainOfResponsibiliti.Handler(order);
		}
	}
}
