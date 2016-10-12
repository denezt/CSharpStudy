/*
* Basic Math Operation and
* Possible logical implementations.
*
*/
using System;

namespace SimpleOperations
{
    class BasicMath
    {
        static void Main(string[] args)
        {
		Console.WriteLine("5 + 3 = " + ( 5 + 3));
    Console.WriteLine("5 - 3 = " + ( 5 - 3));
    Console.WriteLine("5 * 3 = " + ( 5 * 3));
    Console.WriteLine("5 / 3 = " + ( 5 / 3));
    Console.WriteLine("5.2 % 3 = " + ( 5.2 % 3));

    int i = 0;
    Console.WriteLine("i++ = " + (i++));
    Console.WriteLine("++i = " + (++i));
    Console.WriteLine("i-- = " + (i--));
    Console.WriteLine("--i = " + (--i));

    Console.WriteLine("(i += 3) -> equals: " + (i += 3));
    Console.WriteLine("(i -= 2) -> equals: " + (i -= 2));
    Console.WriteLine("(i *= 2) -> equals: " + (i *= 2));
    Console.WriteLine("(i /= 2) -> equals: " + (i /= 2));
    Console.WriteLine("(i /= 2) -> equals: " + (i %= 2));

    Console.WriteLine("Done!\nPress any key to continue!");

		Console.ReadKey();
        }
    }
}
