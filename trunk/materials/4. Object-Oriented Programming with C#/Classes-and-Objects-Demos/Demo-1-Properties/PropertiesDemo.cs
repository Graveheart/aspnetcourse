using System;

namespace Properties
{
	public class Person 
	{
		private string name;
		private DateTime dateOfBirth;

		public string Name 
		{
			get 
			{
				return this.name;
			}

			set 
			{
				if ((value != null) && (value.Length > 0))
				{
					this.name = value;
				}
				else 
				{
					throw new ApplicationException("Invalid name!");
				}
			}
		}

		public DateTime DateOfBirth
		{
			get
			{
				return this.dateOfBirth;
			}

			set
			{
				if ((value.Year >= 1900) && (value.Year <= DateTime.Now.Year))
				{
					this.dateOfBirth = value;
				}
				else 
				{
					throw new ApplicationException("Invalid date of birth!");
				}
			}
		}

		public int Age
		{
			get
			{
				DateTime now = DateTime.Now;
				int yearsOld = now.Year - this.dateOfBirth.Year;

				DateTime birthdayThisYear = 
					new DateTime(now.Year, dateOfBirth.Month,
						dateOfBirth.Day, dateOfBirth.Hour,
						dateOfBirth.Minute, dateOfBirth.Second);

                if (DateTime.Compare(now, birthdayThisYear) < 0) 
				{
					yearsOld--;
				}

				return yearsOld;
			}
		}
	}


	class PropertiesDemo
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			person.Name = "Svetlin Nakov";
			person.DateOfBirth = new DateTime(1980, 6, 14);
			
			Console.WriteLine("{0} is born on {1:dd.MM.yyyy}.", 
				person.Name, person.DateOfBirth);

			Console.WriteLine("{0} is {1} years old.", 
				person.Name, person.Age);
		}
	}
}