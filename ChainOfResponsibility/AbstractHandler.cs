using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual string Handler(int request)
        {
            if (_nextHandler != null)
                return _nextHandler.Handler(request);
            else
                throw new Exception("Для данного запроса нет обработчика");
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
