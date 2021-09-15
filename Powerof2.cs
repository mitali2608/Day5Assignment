using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{

    class Powerof2
    {
        public static void GetPowerof2()
        {
            int N;
            int result;
            int counter = 1;

            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());

            if (N > 31)
                Console.WriteLine("Please enter a valid input (The value of N should lies between 0 to 31) ");
            else
                while (counter <= N)
                {
                    result = counter * 2;
                    counter++;
                    Console.WriteLine(result);
                }

        }

    }
}