using System;

namespace Pattern_Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[4] { 1, 3, 5, 6 };
            //int n = 2 + arr.Length;

            //LinearSearch Li = new LinearSearch();
            //Li.GetMissingNumber(arr, n);
            

            String_Matching S1 = new String_Matching();
            //S1.PrintAllPermutations("abc");


            // Console.WriteLine("Are the Strings Anagram: " + S1.IsAnagram("abcd", "bcad"));


            //int maxvalue =S1.MaxCountWord("THE CLEVER FOX WAS MOST CLEVER FOX IN CLEVER WORlD AND GREATEST FOX IN THE FOX WORLD");
            //Console.WriteLine("Max =" + maxvalue);

             S1.LCS("acbhicifmy", "acbhifmy");



            Console.ReadLine();
        }
    }
}
