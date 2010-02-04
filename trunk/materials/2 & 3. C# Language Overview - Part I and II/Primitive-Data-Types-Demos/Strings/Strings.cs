using System;

class Strings
{
	static void Main()
	{
		string firstName = "Ivan";
		string lastName = "Ivanov";
		Console.WriteLine("Hello, {0}!", firstName);

		string fullName = firstName + " " + lastName;
		Console.WriteLine("Your full name is {0}.", fullName);
	}
}
