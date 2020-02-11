using System;
using System.Collections.Generic;

namespace State.StatusState.Implementation
{
	public class WorkState : State
	{
        public WorkState() : base("В работе")
        {
        }

        [Info(Description = "Завершена работа")]
        public override string Completed()
		{
            this.Context.StateChange(new CompletedState());
            return "Завершено";
		}

		[Info(Description = "Что то создать")]
		public override string Create()
		{
			return "Что то создать";
		}

		[Info(Description = "Что то прочитать")]
		public override string Read()
		{
			return "Что то прочитать";
		}

		[Info(Description = "Что то обновить")]
		public override string Update()
		{
			return "Что то обновить";
		}

		[Info(Description = "Что то удалить")]
		public override string Delete()
		{
			return "Что то удалить";
		}
	}
}
