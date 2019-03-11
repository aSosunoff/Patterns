﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Command.Infrastructure;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			DBWorker dbWorker = new DBWorker();
			dbWorker.AddInsertHandler(EventInsertHandler);
			dbWorker.AddDeleteHandler(EventDeleteHandler);

			Regex regex = new Regex(@"^((?<oper>insert|delete)\s+(?<val>.+)\s*)$|^(?<oper>list)?", RegexOptions.Singleline);

			while (true)
			{
				string data = Console.ReadLine();

				if (regex.IsMatch(data))
				{
					string oper = regex.Match(data).Groups["oper"].Value;
					string val = regex.Match(data).Groups["val"].Value;
					switch (oper)
					{
						case "insert":
							dbWorker.Insert(val);
							break;
						case "delete":
							dbWorker.Delete(val);
							break;
						case "list":
							Console.WriteLine($"{dbWorker.List()}");
							break;
					}
				}
				
			}
		}

		public static void EventInsertHandler(DB db)
		{
			Console.WriteLine($"Event insert: {db.Read()}");
		}

		public static void EventDeleteHandler(DB db, string item)
		{
			Console.WriteLine($"Event delete: {item}");
		}
	}
}