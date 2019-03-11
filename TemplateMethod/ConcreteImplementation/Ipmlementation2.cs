using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.ConcreteImplementation
{
	public class Ipmlementation2 : SomeAlgoritm
	{
		protected override void Step2()
		{
			Console.WriteLine("Ipmlementation2: Step 2");
		}

		protected override void Step4()
		{
			Console.WriteLine("Ipmlementation2: Step 4");
		}

		protected override void Hook1()
		{
			Console.WriteLine("Ipmlementation2: Hook 1");
		}
	}
}
