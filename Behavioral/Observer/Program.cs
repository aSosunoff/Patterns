using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.ConcreteObserver;
using Observer.Interface;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeObjectWithBusinessLogic businessLogic = new SomeObjectWithBusinessLogic();
			businessLogic.DoSomeBusinessLogic();

			ConcreteObserverA observerA = new ConcreteObserverA();
			businessLogic.Attach(observerA);
			ConcreteObserverB observerB = new ConcreteObserverB();
			businessLogic.Attach(observerB);

			businessLogic.DoSomeBusinessLogic();

			businessLogic.Detach(observerA);

			businessLogic.DoSomeBusinessLogic();

			Console.ReadKey();
		}
	}
}
