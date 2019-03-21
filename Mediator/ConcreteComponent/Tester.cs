using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteComponent
{
	public class Tester : BaseComponent
	{
		public Tester(IMediator mediator = null) : base(mediator)
		{
		}
		public void WorkStart()
		{
			_mediator.Notify("Tester start work", this);
		}
		public void WorkFinish()
		{
			_mediator.Notify("Tester finish work", this);
		}

		public void SandMail(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
