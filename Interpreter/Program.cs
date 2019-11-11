﻿using System;

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
			Console.WriteLine(string.Join(", ", result));

			IExpression queryTwo = new Select("*", new From("people"));
			context = new Context();
			result = queryTwo.Interpret(context);
			Console.WriteLine(string.Join(", ", result));

			IExpression queryThree = new Select("Surname", new From("people", new Where(x => x.StartsWith("C"))));
			context = new Context();
			result = queryThree.Interpret(context);
			Console.WriteLine(string.Join(", ", result));
		}
	}
}