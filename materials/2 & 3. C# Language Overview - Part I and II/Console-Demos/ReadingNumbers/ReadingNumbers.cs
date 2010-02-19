using System;

class ReadingNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}",
            a, b, a + b);
        Console.WriteLine("{0} * {1} = {2}",
            a, b, a * b);

        Console.Write("f = ");
        float f = float.Parse(Console.ReadLine());
        Console.WriteLine("{0} * {1} / {2} = {3}",
            a, b, f, a * b / f);
    }
}
