using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class Alphabet
    {
      public static void GetResult()
        {
            char alpha;

            Console.WriteLine("Enter random Alphabet: ");
            alpha = Convert.ToChar(Console.ReadLine());

            if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' || alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
            {

                Console.WriteLine(alpha + " is Vowel.");

            }
            else if ((alpha >= 'a' && alpha <= 'z') || (alpha >= 'A' && alpha <= 'Z'))
            {
                Console.WriteLine(alpha + " is Consonant.");
            }
        }
    }
}
