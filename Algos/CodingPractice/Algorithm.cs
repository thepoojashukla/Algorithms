using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    public class Algorithm
    { 
   
        public void PrintFibbonacciSeries(int n)
        {
            if(n == 0)
            {
                Console.WriteLine(0);

                return;
            }
            if(n==1)
            {
                Console.Write("0,1");
                return;
            }

            int a = 0, b = 1;
            int c = 0;


           
            Console.Write($"{a},{b},");


            for (int i = 2; i <= n; i++)
            {

                c = a + b;
                if (i == n)
                {
                    Console.Write("{0}", c);//this is to avoid coma in the end of output in console
                }
                else
                {
                    Console.Write("{0},", c);
                }
                a = b;
                b = c;
            }

            
        }

        

        public List<float> CalcList =new List<float>();

        public float sum = 0;
        public float minnum = float.MaxValue;
        public float maxnum = 0;
        public float average = 0;

        public void AddInList(float val)
        {
            CalcList.Add(10);
            CalcList.Add(5);
            CalcList.Add(20);
            CalcList.Add(4);

            CalcList.Add(val);
        }

    


    public void Calculation()
        {
            foreach (float num in CalcList)
            {
                maxnum = Math.Max(maxnum, num);
                minnum = Math.Min(minnum, num);
                sum = num + sum;

            }

            Console.WriteLine($"max is :{maxnum}, min is :{minnum},sum is {sum}");

            average = CalcList.Count / sum;
            Console.WriteLine($"average is:{average}");
         }





        public int x = 0;
        public int y = 0;
        public int lcm = 0;
        public int FindLcm(int num1, int num2)
        {
            x = num1;
            y = num2;
            
            if (num1 == 0 || num2 == 0)

                return 0;

            if (num1 == num2)

               return num1;

            while (num1 != num2)
            {
                if(num1 > num2)
                {
                   num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }

                
            }

            return lcm = (x * y) / num1;



        }

        int gcd;
        public int FindGcd(int num1,int num2)
        {
            if (num1 == 0 || num2 == 0)

                return 0;

           if (num1 == num2)

              return num1;

            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }

             
            }
           return gcd = num1;

        }

        public int RecGcd(int a, int b)
        {
            if (a == b)
                return a;
            if (a == 0 || b == 0)
                return 0;

        }

        public int GetFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }


            else
            { 
              return   num * GetFactorial(num - 1);

            }
            
        }

        public int Factorial(int n)
        {
            int result = 1;
            if (n == 0 || n == 1)
                return 1;
            
            else
            {
                for (int i = 1;i <= n; i++)
                result = result * i;
            }
            return result;
        }

        public int RecursiveFibonacci(int num)
        {
            if (num == 0)
                return 0;
            if (num == 1)
                return 1;
            else
                return RecursiveFibonacci(num - 1) + RecursiveFibonacci(num - 2);
        }

        public int DynamicFib(int num)
        {
            int[] f = new int[num + 1];

            f[0] = 0;                                                     //O(1)
            f[1] = 1;

            for(int i = 2; i<= num ; i++)
            {
                f[num] = f[num - 1] + f[num - 2];
            }
            return f[num];
        }




       public float SquareRoot(int n)
        {
            float low = 0.0f;
           float high = (float)(n + 1);
            while ((high - low) > 0.00001)
            {
                float mid = (low + high) / 2;
                if (mid * mid < n)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }

        public float SqRoot(int num)
        {
            int start = 1;
            int end = num;
            int mid = 0;
            if (num == 0)
                return 0;
            if (num == 1)                                           //log(n)
                return 1;
            else
            {
                mid = start + end / 2;
                if (mid * mid > num)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return mid;    
        }

    }

}
