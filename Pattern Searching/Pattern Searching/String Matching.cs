using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


//Anagram substring search
//merging two string Arrays
//Anagram substring search or search for all permutations
namespace Pattern_Searching
{   
    class String_Matching
    {
        public void NaiveApproach (string[] text, string[] pattern) //not a good approach
        {
            int tLen = text.Length;
            int pLen = pattern.Length;

            for(int textind = 0; textind < tLen - pLen; textind++ )
            {
                for(int pInd = 0; pInd < pLen; pLen++ )
                {
                    if(text[textind + pInd] != pattern[pInd])
                    {
                        return;
                    }
                    if( pInd== pLen)
                    {
                        Console.Write("Pattern exist");
                    }
                }
            }
        }


        public void PrintPermuationsR(String stringSoFar, String str)
        {
            if (str.Length <= 1)
            {
                Console.WriteLine(stringSoFar + str);
                return;
            }
            int strLen = str.Length;
            for (int i = 0; i < strLen; i++)
            {
                stringSoFar = stringSoFar + str[i];
                //Remove current character
                String remainingStr = str.Remove(i, 1);
                PrintPermuationsR(stringSoFar, remainingStr);
                stringSoFar = stringSoFar.Remove(stringSoFar.Length - 1, 1);
            }
        }


        public void PrintAllPermutations(String str)
        {
            PrintPermuationsR("", str);
        }




        public void LCS(string str1 , string str2)
        {
            string result = "";
            int[,] matrix = new int[str1.Length, str2.Length];
            int max = 0;


            for(int i=0; i < str1.Length; i++)
            {
              for(int j= 0; j< str2.Length; j++)
              {
                    if (str1.ElementAt(i) == str2.ElementAt(j))
                    {
                        if (i == 0 || j == 0)
                        {
                            matrix[i, j]++;
                        }
                        else
                        {
                            matrix[i, j] = matrix[i - 1, j - 1] + 1;
                        }
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                            result = "";
                            result += str1.Substring(i - max + 1, max);
                        }
                    }

                }
            }
            Console.Write(result);
        }

        ///fINDING ANAGRAM USING DICTIONARY

        public Boolean IsAnagram(string inpstr, String pattern)
        {
            if(inpstr.Length != pattern.Length)
            {
                return false;
            }

            Dictionary<char, int> charCountDict = new Dictionary<char, int>();
            int val = 0;
            foreach(char ch in inpstr)
            {
                if(charCountDict.TryGetValue(ch,out val))
                {
                    val++;
                }
                //if(charCountDict.ContainsKey(ch)
                //{
                // charCountDict[ch]++;
                //}

                else
                {
                    //charCountDict[ch] = 1;
                    val = 1;
                }
            }

            foreach(char ch in pattern)
            {
                if(charCountDict.ContainsKey(ch))
                {
                    charCountDict[ch]--;
                }
                else
                {
                    return false; 
                }
            }

            foreach(int value in charCountDict.Keys)
            {
                if (value != 0)
                    return false;
                
            }
            
            return true;
            
        }

        ///////Find the word that is used most
        ///

        public int MaxCountWord(String phrase)
        {
            string[] words;
            int max = 0;

            
            words = phrase.Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCountDict = new Dictionary<string, int>();
            foreach(string str in words)
            {
                if(wordCountDict.ContainsKey(str))
                {
                    wordCountDict[str]++;
                }
                else
                {
                    wordCountDict[str] = 1;

                }
                if (wordCountDict[str] >= max)
                {
                    max = wordCountDict[str];
                }
            }
            return max;
        }
    }
}
