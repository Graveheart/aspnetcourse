using System;

namespace PolymorphismExample
{
    class Creature
    {
        public virtual void Speak()
        { }
    }
    class Cat : Creature
    {
        public override void Speak()
        {
            Console.WriteLine("Miaaay!");
        }
    }
    class Dog : Creature
    {
        public override void Speak()
        {
            Console.WriteLine("Bark, bark, Grrrr!");
        }
    }
    class MainClass
    {
        static void Main()
        {
            Creature[] creatures = new Creature[] { new Dog(), new Cat() };
            foreach (Creature animal in creatures)
            {
                Console.WriteLine("{0} :", animal.GetType().Name);
                animal.Speak();
            }

        }
    }
}
