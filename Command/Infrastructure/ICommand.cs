namespace Command.Infrastructure
{
	public abstract class Command
	{
		protected DB _db;
		protected string _data;

		protected Command(DB db, string data)
		{
			_db = db;
			_data = data;
		}
		public abstract void Execute();
	}
}