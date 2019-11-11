using System;
using System.Collections.Generic;
using Interpreter.Database;

namespace Interpreter.Expressions
{
	public class Where : IExpression
	{
		private readonly Func<string, bool> _filter;

		public Where(Func<string, bool> filter)
		{
			_filter = filter;
		}

		public List<string> Interpret(Context context)
		{
			context.WhereFilter = _filter;
			return context.Search();
		}
	}
}