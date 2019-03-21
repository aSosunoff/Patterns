using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.ConcreteComponent;

namespace Mediator.ConcreteMediator
{
	public class Manager : IMediator
	{
		
		private Programer _programer { get; set; }
		private Tester _tester { get; set; }
		private Customer _customer { get; set; }
		public Manager(Programer programer, Tester tester, Customer customer)
		{
			_programer = programer;
			_programer.SetMediator(this);
			_tester = tester;
			_tester.SetMediator(this);
			_customer = customer;
			_customer.SetMediator(this);
		}

		public void Notify(string message, BaseComponent component)
		{
			if (component == _programer)
			{
				_tester.SandMail("Send mail to tester: " + message);
			}
			else if (component == _tester)
			{
				_customer.SandMail("Send mail to customer: " + message);
			}
			else if (component == _customer)
			{
				SandMail("Send mail to manager: " + message);
				_programer.SandMail("Send mail to programer: Created a new work");
			}
		}
		public void SandMail(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
