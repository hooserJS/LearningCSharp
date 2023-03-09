using System;

namespace LearningCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of two numbers
            int ex1 = 2 + 2;
            Console.WriteLine("2 + 2 = {0}",ex1);

            //dividing numbers
            int ex2 = 6 / 2;
            Console.WriteLine("6 / 2 = {0}", ex2);

            //Result of scified operations
            int ex31 = -1 + 4 * 6;
            int ex32 = ( 35 + 5 ) % 7 ;
            int ex33 = 14 + -4 * 6 / 11;  //better to use float or double
            int ex34 = 2 + 15 / 6 * 1 - 7 % 2; //better to use float or double
            Console.WriteLine("Operation 1 = {0}", ex31);
            Console.WriteLine("Operation 2 = {0}", ex32);
            Console.WriteLine("Operation 3 = {0}", ex33);
            Console.WriteLine("Operation 4 = {0}", ex34);

            //Swap two numbers
            Console.WriteLine("Please enter the first number:");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int SecomdNumber = Convert.ToInt32(Console.ReadLine());

            int FirstNumber1 = SecomdNumber;
            SecomdNumber = FirstNumber;

            Console.WriteLine($"First Number = {FirstNumber1} and Second Number = {SecomdNumber}");

            //print the multiplication of three numbers whitch will be entered by user

            Console.WriteLine("Please enter 3 numbers for multiplication:");
            int mult1 = Convert.ToInt32(Console.ReadLine());
            int mult2 = Convert.ToInt32(Console.ReadLine());
            int mult3 = Convert.ToInt32(Console.ReadLine());

            int multResult = mult1 * mult2 * mult3;

            Console.WriteLine("Numbers for multiplication: {0}, {1}, {2}. Result: {3}", mult1, mult2, mult3, multResult);

        }
    }
}