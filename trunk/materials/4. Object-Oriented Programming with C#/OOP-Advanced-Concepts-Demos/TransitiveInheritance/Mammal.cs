using System;

namespace TransitiveInheritance 
{
    public class Mammal : Creature
    {
        private int age;

        public Mammal(int age)
        {
            this.age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Shhh! I'm sleeping!");
        }
    }
}
