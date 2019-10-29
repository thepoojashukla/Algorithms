using System;

namespace KalStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringsAndDP stdp = new StringsAndDP();
            //Console.WriteLine(stdp.IsPermutationString("feed", "food"));
            //Console.Write(stdp.UniqueCharacter("abcd15XYZ760jk"));
            // stdp.ReplacedString("we love america");
            //Console.WriteLine( stdp.Compression("aabccccaab"));


            //int[,] mat = {{0, 1, 1, 0},
            //              {1, 1, 0, 1},
            //              {1, 1, 1, 1}};
            //stdp.ConvertMatrix(mat,3,4);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(mat[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //stdp.LCSubsequence("ABCDGH" , "AEDFHR");


            //Console.Write(stdp.RomanToNumber("XXXXX"));
            //string[] sarr = { "geeksforgeeks", "geeks", "geek", "geezer" };
            //Console.WriteLine(stdp.CommonPrefix( sarr, 4));

            //Console.WriteLine(stdp.Atoi("-123"));

            // Console.WriteLine(stdp.StrstrOccurence("geeksforgeeks", "for"));


            // Console.WriteLine(stdp.RotationPossible("amazon", "azonam"));
            Console.WriteLine(stdp.StrstrOccurence("abcxbzxyzrdf", "xyz"));

            Console.Read();
        }
    }
}
