using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interface;

namespace Visitor.ConcreteComponent
{
	public class ConcreteComponentA : IComponent
	{
		public int x = 1;
		public int y = 2;
		public decimal Accept(IVisitor visitor)
		{
			return visitor.Visit_ConcreteComponentA(this);
		}
	}
}
