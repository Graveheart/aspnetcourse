using System;

namespace TestConstructors
{
	class SqrtPrecalculated
	{
		public const int maxValue = 10000;
		private static double[] sqrtValues;

		private int currValue;

		static SqrtPrecalculated() 
		{
			SqrtPrecalculated.sqrtValues = new double[maxValue + 1];

            for (int i = 0; i <= maxValue; i++)
            {
                SqrtPrecalculated.sqrtValues[i] = Math.Sqrt(i);
            }
		}

		public SqrtPrecalculated()
		{
			this.currValue = 0;
		}

		public SqrtPrecalculated(int currValue)
		{
			this.currValue = currValue;
		}

		public static double GetSqrt(int aValue) 
		{
            return SqrtPrecalculated.sqrtValues[aValue];
		}

		public double GetSqrt()
		{
			return Math.Sqrt(this.currValue);
		}

		static void Main() 
		{
			Console.WriteLine(GetSqrt(1000));

			SqrtPrecalculated sqrt1 = new SqrtPrecalculated();
			Console.WriteLine(sqrt1.GetSqrt());

			SqrtPrecalculated sqrt2 = new SqrtPrecalculated(10005);
			Console.WriteLine(sqrt2.GetSqrt());
		}
	}
}
