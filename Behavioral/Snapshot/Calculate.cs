using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapshot
{
	public class Calculate
	{
		private decimal _result;

		public void Addition(decimal x)
		{
			_result += x;
		}

		public void Subtraction(decimal x)
		{
			_result -= x;
		}

		public void Clear()
		{
			_result = 0;
		}

		public decimal GetResult()
		{
			return _result;
		}

		public CalculateSnapshot ToSnapshot()
		{
			return new CalculateSnapshot(_result);
		}

		public void FromSnapshot(CalculateSnapshot calculateSnapshot)
		{
			_result = calculateSnapshot.GetResult();
		}
	}
}
