using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handler
{

	public class ManagerOrderHandler
	{
		private Handler _cainOfResponsibiliti;
		public void AddHundler(Handler handler)
		{
			if (_cainOfResponsibiliti == null)
				_cainOfResponsibiliti = handler;
			else
			{
				Handler last = _GetLastHandler(_cainOfResponsibiliti);
				last.SetNext(handler);
			}
		}

		private Handler _GetLastHandler(Handler handler)
		{
			return !handler.isNextHandler ? handler : _GetLastHandler(handler.GetNextHandler);
		}

		private List<Handler> _DeleteLastElement(List<Handler> chainOfElements, Handler handlerRemove)
		{
			chainOfElements.Reverse();

			int indexRemoveElement = -1;

			foreach (Handler element in chainOfElements)
			{
				if (element.GetType() == handlerRemove.GetType())
				{
					indexRemoveElement = chainOfElements.IndexOf(element);
					break;
				}
			}

			if (indexRemoveElement != -1)
				chainOfElements.RemoveAt(indexRemoveElement);

			chainOfElements.Reverse();

			return chainOfElements;
		}

		public void RemoveHundler(Handler handler)
		{
			if (handler == null) return;

			List<Handler> chainOfElements = _GetChainOfElementsByList(_cainOfResponsibiliti);
			if (!chainOfElements.Any()) return;

			chainOfElements = _DeleteLastElement(chainOfElements, handler);
			
			if (!chainOfElements.Any())
			{
				_cainOfResponsibiliti = null;
				return;
			}

			chainOfElements.Aggregate<Handler, Handler>(null, (p, c) =>
			{
				p?.SetNext(c);
				return c;
			});

			_cainOfResponsibiliti = chainOfElements.FirstOrDefault();
		}

		private List<Handler> _GetChainOfElementsByList(Handler chain)
		{
			if (chain == null) return new List<Handler>();

			List<Handler> result = new List<Handler>();

			result.Add(chain);

			if (chain.isNextHandler)
				result.AddRange(_GetChainOfElementsByList(chain.GetNextHandler));

			return result;
		}

		public string Execute(Order order)
		{
			return _cainOfResponsibiliti.Process(order);
		}
	}
}
