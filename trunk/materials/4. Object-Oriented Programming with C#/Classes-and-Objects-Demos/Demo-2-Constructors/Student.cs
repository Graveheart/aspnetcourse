using System;

namespace Constructors
{
	public class Student
	{
		private string name;
		private int studentId;
		private string position = "Student";
		
		public Student(string Name, int StudentId)
		{
			this.name = Name;
			this.studentId = StudentId;		
		}
		
		public Student(string Name) : this(Name, -1)
		{
		}

		public static void Main() 
		{
			Student s = new Student("Бай Киро", 12345);
		}
	}
}
