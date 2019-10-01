using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosCoding
{
    public class StringProgram
    {
        public string ReverseString(string str)
        {
            Console.WriteLine($"input: {str}");
            char[] x = str.ToCharArray();


            int start = 0;
            int end = x.Length - 1;
            while (start <= end)
            {
                char v = x [start];
                x[start] = x[end];
                x[end] = v;
                start++;
                end--;

            }
            Console.WriteLine($"Output: {new string(x)}");

            return new string(x);
        }

        public Boolean IsPalindromeString(string str)
        {
            Console.WriteLine($"input: {str}");
            char[] x = str.ToCharArray();

            int start = 0;
            int end = x.Length - 1;
            while (start < end)
            {

                if (x[start] == x[end])
                {
                    start++;
                    end--;

                }
                else
                { return false; }
            }

            return true;
        }


        public void PrintAString(string str1, string str2,string str3,string str4,string str5)
        {
            Console.WriteLine("*********");
            Console.WriteLine("*"   +str1+      "*");
            Console.WriteLine("*"  + str2+  "*");
            Console.WriteLine("*"  +      str3          +      "*");
            Console.WriteLine("*"   + str4 +       "*");
            Console.WriteLine("*"   + str5 +       "*");
            Console.WriteLine("*********");

            
        }
    }
}
