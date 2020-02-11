using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			/*decimal res = 1;

			while (res > 0)
			{
				Task<decimal> task1 = new Task<decimal>(() =>
				{
					Test test = new Test();
					return Convert.ToDecimal(test.getUniqName());
				});
				Task<decimal> task2 = new Task<decimal>(() =>
				{
					Test test = new Test();
					return Convert.ToDecimal(test.getUniqName());
				});

				task1.Start();
				task2.Start();

				var t = task1.Result;
				var t2 = task2.Result;

				res = t2 - t;
			}*/

			bool res = false;

			while (!res)
			{
				Task<string> task1 = new Task<string>(() =>
				{
					Test test = new Test();
					return test.getUniqId2();
				});
				Task<string> task2 = new Task<string>(() =>
				{
					Test test = new Test();
					return test.getUniqId2();
				});
				Task<string> task3 = new Task<string>(() =>
				{
					Test test = new Test();
					return test.getUniqId2();
				});
				Task<string> task4 = new Task<string>(() =>
				{
					Test test = new Test();
					return test.getUniqId2();
				});

				task1.Start();
				task2.Start();
				task3.Start();
				task4.Start();

				var t = task1.Result;
				var t2 = task2.Result;
				var t3 = task3.Result;
				var t4 = task4.Result;

				//res = t2 == t;
				if ($"{t2}_{t3}_{t4}".Contains(t))
				{
					res = true;
				}
				else if ($"{t}_{t3}_{t4}".Contains(t2))
				{
					res = true;
				}
				else if ($"{t2}_{t}_{t4}".Contains(t3))
				{
					res = true;
				}
				else if ($"{t2}_{t3}_{t}".Contains(t4))
				{
					res = true;
				}

				Console.WriteLine($"{t}_{t2}_{t3}_{t4}".Replace("-", "_"));
			}

			var y = 1;
		}
	}

	class Test
	{
		private static readonly object _lock = new object();
		public string getUniqName()
		{
			//lock (_lock)
			//{

			//}
			return $"{DateTime.Now:yymdhmsmsffffff}";
		}

		public string getUniqId()
		{
			return $"{Guid.NewGuid()}";
		}

		public string getUniqId2()
		{
			int i = Guid.NewGuid().GetHashCode();

			int j = BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0);

			return $"{i}";
		}
	}
}
