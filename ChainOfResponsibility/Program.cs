using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Handler;
using ChainOfResponsibility.Handler.ConcreteHandler;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Order> Orders = new List<Order>()
			{
				new Order{ Id = 0, Amount = 5, Name = "Колесо", CustomerId = 0, ProductNumber = 12 },
				new Order{ Id = 1, Amount = 20, Name = "Гвозди", CustomerId = 4, ProductNumber = 43 },
				new Order{ Id = 1, Amount = 20, Name = "Молоток", CustomerId = 0, ProductNumber = 15 },
				new Order{ Id = 0, Amount = 20, Name = "Колесо", CustomerId = 7, ProductNumber = 45 }
			};

            try
            {
	            ManagerOrderHandler managerOrderHandler = new ManagerOrderHandler();
	            managerOrderHandler.AddHundler(new IsOrderHandler());
	            managerOrderHandler.AddHundler(new NewOrderHandler());
	            managerOrderHandler.AddHundler(new OrderCompletedHandler());

	            Orders.ForEach(i =>
	            {
		            Console.WriteLine(managerOrderHandler.Execute(i));
				});
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            Console.ReadKey();
        }

        private static void Log(string line)
        {
            Console.WriteLine($"{line}\n");
        }
    }
}
