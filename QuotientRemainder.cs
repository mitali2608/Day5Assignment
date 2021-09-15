using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class QuotientRemainder
    {
        public static void GetQR()
        {
            int Dividend;
            int Divisor;

            Console.WriteLine("Enter the value for Dividend");
            Dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value for Divisor");
            Divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;


            Console.WriteLine("Quotient = " + Quotient);
            Console.WriteLine("Remainder = " + Remainder);

        }
    }
}
