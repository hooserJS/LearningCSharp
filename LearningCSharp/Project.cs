using System;
using System.ComponentModel.Design;
using System.Timers;

namespace LearningCSharp
{
    internal class Project
    {
        static void Main(string[] args)
        {
            //Write a C# program to check two given integers and return true if one is negative and one is positive
            int a = -1;
            int b = 1;
 
            if (a<0 || b>=0) 
            {
                Console.WriteLine("True");
            }
            else if (a>=0 || b<0)
            {
                Console.WriteLine("True");
            }
            //Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20

            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());

            int s = e + f;

            if (e == 20 ||  f == 20)
            {
                Console.WriteLine("True");
            }
            else if (s == 20)
            {
                Console.WriteLine("True");
            }
            else {Console.WriteLine("Not in required range!");}

            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            int c = 0;
            while (c < 100)
            {
                if(c%2 == 1)
                {
                    Console.WriteLine($"{c}");
                }
                c++;
            }

            //Write a C# program to compute the sum of the first 500 prime numbers.

            int i, j, d;
            d = 0;

            for (i = 2; i < 500; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break;
                if (j > (i / j)) ;
                d = d + i;
            }
            Console.WriteLine($"Sum of the first 500 prime numbers: {d}");

            //Write a C# program and compute the sum of the digits of an integer.

        }
    }
}