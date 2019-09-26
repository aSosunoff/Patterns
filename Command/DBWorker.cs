using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Infrastructure;

namespace Command
{
	public class DBWorker
	{
		List<Infrastructure.Command> commands = new List<Infrastructure.Command>();
		List<Infrastructure.Command> bufferCommands = new List<Infrastructure.Command>();

		private DB db;
		private bool isRun;

		public DBWorker()
		{
			db = new DB();
		}

		public List<string> GetList() => db.GetList();

		public void Insert(string data)
		{
			if(!db.IsBusy)
				db.Insert(data);
			else
				_add(new InsertCommand(db, data));
		}

		public void Delete(string data)
		{
			if (!db.IsBusy)
				db.Delete(data);
			else
				_add(new RemoveCommand(db, data));
		}

		public void DeleteAll()
		{
			if (!db.IsBusy)
				db.DeleteAll();
			else
				_add(new RemoveAllCommand(db, ""));
		}

		public void AddInsertHandler(Action<DB, string> handler)
		{
			db.InsertEvent = handler;
		}

		public void AddDeleteHandler(Action<DB, string> handler)
		{
			db.DeleteEvent = handler;
		}

		private void _add(Infrastructure.Command command)
		{
			commands.Add(command);
			_run();
		}

		private void _run()
		{
			if (!isRun)
			{
				isRun = true;

				Task.Run(() =>
				{
					while (commands.Count > 0)
					{
						bufferCommands = commands.GetRange(0, commands.Count);
						commands.Clear();

						while (bufferCommands.Count > 0)
						{
							if (!db.IsBusy)
							{
								Infrastructure.Command command = bufferCommands.First();
								bufferCommands.Remove(command);
								command.Execute();
							}
						}
					}
					
					isRun = false;
				});
			}
		}
	}
}
