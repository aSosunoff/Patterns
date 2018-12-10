using System;
using System.Collections.Generic;

namespace State.StatusState.Implementation
{
	public class WorkState : State
	{

		public override string Open()
		{
			throw new MissingMethodException("В данном состоянии не работает");
		}

		[Info(Name = "Create", Description = "Что то создать")]
		public override string Create()
		{
			return "Что то создать";
		}

		[Info(Name = "Read", Description = "Что то прочитать")]
		public override string Read()
		{
			return "Что то прочитать";
		}

		[Info(Name = "Update", Description = "Что то обновить")]
		public override string Update()
		{
			return "Что то обновить";
		}

		[Info(Name = "Delete", Description = "Что то удалить")]
		public override string Delete()
		{
			return "Что то удалить";
		}

		public WorkState() : base("В работе")
		{
		}
	}
}
