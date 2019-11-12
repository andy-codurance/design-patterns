using System;
using System.Collections.Generic;
using Interpreter.Database;

namespace Interpreter.Expressions
{
	public class Where : IExpression
	{
		private readonly Func<string, bool> _expression;

		public Where(string filter, string parameter)
		{
			if (filter == "StartsWith")
			{
				_expression = x => x.StartsWith(parameter);
			}
		}

		public List<string> Interpret(Context context)
		{
			context.WhereFilter = _expression;
			return context.Search();
		}
	}
}