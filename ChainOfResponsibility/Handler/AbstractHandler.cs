using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.Handler
{
    public class AbstractHandler
    {
        private AbstractHandler _nextHandler;
	   
        public virtual string Handler(Order order)
        {
	        if (_nextHandler != null)
		        return _nextHandler.Handler(order);
	        else
		        return $"{order.Name} - завершена обработка\n";
        }

        public void SetNext(AbstractHandler handler)
        {
            _nextHandler = handler;
        }

	    public bool isNextHandler => _nextHandler != null;
	    public AbstractHandler GetNextHandler => _nextHandler;
	}
}
