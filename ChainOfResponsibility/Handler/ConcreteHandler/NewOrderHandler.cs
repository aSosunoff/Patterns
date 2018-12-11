using System;

namespace ChainOfResponsibility.Handler.ConcreteHandler
{
    public class NewOrderHandler : Handler
    {
        public override string Process(Order order)
        {
	        string result = String.Empty;

	        if (order.Id == 0)
	        {
		        order.Id = 10;
		        result = $"{order.Name} - создан новый продукт: количество - {order.Amount}";
			}

	        return $"{result}\n{base.Process(order)}";

        }
    }
}
