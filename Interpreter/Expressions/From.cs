using System.Collections.Generic;
using Interpreter.Database;

namespace Interpreter.Expressions
{
	public class From : IExpression
	{
		private readonly string _table;
		private readonly Where _where;

		public From(string table, Where where = null)
		{
			_table = table;
			_where = where;
		}

		public List<string> Interpret(Context context)
		{
			context.Table = _table;
			if (_where == null)
			{
				context.WhereFilter = x => true;
				return context.Search();
			}

			return _where.Interpret(context);
		}
	}
}