using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Searching //Find two missing numbers
{  
    class LinearSearch
    {
        public void GetMissingNumber(int[] arr, int n) //array and its size
        {
            int[] holder_arr = new int[n + 1];
            
            for(int i = 0; i< n-2; i++)
            {
                holder_arr[arr[i]] = 1;
            }

            for(int i= 1; i < n+1;i++)
            {
                if(holder_arr[i] != 1 )
                {
                    Console.Write( i + " " );
                }
            }
        }
    }
}
