using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Interface;

namespace Observer.ConcreteObserver
{
	public class ConcreteObserverB : IObserver
	{
		public void Update()
		{
			Console.WriteLine("ConcreteObserverB is work");
		}
	}
}
