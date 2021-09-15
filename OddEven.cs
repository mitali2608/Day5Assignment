using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class OddEven
    {
        public static void GetOddEven()
        {
            int i;
            Console.Write("Enter the value : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Given Value is Even Number");
            }
            else
            {
                Console.Write("Given value is Odd Number");
            }
        }
    }
}
