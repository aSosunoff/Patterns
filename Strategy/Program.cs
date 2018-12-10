using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.OperationStrategy;
using Strategy.OperationStrategy.Algorithm;

namespace Patterns
{
	class Program
	{
		static void Main(string[] args)
		{
			OperationContext context = new OperationContext();

			context.SetContext(new AdditionStrategy());
			Console.WriteLine($"2 + 4 = { context.OperationExecute(2, 4) }\n");

			context.SetContext(new SubtractionStrategy());
			Console.WriteLine($"2 - 4 = { context.OperationExecute(2, 4) }\n");

			context.SetContext(new Multiplication());
			Console.WriteLine($"2 * 4 = { context.OperationExecute(2, 4) }\n");

			context.SetContext(new Division());
			Console.WriteLine($"2 / 4 = { context.OperationExecute(2, 4) }\n");

			Console.Read();
		}
	}
}
