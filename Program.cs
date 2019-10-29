using System;
using System.Collections.Generic;

namespace KalStackQueueProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PrintNGE(new int[]{ 3, 12, 4, 1, 2, 5});
            PrintNGE(new int[] {2, 3, 1, 2, 3, 4, 5 });
            //Console.WriteLine(EvaluateExpression("2+3*4+6"));
            //Console.WriteLine(EvaluateAnExpression("2+3*4+6"));


            Console.ReadLine();
        }

        //Question - 1
        static char GetMissingParenthesis(string str)
        {
            Stack<char> st = new Stack<char>();
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == '(')
                {
                    st.Push(str[i]);
                }
                if(str[i] == ')')
                {
                    if(st.Count == 0)
                    {
                        return '(' ;
                    }
                    else
                    {
                        st.Pop();
                    }

                }
            }

            if (st.Count == 0)
            {
                return ' ';
            }
            else return ')';

        }


        //Question - 2


        static long EvaluateExpression (string str)
        {
            long answer = 0;
            
            string[] inputarray = str.Split("+");
            long[] outarray  = new long[inputarray.Length];

            for (int i = 0; i < inputarray.Length; i++)
            {
                long product = 1;
                string[] oparray = inputarray[i].Split("*");

                for(int j = 0; j < oparray.Length; j++)
                {
                    product = product * long.Parse(oparray[j]);
                }
                outarray[i] = product;
            }
            for(int i = 0; i < outarray.Length; i++)
            {
                answer = answer + outarray[i];
            }
            return answer;
        }


        //Another Way

        static long EvaluateAnExpression(string str)
        {
            str.ToCharArray();
            Stack<long> st = new Stack<long>();
            st.Push(long.Parse(str[0].ToString()));
            for(int i = 1; i < str.Length-1 ; i++)
            {
                long product = 1;

                if(str[i] == '+')
                {
                    st.Push(long.Parse(str[i + 1].ToString()));
                }
                if (str[i] == '*')
                {
                    if (st.Count > 0)
                    {
                        product = st.Pop() * long.Parse(str[i + 1].ToString());
                        st.Push(product);
                    }
                }
            }

            long sum = 0;
            foreach (long ele in st)
            {
                sum = sum + ele;
            }
            return sum ;
        }


        //Question-3

        static void ReverseStack(Stack<int> inpstack)
        {
            Stack<int> outstack = new Stack<int>();
            int temp = 0;
            int count = 0;

            for (int i = 0; i < inpstack.Count; i++ )
            {
                temp = inpstack.Pop();

                if(outstack.Count == 0)
                {
                    while(inpstack.Count - count != 0)
                    {
                        outstack.Push(inpstack.Pop());
                    }
                }

                inpstack.Push(temp);
                count++;

                while(outstack.Count != 0)
                {
                    inpstack.Push(outstack.Pop());
                }
            }
        }



        //Question - 4
        //in another class
        //Question - 5

        //Question - 6

        static void PrintNGE(int[] arr)
        {
            Stack<int> st = new Stack<int>();

            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == arr.Length - 1)
                    Console.WriteLine($"NGE for {arr[i]} is -1 ");

                else
                {
                    if (arr[i] < arr[i + 1])
                    {
                        st.Push(arr[i + 1]);
                        Console.WriteLine($"NGE for {arr[i]} is {arr[i+1]}");
                    }
                    else
                    {
                        if (st.Count == 0)
                        {
                            Console.WriteLine($"NGE for {arr[i]} is -1 ");
                        }
                        else
                        {
                            while (st.Count != 0)
                            {
                                if (arr[i] < st.Peek())
                                {
                                    Console.WriteLine($"NGE for {arr[i]} is {st.Peek()} ");
                                    st.Push(arr[i]);
                                    break;
                                }
                                else
                                {
                                    st.Pop();
                                    if (st.Count == 0)
                                        Console.WriteLine($"NGE for {arr[i]} is -1 ");
                                    
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
