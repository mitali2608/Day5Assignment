using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Assignment
{
    class SwapNumber
    {
        public static void GetSwappedNumber()
        {
            int num1;
            int num2;

            Console.WriteLine("Enter value of num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter value of num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap num1= " + num1 + " num2= " + num2);
            num1 = num1 * num2; //a=50 (5*10)      
            num2 = num1 / num2; //num2=5 (50/10)      
            num1 = num1 / num2; //a=10 (50/5)    
            Console.Write("After swap num1= " + num1 + " num2= " + num2);
        }
    }
}
