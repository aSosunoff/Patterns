namespace Strategy.OperationStrategy.Algorithm
{
	public class AdditionStrategy : IOperation
	{
		public decimal Execute(decimal x, decimal y)
		{
			return x + y;
		}
	}
}
