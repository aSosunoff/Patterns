using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.ConcreteImplementation
{
	public class Ipmlementation1 : SomeAlgoritm
	{
		protected override void Step2()
		{
			Console.WriteLine("Ipmlementation1: Step 2");
		}

		protected override void Step4()
		{
			Console.WriteLine("Ipmlementation1: Step 4");
		}
	}
}
