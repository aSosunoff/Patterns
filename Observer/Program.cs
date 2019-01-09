using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeObject someObject = new SomeObject();
			someObject.DoSomeBusinessLogic();

			ConcreteObserverA observerA = new ConcreteObserverA();
			someObject.Attach(observerA);
			ConcreteObserverB observerB = new ConcreteObserverB();
			someObject.Attach(observerB);

			someObject.DoSomeBusinessLogic();

			someObject.Detach(observerA);

			someObject.DoSomeBusinessLogic();

			Console.ReadKey();
		}
	}

	public interface IObserver
	{
		void Update();
	}

	public interface ISubject
	{
		void Attach(IObserver observer);
		void Detach(IObserver observer);
		void Notify();
	}

	public class SomeObject : ISubject
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

	public class ConcreteObserverA : IObserver
	{
		public void Update()
		{
			Console.WriteLine("ConcreteObserverA is work");
		}
	}

	public class ConcreteObserverB : IObserver
	{
		public void Update()
		{
			Console.WriteLine("ConcreteObserverB is work");
		}
	}
}
