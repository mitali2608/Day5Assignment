using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class LeapYear
    {
        public static void GetLeapYear()
        {
            int chk_year;

            Console.Write("Check whether a given year is leap year or not\n");

            Console.Write("Enter any year in 4 digit: ");
            chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} is a leap year.", chk_year );
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.", chk_year);
            else
                Console.WriteLine("{0} is not a leap year.", chk_year);

        }

    }

}
