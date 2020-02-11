using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapshot
{
	public class HistorySnapshotCommand
	{
		private List<CalculateSnapshot> _calculateSnapshots = new List<CalculateSnapshot>();
		private Calculate _calculate;
		public HistorySnapshotCommand(Calculate calculate)
		{
			_calculate = calculate;
		}

		public void Backup()
		{
			_calculateSnapshots.Add(_calculate.ToSnapshot());
		}
		public void Undo()
		{
			if (_calculateSnapshots.Count == 0) return;

			CalculateSnapshot snapshotLast = _calculateSnapshots.Last();
			_calculateSnapshots.Remove(snapshotLast);
			_calculate.FromSnapshot(snapshotLast);
		}
	}
}
