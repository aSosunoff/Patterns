using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.StatusState;

namespace State
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				OperationContext operationContext = new OperationContext();
				bool programClose = false;
				while (!programClose)
				{
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    string comand = Console.ReadLine()?.ToLower();
                    Console.ResetColor();
					switch (comand)
					{
						case "-l":
							Log($"Текущее состояние: {operationContext.GetState.GetName()}");
							Log($"Доступные операции : \n{String.Join(", \n", operationContext.GetListAvailablFunction())}");
							break;
						case "completed":
							Log(operationContext.Completed());
							break;
						case "close":
							programClose = operationContext.Close();
							break;
						case "create":
							Log(operationContext.Create());
							break;
						case "update":
							Log(operationContext.Update());
							break;
						case "delete":
							Log(operationContext.Delete());
							break;
						case "read":
							Log(operationContext.Read());
							break;
						default:
							Log("Такой операции не существует");
                            Log($"Доступные операции : \n{String.Join(", \n", operationContext.GetListAvailablFunction())}");
                            break;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private static void Log(string line)
		{
            Console.WriteLine($"{line}\n");
		}
	}
}