namespace Strategy.OperationStrategy.Algorithm
{
	public class SubtractionStrategy : IOperation
	{
		public decimal Execute(decimal x, decimal y)
		{
			return x - y;
		}
	}
}
