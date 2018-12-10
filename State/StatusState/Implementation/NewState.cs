using System;
using System.Collections.Generic;

namespace State.StatusState.Implementation
{
	public class NewState : State
	{
        public NewState() : base("Новое")
        {
        }

        [Info(Description = "Открывает состояние работы")]
		public override string Completed()
		{
			this.Context.StateChange(new WorkState());
			return "Взято в работу";
		}

		public override string Create()
		{
			throw new MissingMethodException("В данном состоянии не работает");
		}

		public override string Read()
		{
			throw new MissingMethodException("В данном состоянии не работает");
		}

		public override string Update()
		{
			throw new MissingMethodException("В данном состоянии не работает");
		}

		public override string Delete()
		{
			throw new MissingMethodException("В данном состоянии не работает");
		}
	}
}
