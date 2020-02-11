using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteComponent
{
	public class Programer : BaseComponent
	{
		public Programer(IMediator mediator = null) : base(mediator)
		{
		}

		public void WorkStart()
		{
			_mediator.Notify("Programer start work", this);
		}
		public void WorkFinish()
		{
			_mediator.Notify("Programer finish work", this);
		}

		public void SandMail(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
