using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class InheritanceTest
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[] { new Square(0, 0, 5), new Rectangle(2, 2, 5, 10), 
            new FilledSquare(5, 5, 10), new FilledRectangle(5, 5, 10, 20) };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Surface: {0}", shape.CalculateSurface());
                Console.WriteLine();
                shape.PrintInfo();
                
            }
        }
    }
}
