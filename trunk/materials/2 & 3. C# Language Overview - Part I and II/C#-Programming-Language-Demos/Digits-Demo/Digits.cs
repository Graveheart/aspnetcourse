using System;

public class Digits
{
	static void Main()
	{
		for (int d1 = 1; d1 <= 9; d1++) 
		{
			for (int d2 = 0; d2 <= 9; d2++) 
			{
				int d3 = 25 - d1 - d2;
				
                if ((d3 >= 0) && (d3 <= 9))
				{
					int n = d1 * 100 + d2 * 10 + d3;

                    Console.WriteLine(n);
				}
			}
		}
	}
}
