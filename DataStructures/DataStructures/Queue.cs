using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
   public class Queue
    {
        int[] arr = new int[10];
        int front = -1;
        int rear = -1;
        //int n = arr.Length();

        //int current = i;
        //int previous = (i + n -1) % n;
        //int next = (i + 1) % n;

        public int top()
        {
            return arr[front];
        }

        public Boolean isEmpty()
        {
            if (front == -1 && rear == -1)
            {
                return true;
            }
            else return false;
        }
        public Boolean isFull()
        {
            if (rear == (arr.Length - 1)) //if( (rear + 1)%n == front)
            {

                return true;
            }
            else return false;
        }
        public int enqueue(int x)
        {
            if (isFull())
            {
                Console.Write("Queue is Full");
                return 0;
            }
            else if (isEmpty())
            {
                rear = 0;
                front = 0;   
            }
            rear = (rear + 1); //%n 
          return arr[rear] = x;
            
        } 
        public int dequeue()
        {
            if (isEmpty())
            {
                return 0 ;
            }
            else if( front == rear)
            {
                front = -1;
                rear = -1;
            }

            //return arr[front];
            return front = front + 1; //% n
            
            
        }
    }
}