using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Command.Infrastructure
{
	public class RemoveCommand : Command
	{
		public RemoveCommand(DB db, string data) : base(db, data)
		{
		}
		public override void Execute()
		{
			_db.Delete(_data);
		}
	}
}
