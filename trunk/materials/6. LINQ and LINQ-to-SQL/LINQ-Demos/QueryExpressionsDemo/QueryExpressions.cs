using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryExpressionsDemo
{
    class QueryExpressions
    {
        static void Main(string[] args)
        {
            QueryOverStrings();
        }

        static void QueryOverStrings()
        {
            // Assume we have an array of strings.
            string[] currentVideoGames = {"Morrowind", "BioShock" ,
                                             "Half Life 2: Episode 1", "The Darkness",
                                                "Daxter", "System Shock 2"};
            // Build a query expression to represent the items in the array
            // that have more than 6 letters.
            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Length > 6
                                         orderby g
                                         select g;
            // Print out the results.
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }
    }
}
