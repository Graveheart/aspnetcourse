using System;

namespace TransitiveInheritance 
{
    public class Dog : Mammal
    {
        private string breed;
        
        public Dog(int age, string breed)
            : base(age)
        {
            this.breed = breed;
        }

        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        public void WagTail()
        {
            Console.WriteLine("Tail wagging...");
        }
    }
}
