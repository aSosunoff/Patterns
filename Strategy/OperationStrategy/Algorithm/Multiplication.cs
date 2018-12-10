using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.OperationStrategy.Algorithm
{
	public class Multiplication : IOperation
	{
		public decimal Execute(decimal x, decimal y)
		{
			return x * y;
		}
	}
}
