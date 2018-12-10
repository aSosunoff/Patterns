using System.Collections.Generic;
using System.Reflection;

namespace State.StatusState
{
	public abstract class State
	{
		protected OperationContext Context;
		private string _stateName;
		protected State(string stateName)
		{
			_stateName = stateName;
		}

		public void SetContext(OperationContext context)
		{
			Context = context;
		}

		public List<string> GetListAvailablFunction()
		{
			List<string> result = new List<string>();

			MethodInfo[] methodInfos = this.GetType().GetMethods();
			foreach (MethodInfo methodInfo in methodInfos)
			{
				InfoAttribute attribute = methodInfo.GetCustomAttribute<InfoAttribute>();
				if (attribute == null) continue;

				result.Add($"{ attribute.Name } - { attribute.Description }");
			}
			return result;
		}

		public abstract string Open();

		public string GetName()
		{
			return _stateName;
		}

		[Info(Name = "Close", Description = "Закрывает программу")]
		public bool Close()
		{
			return true;
		}

		public abstract string Create();
		public abstract string Read();
		public abstract string Update();
		public abstract string Delete();
	}
}
