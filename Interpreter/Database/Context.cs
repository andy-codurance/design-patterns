using System;
using System.Collections.Generic;
using System.Linq;

namespace Interpreter.Database
{
	public class Context
	{
		private readonly Dictionary<string, List<Row>> _tables = new Dictionary<string, List<Row>>();

		public Context()
		{
			var people = new List<Row>
             {
	             new Row("John", "Doe"),
	             new Row("Sarah", "Connor"),
	             new Row("R.J.", "MacReady")
             };

			_tables.Add("people", people);
		}

		public Func<Row, string> Column { get; set; }

		public string Table { get; set; }

		public Func<string, bool> WhereFilter { get; set; }

		public List<string> Search()
		{
			var result = _tables
				.FirstOrDefault(x => x.Key == Table)
				.Value
				.Select(Column)
				.Where(WhereFilter)
				.ToList();

			return result;
		}
	}
}