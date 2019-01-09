using Visitor.ConcreteComponent;

namespace Visitor.Interface
{
	public interface IVisitor
	{
		decimal Visit_ConcreteComponentA(ConcreteComponentA concreteComponentA);
		decimal Visit_ConcreteComponentB(ConcreteComponentB concreteComponentB);
	}
}