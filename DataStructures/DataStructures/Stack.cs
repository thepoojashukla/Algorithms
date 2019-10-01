using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack
    {
        int[] a = new int[10];  //Array implementation
        int top = -1;

        public bool isEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else return false;
        }
        public bool isFull()
        {
            if (top == a.Length - 1)
            {
                return true;
            }
            else return false;
        }
        public int push(int x)
        {
            if (isFull())
            {
                return 0;
            }
            top++;
            return a[top] = x;
        }
        public int pop()
        {
            if (isEmpty())
            {
                return 0;
            }
            else
            {
                return top = top - 1;
            }



        }
        ///////////Linked List Implementation
        public class Node
        {
            public int data;
            public Node next;
        }

        public class linkedList
        {
            public Node ttop;

            public linkedList()
            {
                this.ttop = null; //head pointer
            }


            public void spush(int x) //insert a new node
            {
                Node temp = new Node();
                temp.data = x;
                temp.next = ttop;
                ttop = temp;

            }
            public void spop() //delete a node
            {
                Node temp = new Node();
                if (ttop == null)
                {
                    return;
                }
                temp = ttop;
                ttop = ttop.next;
            }
        }

    }
}