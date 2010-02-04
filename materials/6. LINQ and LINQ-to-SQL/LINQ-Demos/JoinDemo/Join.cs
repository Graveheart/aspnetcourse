using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoinDemo
{
    class Join
    {
        class Person
        {
            public string Name { get; set; }
        }

        class Pet
        {
            public string Name { get; set; }
            public Person Owner { get; set; }
        }

        public static void JoinEx1()
        {
            Person Ivan = new Person { Name = "Petrov, Ivan" };
            Person Gosho = new Person { Name = "Georgiev, Gosho" };
            Person Mara = new Person { Name = "Mara, Kaka" };

            Pet barley = new Pet { Name = "Barley", Owner = Ivan };
            Pet boots = new Pet { Name = "Boots", Owner = Ivan };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = Mara };
            Pet daisy = new Pet { Name = "Daisy", Owner = Gosho };

            List<Person> people = new List<Person> { Ivan, Gosho, Mara };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, daisy };
            var query = 
                //from person in people
                //        join p in pets on person equals p.Owner
                //        select new { OwnerName = person.Name, Pet = p.Name };
                people.Join(pets, person => person,
                        pet => pet.Owner,
                        (person, pet) =>
                        new { OwnerName = person.Name, Pet = pet.Name });

            foreach (var obj in query)
            {
                Console.WriteLine(
                    "{0} - {1}",
                    obj.OwnerName,
                    obj.Pet);
            }
        }

        static void Main(string[] args)
        {
            JoinEx1();
        }
    }
}
