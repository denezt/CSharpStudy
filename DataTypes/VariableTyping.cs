/*
* C# datatypes
* by name and usage.
*
*/

using System;
namespace ConsoleApp
{
    class VariableTyping
    {
        static void Main(string[] args)
        {
      		bool doAgree = true;
          Console.WriteLine("Bool State: " + doAgree);

          char stdGrade = 'A';
          Console.WriteLine("Student Grade: " + stdGrade);

      		/* Number Types*/
      		//Integer with a max number of 2,147,483,647
      		int maxInt = int.MaxValue;
          Console.WriteLine("Max Integer: " + maxInt);

      		//Long with a max number of 9,223,372,036,854,775,807
      		long maxLong = long.MaxValue;
      		Console.WriteLine("Max Long: " + maxLong);

      		//Decimal has a maximum value of 79,228,162,514,264,337,593,950,335
      		//If a larger number is required then use BigInteger
      		decimal maxDec = decimal.MaxValue;
          Console.WriteLine("Max Decimal: " + maxDec);

      		//A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
      		float maxFloat = float.MaxValue;
          Console.WriteLine("Max Float: " + maxFloat);

      		//A float is a 32 bit number with a maxValue of 1.79769313E+308 with 15 decimals of precision
      		double maxDouble = double.MaxValue;
          Console.WriteLine("Max Double: " + maxDouble);

          //Create a variable that can't be changed
          var Firstname = "Bill";
          Console.WriteLine("The variable 'Firstname' is a {0} ", Firstname.GetTypeCode());

          var Age = 20;
          Console.WriteLine("The variable 'Age' is a {0} ", Age.GetTypeCode());

        }
    }
}
