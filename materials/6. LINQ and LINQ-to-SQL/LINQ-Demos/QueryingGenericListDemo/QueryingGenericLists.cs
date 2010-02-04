using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryingGenericListDemo
{
    class QueryingGenericLists
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>() {
                         new Book { Title="LINQ in Action" },
                         new Book { Title="LINQ for Fun" },
                         new Book { Title="Extreme LINQ" } };
            var titles = books
                .Where(book => book.Title.Contains("Action"))
                .Select(book => book.Title);

            foreach (string str in titles)
            {
                Console.WriteLine(str);
            }

        }
    }

    class Book
    {
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
