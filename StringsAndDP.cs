using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KalStrings
{
    class StringsAndDP
    {
        //Question - 1

        //Implement an algorithm to determine if a string has all unique characters. What if you
       // cannot use additional data structures

        public bool UniqueCharacter(string str)
        {
            int temp = 0;
            for (int i = 0; i < str.Length; i++)
            {                                                             //o(n)
                int position = (str[i] - 'a');
                if((temp & (1 << position)) > 0)
                {
                    return false;
                }
                temp = temp | (1 << position);
            }
            return true;
        }


        //Question-2
        //Given two strings, write a method to decide if one is a permutation of the other

       public bool IsPermutationString(string inpstr, string pattern) //Anagram
       {

            if (inpstr.Length != pattern.Length)
            {
                return false;
            }

            Dictionary<char, int> charCountDict = new Dictionary<char, int>();
            int val = 0;
            foreach (char ch in inpstr)
            {
                if (charCountDict.TryGetValue(ch, out val))
                {
                    val++;
                }
                else
                {
                    //charCountDict[ch] = 1;
                    val = 1;
                }
            }

            foreach (char ch in pattern)
            {
                if (charCountDict.ContainsKey(ch))
                {
                    charCountDict[ch]--;
                }
                else
                {
                    return false;
                }
            }


            return true;

       }


        //Question - 3
        //Write a method to replace all spaces in a string with ‘%20’.

        public void ReplacedString(string s)
        {
            s = s.Trim();
            s = s.Replace(" ", "%20");
          
            Console.WriteLine(s);
        }


        //Question -4
        //Implement a method to perform a basic string compression using the counts of
        //repeated characters.

        public string Compression(string inpstr)
        {
            char ch = inpstr[0];
            int count = 0;
            string newstr = "";
            for(int i = 0; i < inpstr.Length; i++)
            {
                if(ch == inpstr[i] )
                {
                    count++;
                }

                if(ch != inpstr[i] )
                {
                    newstr = newstr + ch + count;
                    ch = inpstr[i];
                    count = 1;
                }

                if((i+1) >= inpstr.Length)
                {
                    newstr = newstr + ch + count;

                }
            }
            if (newstr.Length > inpstr.Length)
                return inpstr;
            else return newstr;
        }


        //Question - 5
       // Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
       //column are set to 0.

        public int[,] ConvertMatrix(int[,] matrix , int m ,int n)
        {
            bool[] row = new bool[m];
            bool[] col = new bool[n];

            for(int i=0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row[i] = true;
                        col[j] = true;
                    }
                }
            }

            for(int i = 0; i < m; i++)
            {

                if (row[i] == true)
                {
                    for (int j = 0; j < n; j++)
                    { 

                        matrix[i, j] = 0;
                    }
                }
               
            }
            for (int j = 0; j < n; j++)
            {
                if (col[j] == true)
                {
                    for (int i = 0; i < m; i++)
                    {
                        matrix[i, j] = 0;
                    }
                }

            }
            return matrix;
        }

        //Question - 6
        // Given two sequences, print longest common subsequence LCS

        public void LCSubsequence(string str1, string str2)
        {
            int[,] matrix = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 1; i < str1.Length + 1; i++)
            {
                for (int j = 1; j < str2.Length + 1; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                }
            }

            int seqlength = matrix[str1.Length, str2.Length];

            Console.Write(BackTrackSubseq(matrix , str1 , str2 , str1.Length , str2.Length));

        }

        public string BackTrackSubseq(int[,] matrix ,string str1 , string str2 , int i , int j)
        {
            string s = "";

            if( (i == 0) || (j == 0)) 
            {
                return "";
            }
            else
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    return s = BackTrackSubseq(matrix, str1, str2, i - 1, j - 1) + str2[j -1];
                }

                else
                {
                    if (matrix[i - 1, j] > matrix[i, j - 1])
                    {
                        s = BackTrackSubseq(matrix, str1, str2, i - 1, j);
                    }
                    else s = BackTrackSubseq(matrix, str1, str2, i, j - 1);
                }  
            }
            return s;
        }

        //Question - 7
        //Given a string S, find the longest palindromic substring in S.

        public string PalindromeSub(string str)
        {

            int[,] matrix = new int[str.Length + 1, str.Length + 1];
            char[] newstr = str.ToCharArray();
            Stack<char> charstk = new Stack<char>();
            string revstr = "";
            int max = 0;
            string result = "";

            for (int i = 0; i < newstr.Length; i++)
            {
                charstk.Push(newstr[i]);
            }
            for (int i = charstk.Count - 1; i >= 0; i--)
            {
                revstr = revstr + charstk.Pop();
            }

            for(int i = 0; i < str.Length + 1; i++)
            {
                for(int j = 0; j < revstr.Length + 1; j++)
                {
                    if( str[i - 1] == revstr[j - 1])
                    {
                        matrix[i, j] = matrix[i, j ] + 1;
                    }
                    if( matrix[i , j] > max)
                    {
                        max = matrix[i, j];
                        
                        result = result + str.Substring(i - max + 1, i);
                    }
                }
            }

            return result;
        }

        //Question - 8
        //Given a string, recursively remove adjacent duplicate characters from string. The outputstring should not have any adjacent duplicates.

        public string RemoveDuplicate(string str)
        {
            bool duplicatePresent = false;
            string temp = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[i+1])
                {
                    temp = temp + str[i];
                }
                else
                {
                    while(str[i] == str[i+1])
                    {
                        i++;
                    }
                    duplicatePresent = true;
                }

            }
            if (!duplicatePresent)
            {
              return RemoveDuplicate(temp);
            }
            else return str;

        }

        public string RemoveAdjacentDuplicate(string str)
        {
            char lastdeleted = ' ';
            Stack<char> stk = new Stack<char>();
            string result = " ";


            for(int i = 0; i < str.Length; i++)
            {
                if (stk.Count != 0)
                {
                    if (str[i] == stk.Peek())
                    {
                        stk.Pop();
                        lastdeleted = str[i];
                    }
                    else
                    {
                        if (lastdeleted == str[i])
                            continue;
                        else stk.Push(str[i]);
                    }

                }
                else
                {
                    stk.Push(str[i]);
                }
            }

            for(int i = 0; i < stk.Count; i++)
            {
                result = stk.Pop() + result;
            }
            return result;
        }






        //Question - 9
        //Given two strings, the task is to find if a string ('a') can be obtained by rotating another string ('b') by two places.

        public bool RotationPossible(string a , string b)
        {
            char[] aArray = a.ToCharArray();
            char[] bArray = b.ToCharArray();
            char[] newArray = new char[bArray.Length];
            bool result = true;
            for (int i = 0; i < bArray.Length; i++)
            {
                newArray[i] = bArray[(bArray.Length + i - 2) % bArray.Length];

                if (newArray[i] != aArray[i])
                {
                    result = false;
                    break;
                }
            }
            if (result)
                return result;

            for (int i = 0; i < bArray.Length; i++)
            {
                newArray[i] = bArray[(i + 2) % bArray.Length];

                if (newArray[i] != aArray[i])
                {
                    return false;
                }
            }
            return result;
        }
            







        //Question -  10
        //Given an string in roman no format (s) your task is to convert it to integer .

        public int RomanToNumber(string str)
        {
            Dictionary<char, int> dict1 = new Dictionary<char, int>()
                                                          {
                                                                  { 'I' , 1 } ,{ 'V' , 5 },{ 'X' , 10 },
                                                                  { 'L',50 },{ 'C',100 },{ 'D',500 },{ 'M',1000 }
                                                           };

            int result = 0;
            
            

            for (int i = 0; i < str.Length; i++)
            {
               
                int s1 = dict1[str[i]];

                
                if (i + 1 < str.Length)
                {
                    int s2 = dict1[str[i + 1]];

                    
                    if (s1 >= s2)
                    {
                          
                        result = result + s1;
                    }
                    else
                    {
                        result = result + s2 - s1;
                        i++; 
                    }
                }
                else
                {
                    result = result + s1;
                  
                }
            }

           
            return result;

        }


        //Question - 11

        //Given two strings ‘X’ and ‘Y’, find the length of the longest common substring.

        public string LCSubstring(string str1, string str2)
        {
            string result = "";
            int[,] matrix = new int[str1.Length, str2.Length];
            int max = 0;


            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
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
            return result;
        }

        //Question - 12
        //Given two string str1 and str2, find the shortest string that has both str1 and str2 as subsequences.

        public string ShortestSuperstring( string str1 , string str2)
        {
            int[,] matrix = new int[str1.Length + 1, str2.Length + 1];
            int i = 0;
            int j = 0;
            
            for( i = 0; i < str1.Length + 1; i++)
            {
                for( j = 0; j < str2.Length + 1; j++)
                { 
                    if(i == 0)
                    {
                        matrix[i, j] = j;
                    }
                    if(j == 0)
                    {
                        matrix[i, j] = i;
                    }
                    if(str1[i - 1] == str2[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        matrix[i, j] = 1 + Math.Min(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                }
            }

            int index = matrix[str1.Length + 1, str2.Length + 1];

            int m = str1.Length;
            int n = str2.Length;
            string result = "";
            while(m > 0 && n > 0)
            {
                if( str2[n - 1] == str1[m -1])
                {
                    result = result + str2[n - 1];
                    m--;
                    n--;
                }
                else
                {
                    if(matrix[m-1 , n] < matrix[m , n-1])
                    {
                        result = result + str1[m];
                        m--;
                    }
                    else
                    {
                        result = result + str2[n];
                        n--;
                    }
                }

            }

            char temp = ' ';
            char[] store = result.ToCharArray();
            int x = 0;
            int y = store.Length - 1;
            while (x < y)
            { temp = store[i];
                store[x] = store[y];
                store[y] = temp;
                x++;
                y--;
            }

            return store.ToString();
            
        }
        




        //Question - 13
        //Given a string, find length of the longest substring with all distinct characters.

        public int LongestDistinctSubstringLen(string str)
        {
            Dictionary<char, int> indDict = new Dictionary<char, int>();
            int currLen = 0;
            int stindex = 0;
            // startMax = 0; //This is needed when string is returned
            int maxLen = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if(indDict.ContainsKey(str[i]))
                {
                    currLen = i - stindex;
                    if(currLen > maxLen)
                    {
                        maxLen = currLen;
                        //startMax = stindex;
                    }
                    if(indDict[str[i]] >= stindex)
                    {
                        stindex = indDict[str[i]] + 1;
                    }
                    else
                    {//dont do anything..just replace index
                        indDict[str[i]] = i;
                        
                    }


                }
                else
                {
                    indDict[str[i]] = 1;
                }

                currLen = i - stindex;
                if (currLen > maxLen)
                {
                    maxLen = currLen;
                }

            }
            return maxLen;

        }

        




        //Question - 14
        //Implement the function atoi. The function takes a string(str) as argument and converts it to an integer and returns it.
        public int Atoi(string str)
        {
            int result = 0;
            int sign = 1;

            if(str[0] == '-')
            {
                sign = -1;
            }

            for(int i = 1; i< str.Length; i++)
            {
                result = result * 10 + str[i] - '0';
            }
            return sign * result;
        }




        // Question - 15
        //Implement the function strstr. The function takes two strings as arguments(s,x) and
        //locates the occurrence of the string x in the string s.


        public int StrstrOccurence(string s , string x)
        {
            int i = 0;
            int j = 0;
            int num = 0;

           while ( j < x.Length )
           {
                if (s[i] == x[j])
                {
                    j++;
                }

                i++;
           }

          return  num = i - j;
            
        }



        //Question - 16
        //Given an array of N strings, find the longest common prefix among all strings present in the array.

        public string CommonPrefix(string[] strarr , int n)
        {
            int minIndex = int.MaxValue;
            for (int i = 0; i < strarr.Length; i++)
            {
                if (strarr[i].Length < minIndex)
                {
                    minIndex = strarr[i].Length;

                }
            }

            string result = "";
            for(int i = 0; i < minIndex; i++)
            {
                char current = strarr[0].ElementAt(i);

                for(int j = 0; j <n; j++)
                {
                    if (strarr[j].ElementAt(i) != current)
                    {
                        return result;
                    }
                   
                }
                result = result +  current; ;
            }
            return result;
        }



        //Question-17

    }
}
