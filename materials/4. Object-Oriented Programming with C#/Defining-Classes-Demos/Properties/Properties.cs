using System;

namespace CalculatingArea
{
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle firstRect = new Rectangle(5.0f, 2.3f);
			Console.WriteLine("Rectangle 1 is {0}x{1} and has area {2}", 
                firstRect.Height, firstRect.Width, firstRect.Area);

			Rectangle secondRect2 = new Rectangle(3.0f, 4.0f);
			Console.WriteLine("Rectangle 2 is {0}x{1} and has area {2}", 
                secondRect2.Height, secondRect2.Width, secondRect2.Area);

			// Can't set a value to readonly property!
			//secondRect.Area = 20.3f;

            UserProfile profile = new UserProfile()
            {
                FirstName = "Steve",
                LastName = "Balmer",
                UserId = 91112
            };
            Console.WriteLine("Name: {0} {1}", profile.FirstName, profile.LastName);
		}
	}
}
