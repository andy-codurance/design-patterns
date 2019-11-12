namespace Interpreter.Database
{
	public class Row
	{
		public Row(string firstName, string surname)
		{
			FirstName = firstName;
			Surname = surname;
		}

		public string FirstName { get; set; }

		public string Surname { get; set; }
	}
}