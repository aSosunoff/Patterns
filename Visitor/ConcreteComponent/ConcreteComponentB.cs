using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interface;

namespace Visitor.ConcreteComponent
{
	public class ConcreteComponentB : IComponent
	{
		public string x = "2";
		public string y = "4";
		public decimal Accept(IVisitor visitor)
		{
			return visitor.Visit_ConcreteComponentB(this);
		}
	}
}
