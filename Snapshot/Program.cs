using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapshot
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculate calculate = new Calculate();
			HistorySnapshotCommand historySnapshotCommand = new HistorySnapshotCommand(calculate);
			calculate.Addition(2);
			historySnapshotCommand.Backup();
			calculate.Addition(4);
			historySnapshotCommand.Backup();
			decimal result = calculate.GetResult();
			Console.WriteLine($"2 + 4 = { result }");
			calculate.Addition(4);
			historySnapshotCommand.Backup();
			Console.WriteLine($"{ result } + 4 = { calculate.GetResult() }");
			result = calculate.GetResult();
			calculate.Addition(4);
			Console.WriteLine($"{ result } + 4 = { calculate.GetResult() }");

			historySnapshotCommand.Undo();
			Console.WriteLine($"{ calculate.GetResult() }");

			Console.ReadLine();
		}
	}
}
