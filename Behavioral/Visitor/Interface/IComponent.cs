namespace Visitor.Interface
{
	public interface IComponent
	{
		decimal Accept(IVisitor visitor);
	}
}