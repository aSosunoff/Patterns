using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandler
{
    public class TwoHandler : AbstractHandler
    {
        public override string Handler(int request)
        {
            if (request == 2)
                return "Сработал второй обработчик";
            else
                return base.Handler(request);
        }
    }
}
