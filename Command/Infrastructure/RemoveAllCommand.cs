using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Infrastructure
{
	public class RemoveAllCommand : Command
	{
		public RemoveAllCommand(DB db, string data) : base(db, data)
		{
		}

		public override void Execute()
		{
			_db.DeleteAll();
		}
	}
}
