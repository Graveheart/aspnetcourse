using System;

namespace TransitiveInheritance
{
    class MainClass
    {
        static void Main()
        {
            Dog joe = new Dog(6, "labrador");
            joe.Walk();
            joe.Sleep();
            joe.WagTail();
        }
    }
}
  