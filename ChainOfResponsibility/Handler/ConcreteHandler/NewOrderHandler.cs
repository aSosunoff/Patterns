using System;

namespace ChainOfResponsibility.Handler.ConcreteHandler
{
    public class NewOrderHandler : AbstractHandler
    {
        public override string Handler(Order order)
        {
	        string result = String.Empty;

	        if (order.Id == 0)
	        {
		        order.Id = 10;
		        result = $"{order.Name} - создан новый продукт: количество - {order.Amount}";
			}

	        return $"{result}\n{base.Handler(order)}";

        }
    }
}
