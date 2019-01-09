using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteComponent;
using Visitor.Interface;

namespace Visitor.ConcreteVisitor
{
	public class ConcreteVisitorSum : IVisitor
	{
		public decimal Visit_ConcreteComponentA(ConcreteComponentA concreteComponentA)
		{
			return concreteComponentA.x + concreteComponentA.y;
		}

		public decimal Visit_ConcreteComponentB(ConcreteComponentB concreteComponentB)
		{
			return Convert.ToDecimal(concreteComponentB.x) + Convert.ToDecimal(concreteComponentB.y);
		}
	}
}
