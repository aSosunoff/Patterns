using System;

namespace Snapshot
{
	public class CalculateSnapshot
	{
		//private Calculate _calculate;
		private DateTime _dateTime;
		private decimal _result;

		public CalculateSnapshot(decimal result)
		{
			_result = result;
			_dateTime = DateTime.Now;
		}

		public decimal GetResult()
		{
			return _result;
		}
	}
}