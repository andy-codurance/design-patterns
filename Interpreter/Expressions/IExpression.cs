using System.Collections.Generic;
using Interpreter.Database;

namespace Interpreter.Expressions
{
	public interface IExpression
	{
		List<string> Interpret(Context context);
	}
}
