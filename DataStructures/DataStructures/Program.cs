using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        { //  Queue q1 = new Queue();
        //    Stack a1 = new Stack();

        //    Console.WriteLine(q1.enqueue(5));
        //    Console.WriteLine(q1.enqueue(10));
        //    Console.WriteLine(q1.enqueue(15));
        //    Console.WriteLine(q1.enqueue(20));
        //    Console.WriteLine(q1.dequeue());
        //    Console.WriteLine(q1.dequeue());
        //    Console.WriteLine(q1.enqueue(15));
        //    Console.WriteLine(q1.enqueue(20));
        //    Console.WriteLine(q1.top());

        //    Console.WriteLine(a1.push(5));
        //    Console.WriteLine(a1.push(10));
        //    Console.WriteLine(a1.push(15));
        //    Console.WriteLine(a1.push(20));
        //    Console.WriteLine(a1.pop());
        //    Console.WriteLine(a1.pop());

           




            Heap h1 = new Heap();
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10;
            Console.WriteLine("Heap Sort");
            Console.WriteLine("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                //Console.Write(arr[i] + " "); //or
                Console.Write($"Array is {arr[i] + " "}");
            }

            h1.BuildMaxHeap(arr);

            Console.WriteLine("\nMax Heap is : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            h1.Max_heap_sort(arr,10);

            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
