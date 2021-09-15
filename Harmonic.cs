using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Harmonic
    {
        public static void GetNthValue()
        {
            int N;
            float harmonic = 1;

            Console.WriteLine("Enter nth harmonic number");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine(harmonic);

        }
    }
}
