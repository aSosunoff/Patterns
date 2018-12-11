using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.Handler
{
    public class Handler
    {
        private Handler _nextHandler;
	   
        public virtual string Process(Order order)
        {
	        if (_nextHandler != null)
		        return _nextHandler.Process(order);
	        else
		        return $"{order.Name} - завершена обработка\n";
        }

        public void SetNext(Handler handler)
        {
            _nextHandler = handler;
        }

	    public bool isNextHandler => _nextHandler != null;
	    public Handler GetNextHandler => _nextHandler;
	}
}
