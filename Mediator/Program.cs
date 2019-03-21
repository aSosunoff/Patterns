using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.ConcreteComponent;
using Mediator.ConcreteMediator;

namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
			Programer programer= new Programer();
			Tester tester = new Tester();
			Customer customer = new Customer();
			Manager manager = new Manager(programer, tester, customer);

			programer.WorkStart();
			programer.WorkFinish();

			tester.WorkStart();
			tester.WorkFinish();

			customer.WorkCheck();

			Console.ReadKey();
		}
	}
}
