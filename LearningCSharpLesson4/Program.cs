using System;
using System.Xml.Serialization;

namespace LearningCSharpLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# method to find the largest value from three integer values.

            MaxValue(1, 2, 3);

            // Write a C# method to find the lowest value from three integer values.

            LowestValue(1, 2, 3);

            // Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 

            var Nearest = NearestValue(15, 12);
            Console.WriteLine($"Nearest value to 20 = {Nearest}");

            // Write a C# method to compute the sum of all the elements of an array of integers
            int[] Numbers = new int[3] { 1, 2, 3 };

            var ComputedArr = ComputedNumbers(Numbers);
            Console.WriteLine($"Computed numbers from array = {ComputedArr}");

            // Write a C# method to get the larger value from array

            int[] SomeArr = new int[3] { 1, 12, -1 };

            var LargestArrVal = FindLargestArrVal(SomeArr);

            Console.WriteLine($"The largest value from arr is = {LargestArrVal}");

        }
        static void MaxValue(int num1, int num2, int num3)
        {
            int temp = 0;
            if (num1 > num2)
                temp = num1;
            else if (num2 > num3)
                temp = num2;
            else if (num3 > num1)
                temp = num3;
            Console.WriteLine($"Max value = {temp}");
        }
        static void LowestValue(int num1, int num2, int num3)
        {
            int temp = 0;
            if (num1 < num2)
                temp = num1;
            else if (num2 < num3)
                temp = num2;
            else if (num3 < num1)
                temp = num3;
            Console.WriteLine($"Lowes value = {temp}");
        }

        static int NearestValue(int num1, int num2)
        {
            int temp = 0;
            int diff = 20 - num1;
            int diff2 = 20 - num2;

            if (diff < diff2)
                temp = num1;
            else temp = num2;

            return temp;
        }

        static int ComputedNumbers(int[] Numbers)
        {
            int temp = 0;

            foreach (int num in Numbers)
                temp += num;
            return temp;
        }

        static int FindLargestArrVal(int[] Numbers)
        {
            int temp = 0;
            foreach (int num in Numbers)
                if (num > temp)
                    temp = num;

            return temp;
        }

    }
}