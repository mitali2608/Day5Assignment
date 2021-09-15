using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class CoinFlip
    {
        public static void GetCoinFlip()
        {
            Console.WriteLine("Enter the number of time the coin should be flipped.");
            int coinFlip = Convert.ToInt32(Console.ReadLine());

            int heads = 0;
            int tails = 0;


            for (int i = 0; i < coinFlip; i++)
            {
                Random random = new Random();
                int status = (int)(random.Next(0, 2) + 0.5);

                if (status == 0)
                {
                    heads++;
                }
                else
                    tails++;
            }
            Console.WriteLine("Head : " + heads + " Times");
            Console.WriteLine("Tail : " + tails + " Times");
            Console.WriteLine("Chances of getting head is " + (heads * 100) / coinFlip + "% ");
            Console.WriteLine("Chances of getting tail is " + (tails * 100) / coinFlip + "% ");
        }
    }
}
