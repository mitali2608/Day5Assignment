using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Factors
    {
      public static void GetFactors()
        {
            int Number;
            int x;

            Console.WriteLine("Enter the value");
            Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" The factors of " + Number + " are- ");

            for (x = 1; x <= Number; x++)
            {
                if (Number % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
