using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Command
{
	public class DB
	{
		private List<string> _table = new List<string>();
		private bool _isBusy = false;
		private int[] _delay = new[] {1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000};

		public Action<DB, string> InsertEvent;
		public Action<DB, string> DeleteEvent;

		public void Insert(string data)
		{
			Busy();
			Task.Run(() =>
			{
				Random random = new Random();
				Thread.Sleep(_delay[random.Next(0, 9)]);
				_table.Add(data);
				InsertEvent(this, data);
				UnBusy();
			});
		}
		public void Delete(string data)
		{
			Busy();
			Task.Run(() =>
			{
				Random random = new Random();
				Thread.Sleep(_delay[random.Next(0, 9)]);
				_table.Remove(data);
				DeleteEvent(this, data);
				UnBusy();
			});
		}

		public void DeleteAll()
		{
			Busy();
			Task.Run(() =>
			{
				Random random = new Random();
				Thread.Sleep(_delay[random.Next(0, 9)]);
				_table.Clear();
				DeleteEvent(this, "Delete all objects");
				UnBusy();
			});
		}

		public List<string> GetList() => _table;
		public void Busy() => _isBusy = true;
		public void UnBusy() => _isBusy = false;
		public bool IsBusy => _isBusy;
	}
}