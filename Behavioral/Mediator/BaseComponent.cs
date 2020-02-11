namespace Mediator
{
	public abstract class BaseComponent
	{
		protected IMediator _mediator;

		protected BaseComponent(IMediator mediator)
		{
			_mediator = mediator;
		}
		public void SetMediator(IMediator mediator)
		{
			_mediator = mediator;
		}
	}
}
