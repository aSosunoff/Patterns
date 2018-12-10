namespace Strategy.OperationStrategy
{
	public class OperationContext
	{
		private IOperation _operation;
		public OperationContext(){}
		public OperationContext(IOperation operation)
		{
			_operation = operation;
		}

		public void SetContext(IOperation operation)
		{
			_operation = operation;
		}

		public decimal OperationExecute(decimal x, decimal y)
		{
			return _operation.Execute(x, y);
		}
	}
}
