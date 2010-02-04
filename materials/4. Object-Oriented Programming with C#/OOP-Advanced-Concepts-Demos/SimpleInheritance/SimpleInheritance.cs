using System;

namespace SimpleInheritance
{
    class SimpleInheritance
    {
        static void Main()
        {
            Dog Joe = new Dog(8, "Labrador");
            Joe.Sleep();
            Joe.WagTail();
            Console.WriteLine("Joe is {0} years old {1}.", Joe.Age, Joe.Breed);
        }
    }
}
