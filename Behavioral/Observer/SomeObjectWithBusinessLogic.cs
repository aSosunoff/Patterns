using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Interface;

namespace Observer
{
	public class SomeObjectWithBusinessLogic : ISubject
	{
		private List<IObserver> _observers = new List<IObserver>();
		private int result = 0;
		public void Attach(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			for (int i = 0; i < _observers.Count; i++)
				_observers[i].Update();
		}

		public void DoSomeBusinessLogic()
		{
			result += 1;
			Console.WriteLine($"DoSomeBusinessLogic = {result}");
			Notify();
		}
	}
}
