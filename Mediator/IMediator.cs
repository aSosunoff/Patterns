using Mediator.ConcreteComponent;

namespace Mediator
{
	public interface IMediator
	{
		void Notify(string message, BaseComponent component);
	}
}