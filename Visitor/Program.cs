using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteComponent;
using Visitor.ConcreteVisitor;
using Visitor.Interface;

namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcreteComponentA concreteComponentA = new ConcreteComponentA();
			ConcreteComponentB concreteComponentB = new ConcreteComponentB();

			List<IComponent> components = new List<IComponent>()
			{
				concreteComponentA,
				concreteComponentB
			};

			ConcreteVisitorSum concreteVisitorSum = new ConcreteVisitorSum();

			components.ForEach(i =>
			{
				Console.WriteLine($"Call {i.GetType().Name} with {concreteVisitorSum.GetType().Name} = ({i.Accept(concreteVisitorSum)})\n");
			});

			ConcreteVisitorSubtraction concreteVisitorSubtraction = new ConcreteVisitorSubtraction();

			components.ForEach(i =>
			{
				Console.WriteLine($"Call {i.GetType().Name} with {concreteVisitorSubtraction.GetType().Name} = ({i.Accept(concreteVisitorSubtraction)})\n");
			});

			Console.ReadKey();
		}
	}
}
