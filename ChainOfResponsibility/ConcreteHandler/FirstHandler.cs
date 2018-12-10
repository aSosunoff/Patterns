using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandler
{
    public class FirstHandler : AbstractHandler
    {
        public override string Handler(int request)
        {
            if (request == 1)
                return "Сработал первый обработчик";
            else
                return base.Handler(request);
        }
    }
}
