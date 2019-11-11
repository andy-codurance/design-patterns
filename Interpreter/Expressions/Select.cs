using System;
using System.Collections.Generic;
using Interpreter.Database;

namespace Interpreter.Expressions
{
	public class Select : IExpression
	{
		private readonly string _column;
		private readonly Func<Row, string> _expression;
		private readonly From _from;

		public Select(string column, From from)
		{
			if (column == "FirstName")
			{
				_expression = x => x.FirstName;
			}
			else if (column == "Surname")
			{
				_expression = x => x.Surname;
			}
			else
			{
				_expression = x => x.FirstName + " " + x.Surname;
			}

			_column = column;
			_from = from;
		}

		public List<string> Interpret(Context context)
		{
			context.Column = _expression;
			return _from.Interpret(context);
		}
	}
}
