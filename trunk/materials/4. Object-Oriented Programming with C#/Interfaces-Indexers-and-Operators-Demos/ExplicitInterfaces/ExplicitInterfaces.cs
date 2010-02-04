using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public interface I1
    {
        void Test();
    }

    public interface I2
    {
        void Test();
    }

    public class TestExplicit : I1, I2
    {
        void I1.Test()
        {
            Console.WriteLine("I1.Test() called");
        }
        void I2.Test()
        {
            Console.WriteLine("I2.Test called");
        }

        public void Test()
        {
            Console.WriteLine("TestExplicit.Test() called");
        }

        public static void Main()
        {
            TestExplicit testExplicit = new TestExplicit();
            // Prints: TestExplicit.Test() called
            testExplicit.Test();
            // Prints: I1.Test() called
            I1 i1 = (I1)testExplicit;
            i1.Test();
            // Prints: I2.Test() called
            I2 i2 = (I2)testExplicit;
            i2.Test();
        }
    }
}
