using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.ConcreteImplementation;

namespace TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			ClientCode.Execute(new Ipmlementation1());

			Console.Write("\n");

			ClientCode.Execute(new Ipmlementation2());

			Console.ReadKey();
		}
	}
}
