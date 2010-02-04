using System;

class BitwiseOperators
{
	static void Main()
	{
		ushort a = 3;                // 00000000 00000011 = 3
		ushort b = 5;                // 00000000 00000101 = 5

		Console.WriteLine( a | b);   // 00000000 00000111 = 7
		Console.WriteLine( a & b);   // 00000000 00000001 = 1
		Console.WriteLine( a ^ b);   // 00000000 00000110 = 6
		Console.WriteLine(~a & b);   // 00000000 00000100 = 4
		Console.WriteLine( a << 1 ); // 00000000 00000110 = 6
		Console.WriteLine( a >> 1 ); // 00000000 00000001 = 1
		Console.WriteLine( a >> 2 ); // 00000000 00000000 = 0
		Console.WriteLine( a << 2 ); // 00000000 00001100 = 12
		Console.WriteLine(~a);       // 11111111 11111100 = -4 = 65532
	}
}
