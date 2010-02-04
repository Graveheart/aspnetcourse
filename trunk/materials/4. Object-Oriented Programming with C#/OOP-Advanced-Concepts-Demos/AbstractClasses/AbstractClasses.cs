using System;

public abstract class Animal
{
    abstract public int Speed
    {
        get;
    }
}
public class Cheetah : Animal
{
    public override int Speed
    {
        get
        {
            return 100;
        }
    }
}
public class Turtle : Animal
{
    public override int Speed
    {
        get
        {
            return 1;
        }
    }
}
class MainClass
{
    static void Main()
    {
        Turtle snail = new Turtle();
        Console.WriteLine("The turtle can go {0}km/h ", snail.Speed);
        Cheetah cheetah = new Cheetah();
        Console.WriteLine("The cheetah can go {0}km/h ", cheetah.Speed);
    }
}
