using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class Order
	{
		public int Id { get; set; }
		public int ProductNumber { get; set; }
		public string Name { get; set; }
		public int Amount { get; set; }
		public int CustomerId { get; set; }
	}
}
