using System;
using System.Collections.Generic;
using Interpreter.Database;
using Interpreter.Expressions;

namespace Interpreter
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IExpression query = new Select("FirstName", new From("people"));
			var context = new Context();
			var result = query.Interpret(context);
			PrettyPrintList(result);

			IExpression queryTwo = new Select("*", new From("people"));
			context = new Context();
			result = queryTwo.Interpret(context);
			PrettyPrintList(result);

			IExpression queryThree = new Select("Surname", new From("people", new Where("StartsWith", "C")));
			context = new Context();
			result = queryThree.Interpret(context);
			PrettyPrintList(result);
		}

		private static void PrettyPrintList(IEnumerable<string> list)
		{
			Console.WriteLine(string.Join(", ", list));
		}
	}
}