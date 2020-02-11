using System;

namespace State
{
	[AttributeUsage(AttributeTargets.Method)]
	public class InfoAttribute : Attribute
	{
		public string Description { get; set; }
	}
}
