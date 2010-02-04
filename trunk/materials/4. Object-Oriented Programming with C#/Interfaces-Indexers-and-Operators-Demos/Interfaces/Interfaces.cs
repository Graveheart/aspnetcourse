using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IShape
    {
        void SetPosition(int x, int y);
        double CalculateSurface();
    }

    interface IMovable
    {
        void Move(int deltaX, int deltaY);
    }

    interface IResizable
    {
        void Resize(int weightX, int weightY);
        void ResizeByX(int weightX);
        void ResizeByY(int weightY);
    }

    public class Square : IShape
    {
        private int x, y, size;

        public Square(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        // Derived from IShape
        public void SetPosition(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        // Derived from IShape  
        public double CalculateSurface() 
        {
            return size * size;
        } 
    }

    public struct Rectangle : IShape, IMovable, IResizable
    {
        private int x, y, width, height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void SetPosition(int aX, int aY) 
        {
            x = aX;
            y = aY;
        }

        public double CalculateSurface()
        {
            return width * height;
        }

        public void Move(int deltaX, int deltaY) // From IMovable 
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public void Resize(int weightX, int weightY) // IResizable 
        {
            width = width * weightX;
            height = height * weightY;
        }

        public void ResizeByX(int weightX) // From IResizable 
        {
            width = width * weightX;
        }

        public void ResizeByY(int weightY) // From IResizable 
        {
            height = height * weightY;
        }
    }

    public class Circle : IShape, IMovable
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public void SetPosition(int x, int y) // From IShape 
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface() // From IShape 
        {
            return Math.PI * radius * radius;
        }

        public void Move(int deltaX, int deltaY) // From IMovable 
        {
            this.x += deltaX;
            this.y += deltaY;
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(0, 0, 10); 
            Rectangle rect = new Rectangle(0, 0, 10, 12); 
            Circle circle = new Circle(0, 0, 5); 
            if (square is IShape) 
            { 
                Console.WriteLine("{0} is IShape", square.GetType()); 
            } 
            if (rect is IResizable) 
            { 
                Console.WriteLine("{0} is IResizable", rect.GetType()); 
            }
            if (circle is IResizable)
            {
                Console.WriteLine("{0} is IResizable", circle.GetType());
            } 
 
            IShape[] shapes = {square, rect, circle}; 
            foreach (IShape shape in shapes) 
            { 
                shape.SetPosition(5, 5); 
                Console.WriteLine("Surface: {0}", shape.CalculateSurface()); 
            } 
        } 
    }
}