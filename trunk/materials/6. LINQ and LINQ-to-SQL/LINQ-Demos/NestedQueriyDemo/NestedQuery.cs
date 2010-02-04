using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedQueriyDemo
{
    class Person
    {
        int id;
        int idRole;
        string lastName;
        string firstName;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDRole
        {
            get { return idRole; }
            set { idRole = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public override string ToString()
        {
            return String.Format("ID={0} ,Role={1} ,First name={2} ,Last name{3}", id, idRole, firstName, lastName);
        }
    }
    class Role
    {
        int id;
        string personRole;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string PersonRole
        {
            get { return personRole; }
            set { personRole = value; }
        }
    }

    class NestedQuery
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person> {
               new Person { ID = 1, IDRole = 1, LastName = "A", FirstName = "B"},
               new Person { ID = 2, IDRole = 2, LastName = "G", FirstName = "T"},
               new Person { ID = 3, IDRole = 2, LastName = "G", FirstName = "M"},
               new Person { ID = 4, IDRole = 3, LastName = "C", FirstName = "G"}
            };
            List<Role> roles = new List<Role> {
               new Role { ID = 1, PersonRole = "Manager" },
               new Role { ID = 2, PersonRole = "Developer" }
            };
            var query = people
                        .Where(p => p.ID == 1)
                        .SelectMany(p => roles
                                        .Where(r => r.ID == p.ID)
                                        .Select(r => new { p.FirstName, p.LastName, r.PersonRole }));

            foreach (var result in query)
            {
                Console.WriteLine(result);
            }
        }
    }
}
