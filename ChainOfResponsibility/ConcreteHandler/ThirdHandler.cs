using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandler
{
    public class ThirdHandler : AbstractHandler
    {
        public override string Handler(int request)
        {
            if (request == 3)
                return "Сработал третий обработчик";
            else
                return base.Handler(request);
        }
    }
}
