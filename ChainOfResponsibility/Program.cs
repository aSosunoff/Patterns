using ChainOfResponsibility.ConcreteHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FirstHandler firstHandler = new FirstHandler();
                TwoHandler twoHandler = new TwoHandler();
                ThirdHandler thirdHandler = new ThirdHandler();

                firstHandler.SetNext(twoHandler);
                twoHandler.SetNext(thirdHandler);

                Log(firstHandler.Handler(4));
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            Console.ReadKey();
        }

        private static void Log(string line)
        {
            Console.WriteLine($"{line}\n");
        }
    }
}
