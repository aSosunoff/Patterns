using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteComponent
{
	public class Customer : BaseComponent
	{
		public Customer(IMediator mediator = null) : base(mediator)
		{
		}

		public void WorkCheck()
		{
			_mediator.Notify("Customer checked a work", this);
		}

		public void SandMail(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
