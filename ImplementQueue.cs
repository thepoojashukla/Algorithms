using System;
using System.Collections.Generic;
using System.Text;

namespace KalStackQueueProblems
{
    //Implement Queue using Stacks
    class ImplementQueue
    {
        Stack<int> st1 = new Stack<int>();
        Stack<int> st2 = new Stack<int>();

        void Enqueue(int num)
        {
            st1.Push(num);
        }

        int Dequeue()
        {
            if(st2.Count == 0)
            {
                while(st1.Count!= 0)
                st2.Push(st1.Pop());
            }
            return st2.Pop();
        }
    }

    class Stack
    {
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        Queue<int> temp = new Queue<int>();
        void Push(int num)
        {
            q1.Enqueue(num);
        }

        int Pop()
        {
            if (q2.Count == 0)
            {
                while (q1.Count > 1)
                {
                    q2.Enqueue(q1.Dequeue());
                }
            }
            int res =q1.Dequeue();
            temp = q1;
            q1 = q2;
            q2 = temp;
            return res;
        }
    }
}
