// A Hello World! program in C#.
using System;
namespace Castings
{
    class CastingTypes
    {
        static void Main()
        {
            double pi = 3.141;
            int intPi = (int)pi;
            Console.WriteLine("Casting Double[pi = {0}] <-to-> Integer[intPi = {1} ] ", pi, intPi);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
