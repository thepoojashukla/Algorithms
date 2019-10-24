using System;

namespace KalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Assignment1 assignment1 = new Assignment1();

            int[] inputArr = new int[] { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 };
            assignment1.SortbyFrequency(inputArr);

            Console.ReadLine();

        }
    }
}
