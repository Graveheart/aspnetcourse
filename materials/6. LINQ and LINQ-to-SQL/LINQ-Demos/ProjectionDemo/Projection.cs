using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectionDemo
{
    class Projection
    {
        static void Main(string[] args)
        {
            string[] sentence = new string[] {
        "The quick brown", "fox jumped over","the lazy dog."};

            // Select returns a three string[]
            IEnumerable<string[]> firstWords =
                sentence.Select(w => w.Split(' '));

            // To get each word, we have to use two foreach loops
            foreach (string[] segment in firstWords)
            {
                foreach (string word in segment)
                {
                    Console.WriteLine(word);
                }
            }

            // SelectMany returns nine strings (sub-iterates the Select result)
            IEnumerable<string> secondWords =
                sentence.SelectMany(segment => segment.Split(' '));

            // With SelectMany we have every string individually
            foreach (var word in secondWords)
            {
                Console.WriteLine(word);
            }

            IEnumerable<string> thirdWords =
                from segment in sentence
                from word in segment.Split(' ')
                select word;
            // With SelectMany we have every string individually
            foreach (var w in thirdWords)
            {
                Console.WriteLine(w);
            }
        }
    }
}
