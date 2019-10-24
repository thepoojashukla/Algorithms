using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KalArray
{
    class Assignment1
    {
        //Question -1


        public void AppearOnce(int[] arr,int start , int end)
        {
            if(start == end)
            {
                return;
            }

            int mid = arr.Length / 2;

            if(mid % 2 == 0)                                                                          //logn
            {
                if(arr[mid] == arr[mid + 1])
                {
                    AppearOnce(arr, mid + 2, end);
                }
                else
                {
                    AppearOnce(arr, start, mid-1);
                }
            }
            else
            {
                if (arr[mid] == arr[mid - 1])
                {
                    AppearOnce(arr, mid + 1, end);
                }
                else
                {
                    AppearOnce(arr, start, mid - 1);
                }

            }
              

        }



        //Question - 2

        public int FindMagicIndex(int[] arr)
        {
            int index = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] == i)
                {                                                                      //O(N)
                                                                                        //USING BINARY SEARCH (LOGN)
                    index = i;
                }
                else index = -1;
            }
            return index;
        }

        //OR

        public int FindMagicIndex(int[] arr , int start , int end)
        {
            int mid = start + end / 2;
                                                                                            //Log n
            if (end >= start)
            {
                if (arr[mid] == mid)
                    return mid;
                if(arr[mid]> mid)
                   return FindMagicIndex(arr, start, mid - 1);
               else return FindMagicIndex(arr, mid + 1, end);
            }
            return -1;
        }

            //Question - 3

        public int SearchinRotatedArray(int[] arr, int start, int end ,int key)                //Check the Question
        {
            int mid = start + end / 2;
            if (end >= start)
            {
                if (arr[mid] == key)
                    return mid;

                if (key >= arr[start] && key < arr[mid])                                          // log n
                {
                    return SearchinRotatedArray(arr, start, mid - 1, key);
                }
                else return SearchinRotatedArray(arr, mid + 1, end, key);
            }
            return -1;
        }

       


        //Question-4

        public int DupeNumber(int[] arr, int n)
        {
            int expectedSum = n * (n - 1) / 2;
            int actual = 0;
            int number = 0;                                                //time compl - o(n) space o(1)
            for (int i = 0; i < n - 1; i++)
            {
                actual += arr[i];
            }
            return number =  actual - expectedSum;
        }


        //Question - 5

        public int FindAnElement(int[] arr , int num)
        {
            
            for(int i = 0; i < arr.Length ; i++)                                      //logn
            {
                if (num == arr[i])
                    return i;
                else
                {
                    i = i + Math.Abs(arr[i] - num);
                }
                
            }

            return -1;
        }

        //Question - 6

        public void SplitArray(int[] arr )
        {
            int[] cumarr = new int[arr.Length];
            cumarr[0] = arr[0];
            int sum = 0;

            for(int i = 1; i < cumarr.Length ; i++)                                 //o(2n) space o(n)
            {
                cumarr[i] = arr[i] + cumarr[i - 1];
            }

            sum = cumarr[cumarr.Length - 1];

            for(int j = 0; j < cumarr.Length ; j++)
            {
               if( sum - arr[j] == cumarr[j])
               {
                     Console.WriteLine($"First Array is From 0 to {j-1}");
                     Console.WriteLine($"Sum Array is From {j} to {cumarr.Length - 1}");

               }
            }
            
        }




        //Question - 7

        public int LongestSubArray(int[] arr)
        {
            int max = 0;
            int[] newarr = new int[arr.Length];
            newarr[0] = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {                                                                                 //o(n)
                                                                                                //o(n)
                newarr[i] = arr[i] + newarr[i-1];

                if( newarr[i]> max)
                {
                    max = newarr[i];
                }
            }
            return max;
        }


        //Question - 8

        public int MissingNumber(int[]arr , int n)
        {
            int expectedSum = n * (n + 1) / 2;
            int actual = 0;
            int number = 0;
                                                                                            //o(n)
            for(int i = 0; i < n ; i++)                                   
            {
                actual += arr[i];
            }
           return number = expectedSum - actual;
        }




        //Question - 9 

        public void ContinuousSubArray(int[] arr, int k)
        {
            int[] cumArray = new int[arr.Length];
            cumArray[0] = arr[0];

            if(cumArray[0] == k)
            {
                Console.WriteLine("SubArray starts from Index : 0 to 0");
            }
            
            for (int i = 1; i < arr.Length; i++)
            { 
                if(arr[i] == k)
                {
                    Console.WriteLine($"SubArray starts from Index : {i} to {i}");
                }
                cumArray[i] = arr[i] + cumArray[i - 1];
                if (cumArray[i] == k)
                {
                    Console.Write($"SubArray starts from Index : 0 to {i}");
                }
            }

            for (int i = 0; i <= cumArray.Length - 1; i++)
            {

                for (int j = i + 1; j <= cumArray.Length - 1; j++)
                {

                    if (cumArray[j] - cumArray[i] == k)
                    {
                        Console.Write($"SubArray starts from Index : {i+1} to {j}");
                    }

                }

            }
            Console.WriteLine("SubArray not found");

        }



        //Question - 10

        public void SubArray(int[] arr, int k)
        {
            int[] cumArray = new int[arr.Length];
            cumArray[0] = arr[0];

            if (cumArray[0] == k)
            {
                Console.WriteLine("SubArray starts from Index : 0 to 0");
            }


            for (int i = 1; i <arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    Console.WriteLine($"SubArray starts from Index : {i} to {i}");
                }
                cumArray[i] = arr[i] + cumArray[i - 1];


                if (cumArray[i] == k)
                {
                    Console.Write($"SubArray starts from Index : 0 to {i}");
                }


            }
            
            for (int i = 0; i < cumArray.Length ; i++)
            { 
               for (int j = i; j < cumArray.Length ; j++)
               {

                  if (cumArray[j] - cumArray[i] == k)
                  {
                     Console.Write($"SubArray starts from Index : {i+1} to {j}");
                  }

               }

            }
             Console.WriteLine("SubArray not found");
            
        }






            //Question-11
        public void SortArray(int[] arr)
        {
            int i, count0 = 0,count1= 0 ,count2 = 0;
            int n = arr.Length;
            for( i =0; i < n-1; i++)
            {                                           //Timpe Complexity - O(n)
                if (arr[i] == 0)
                {
                    count0++;
                }
                else if (arr[i] == 1)
                {
                    count1++;
                }
                else if (arr[i] == 2)
                {
                    count2++;
                }
                
            }

             i = 0;  
             while(count0 > 0)
             {
                arr[i] = 0;
                i++;
             }
             while(count1 > 0)
             {
                arr[i] = 1;
                i++;
             }
             while(count2 > 0 )
             {
                arr[i] = 2;
                i++;
             }

             for(i = 0; i< n-1; i++)
             {

                Console.WriteLine(arr[i]);
             }
        }


        //Question-12
        
        public int EquilibriunIndex(int[] arr)
        {
            int sum = 0;
            int[] newarr = new int[arr.Length];

            newarr[0] = arr[0];

            for(int i = 0; i < newarr.Length ; i++)
            {
                newarr[i] = arr[i] + newarr[i - 1];
            }
            sum = newarr[newarr.Length - 1];

            for(int i = 0; i <newarr.Length ; i++ )
            {
                if ((sum - arr[i])/2 == newarr[i - 1])
                {
                    return i;
                }
            }
            return -1;
        }


        //Question - 13


        public int EquilibriunIndex(int[] arr, int n)
        {
            int sum = 0;
            int[] newarr = new int[n];

            newarr[0] = arr[0];

            for (int i = 0; i < n ; i++)
            {
                newarr[i] = newarr[i] + newarr[i - 1];
            }
            sum = newarr[n - 1];

            for (int i = 0; i < n ; i++)
            {
                if ((sum - arr[i]) / 2 == newarr[i - 1])
                {
                    return i;
                }
            }
            return -1;
        }





        //Question-14

        public int PrintLeaders(int[] arr)
        {
            int index = 0;
            int n = arr.Length;
           for (int i = 0; i<= n-1; i++)
            {
                if (i == n - 1)
                {
                    index = arr[n - 1];
                }

                int j = i + 1;
                
                while (arr[i] > arr[j])
                {
                    j++;                   
                }
               index = arr[i];
  
            }
             
            return index;
        }

 
        //Question - 15


        public int SmallestNumber(int[] arr ,int k)
        {
            int number = 0;
            int start = arr[0];
            int end = arr.Length;
            QuickSort(arr, start, end);
            return number = arr[k];
        }
        public void QuickSort(int[] numArray, int start, int end)
        {
            if (start == end)
                return;
            int pivot = start;
            for (int i = start; i <= end; i++)
            {
                if (numArray[i] < numArray[pivot])                                    //nLogn + constant(1)
                {
                    int temp = numArray[i];
                    numArray[i] = numArray[pivot];
                    numArray[pivot] = temp;
                    if (i != end)
                        pivot++;
                }
            }
            QuickSort(numArray, 0, pivot);
            QuickSort(numArray, pivot + 1, end);
        }


        // Question -16






        //Question - 17


        public void SortbyFrequency(int[] arr)
        {
            Dictionary<int, CountAndIndex> freqdict = new Dictionary<int, CountAndIndex>();
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(freqdict.TryGetValue(arr[i], out CountAndIndex freq))
                {
                    freqdict[arr[i]].count++;
                }
                else
                {
                    CountAndIndex countAndIndex = new CountAndIndex() { count = 1, firstIndex = i };
                    freqdict[arr[i]] = countAndIndex;
                }
            }

            var sortedFreqDict = freqdict.OrderByDescending(x => x.Value.count).ThenBy(x => x.Value.firstIndex);

            foreach(var item in sortedFreqDict)
            {
                for (int i = 0; i < item.Value.count; i++)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }

    }
    class CountAndIndex
    {
        public int count { get; set; }
        public int firstIndex { get; set; }
    }
}
