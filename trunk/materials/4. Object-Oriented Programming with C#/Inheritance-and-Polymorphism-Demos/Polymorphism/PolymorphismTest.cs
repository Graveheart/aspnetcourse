using System;

namespace InheritanceAndPolymorphism
{
	class Person 
	{
		public virtual void PrintName() 
		{
			Console.WriteLine("I am a person.");
		}
	}

	class Trainer : Person
	{
		public override void PrintName() 
		{
			Console.WriteLine("I am a trainer.");
		}
	}

	class Student : Person
	{
		public override void PrintName() 
		{
			Console.WriteLine("I am a student.");
		}
	}


	class PolymorphismTest
	{
		static void Main()
		{
			Person person = new Person();
			person.PrintName();

			Person trainer = new Trainer();
			trainer.PrintName();

			Person student = new Student();
			student.PrintName();
		}
	}
}
