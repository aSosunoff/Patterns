using System;

namespace ChainOfResponsibility.Handler.ConcreteHandler
{
    public class OrderCompletedHandler : AbstractHandler
    {
        public override string Handler(Order order)
        {
	        string result = String.Empty;

	        if (order.Id != 0 && order.Amount == 20 && order.CustomerId != 0)
		        result = $"{order.Name} - отправлен заказчику: ID заказчика {order.CustomerId}";
	        else
		        result = $"{order.Name} - Товар пока не может быть отпарвлен\n{base.Handler(order)}";

	        return result;
        }
    }
}
