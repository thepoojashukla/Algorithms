using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Heap
    {
      public  void MaxHeapify(int[] A ,int index,int N)
        {
            int heap_size = N;
            //int parent = index/2;
           
            int largest = index;
            int left = 2* index + 1;
            int right = 2* index + 2;

            if (left < heap_size &&  A[left] > A[index] )
            {
                largest = left;
            }

            else largest = index;

            if(right < heap_size &&  A[right] > A[largest] )
            {
                largest = right;
            }
            
            if(largest != index)
            {
                int temp = 0;
                temp = A[index]; 
                 A[index] = A[largest];
                A[largest] = temp;
                MaxHeapify(A, largest,N );
            }

            
        }

        public  void BuildMaxHeap(int[] A)
        {
           
          int n = A.Length;
            for (int i = n/2 - 1; i >= 0; i--)          //leaves nodes start from  (n/2)+ 1 to n
            { MaxHeapify(A, i,n);
            }                                 // So non leaf nodes 1 to n/2..operation is performed on nonleaf 

        }

        public void Max_heap_sort(int[] A,int N)
        {
            int heap_size = N;
            BuildMaxHeap(A);                                //for given array create max heap then swap a[1] with a[last]
            for (int i = N-1; i >= 1; i--)     //till 2 bcz 1st will remain at last in the array
            {
                int temp = 0;
                temp = A[0];
                A[0] = A[i];          //swap(Arr[1], Arr[i]);
                A[i] = temp;
                                            
                heap_size = heap_size - 1;
                MaxHeapify(A, 0 , heap_size);
            }
        }

        //Priority Queue

       

            public void InsertValue(int[] Arr, int val)
            {
                int length = Arr.Length;
                length = length + 1;
                Arr[length] = -1;  //assuming all the numbers greater than 0 are to be inserted in queue.
                increase_value(Arr, length, val);
            }

            public void increase_value(int[] Arr, int i, int val)
            {
                if (val < Arr[i])
                {

                    return;
                }
                Arr[i] = val;
                while (i > 1 && Arr[i / 2] < Arr[i])
                {
                    int temp = 0;             //swap(Arr[i / 2], Arr[i]);
                    temp = Arr[i / 2];
                    Arr[i / 2] = Arr[i];
                    Arr[i] = temp;
                    i = i / 2;
                }
            }

            public int extract_maximum(int[] Arr)
            {
                int length = Arr.Length;
                if (length == 0)
                {

                    return -1;
                }
                int max = Arr[1];
                Arr[1] = Arr[length];
                length = length - 1;
                MaxHeapify(Arr, 1, length);
                return max;
            }

            int maximum(int[] Arr)
            {
                return Arr[1];  //as the maximum element is the root element in the max heap.
            }
        

        //void min_heapify(int[] Arr, int index)
        //{   
        //    int left = 2 * index;
        //    int right = 2 * index + 1;
        //    int smallest = 0;
        //    int N = Arr.Length;
        //    if (left <= N &&  Arr[left] < Arr[index] )
        //    smallest = left;
        //    else
        //     smallest = index;
        //    if (right <= N && Arr[right] < Arr[smallest] )
        //     smallest = right;
        //    if (smallest != index)
        //    {
        //        int temp = 0;
        //        temp = Arr[index];
        //        Arr[index] = Arr[smallest];
        //        Arr[smallest] = temp;
        //        min_heapify(Arr, smallest);
        //    }
        //}

        //void build_minheap(int[] Arr)
        //{    
        //    for (int i = Arr.Length / 2; i >= 1; i--)
        //     min_heapify(Arr, i);
        //}
    }
}
