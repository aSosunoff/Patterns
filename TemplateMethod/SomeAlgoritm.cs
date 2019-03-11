using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public abstract class SomeAlgoritm
	{
		public void TemplateMethod()
		{
			this.Step1();
			this.Hook1();
			this.Step2();
			this.Hook2();
			this.Step3();
		}

		protected void Step1()
		{
			Console.WriteLine("SomeAlgoritm: Step 1");
		}

		protected abstract void Step2();

		protected void Step3()
		{
			Console.WriteLine("SomeAlgoritm: Step 3");
		}

		protected abstract void Step4();

		protected virtual void Hook1(){}
		protected virtual void Hook2(){}
	}
}
