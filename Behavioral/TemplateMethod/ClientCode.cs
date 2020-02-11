using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public static class ClientCode
	{
		public static void Execute(SomeAlgoritm algoritm)
		{
			algoritm.TemplateMethod();
		}
	}
}
