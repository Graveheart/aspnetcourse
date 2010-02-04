using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public struct Color
    {
        public byte redValue;
        public byte greenValue;
        public byte blueValue;

        public Color(byte red, byte green, byte blue)
        {
            this.redValue = red;
            this.greenValue = green;
            this.blueValue = blue;
        }
    }

    /// <summary>
    /// Base class for all geometric
    /// figures in our application
    /// </summary>
    public abstract class Shape
    {
        protected Point position;
        public abstract int CalculateSurface();
        public virtual void PrintInfo()
        {
            Console.WriteLine("Position: ({0}, {1})", position.x, position.y);
        }
    }

    /// <summary>
    /// Square class, inheritor of the Shape class
    /// </summary>
    public class Square : Shape
    {
        private int size;

        public Square(int x, int y, int size)
        {
            position.x = x;
            position.y = y;
            this.size = size;
        }

        public override int CalculateSurface()
        {
            return size * size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Square info:");

            base.PrintInfo();
            Console.WriteLine("Size: {0}", this.size);
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Rectangle class, inheritor of the Shape class
    /// </summary>
    public class Rectangle : Shape
    {
        private int width, height;
        
        public Rectangle(int x, int y, int width, int height)
        {
            position.x = x;
            position.y = y;
            this.width = width;
            this.height = height;
        }

        public override int CalculateSurface()
        {
            return width * height;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Rectangle info:");

            base.PrintInfo();
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine();
        }
    }

    public class FilledSquare : Square
    {
        private Color color;

        public FilledSquare(int x, int y, int size)
            : base(x, y, size)
        {
            color = new Color(0, 0, 0);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Color info:");
            Console.WriteLine("Color: ({0}, {1}, {2})",
                color.blueValue, color.greenValue, color.redValue);

            base.PrintInfo();
        }
    }

    public class FilledRectangle : Rectangle
    {
        private Color color;

        public FilledRectangle(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
            color = new Color(0, 0, 0);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Color info:");
            Console.WriteLine("Color: ({0}, {1}, {2})",
                color.blueValue, color.greenValue, color.redValue);

            base.PrintInfo();
        
        }
    }
}