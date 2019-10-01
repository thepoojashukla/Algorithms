using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    class BinaryTreeNode  //Root Node
    {
        public int data;
        public BinaryTreeNode left;
        public BinaryTreeNode right;

        public BinaryTreeNode(int x)
        {
            this.data = x;
            this.left = null;
            this.right = null;
        }
    }
    class BT
    {
        public BinaryTreeNode root;

        public BT()
        {
            root = null;
        }

        //PreOrder Traversal
        public static void preOrder(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data + " ");
            preOrder(root.left);
            preOrder(root.right);
        }

        //Pop root and Add rightchild prior to left child in stack

        public static void preOrderBT(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<BinaryTreeNode> s = new Stack<BinaryTreeNode>();
            s.Push(root);

            while (s.Count != 0)
            {
                root = s.Pop();
                Console.WriteLine("root.data");
                if (root.right != null)
                {
                    s.Push(root.right);
                }
                while (root.left != null)
                {
                    s.Push(root.left);
                }

            }

        }


        public static void InOrder(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left);
            Console.WriteLine(root.data + " ");
            InOrder(root.right);
            
        }

        //Inorder//To reach the left most and print it first..keep adding left


        public void PrintInOrder(BinaryTreeNode root)
        {
            Stack<BinaryTreeNode> st1 = new Stack<BinaryTreeNode>();

            while (true)
            {
                while (root != null)
                {
                    st1.Push(root); // Keep adding left in stack till reach left most
                    root = root.left;
                }
                if (st1.Count == 0)
                {
                    break;
                }


                root = st1.Pop();
                Console.WriteLine(root.data);
                root = root.right;
            }
        }

        //PostOrder
        public static void postOrder(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            postOrder(root.left);
            postOrder(root.right);
            Console.WriteLine(root.data + " ");
        }

        //Pop root and add it's child..add Popped root to another// Two STACKS
        public static void ItrpostOrder(BinaryTreeNode root)
        {
            if (root == null) return;
            Stack<BinaryTreeNode> s1 = new Stack<BinaryTreeNode>();
            Stack<BinaryTreeNode> s2 = new Stack<BinaryTreeNode>();

            s1.Push(root);
            while(s1.Count != 0)
            {
                root=s1.Pop();
                s2.Push(root);
                if(root.left != null) { s1.Push(root.left); }
                if(root.right != null) { s1.Push(root.right); }
            }

            while(s2.Count != 0)
            {
                Console.WriteLine(s2.Pop().data);
            }
        }

        public static void LevelOrder(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Queue<BinaryTreeNode> StoreQueue = new Queue<BinaryTreeNode>();
            StoreQueue.Enqueue(root);

            while (StoreQueue.Count != 0)
            {
                BinaryTreeNode tempnode = StoreQueue.Dequeue();
                // or root = StoreQueue.Dequeue();
                Console.WriteLine(tempnode.data + " ");
                if (tempnode.left != null) { StoreQueue.Enqueue(tempnode.left); }
                if (tempnode.right != null) { StoreQueue.Enqueue(tempnode.right); }
            }

        }

        //Is Binary TREE or not
        public Boolean IsBST(BinaryTreeNode root)
        {
            Stack<BinaryTreeNode> st1 = new Stack<BinaryTreeNode>();
            int previous = 0;
            while (true)
            {
                while (root != null)
                {
                    st1.Push(root);
                    root = root.left;
                }
                if (st1.Count == 0)
                {
                    break;
                }

                root = st1.Pop();
                if (previous < root.data)
                {
                    previous = root.data;
                }
                else return false;
                root = root.right;
            }
            return true;
        }

        //HEIGHT of a Tree

        public static int HeightofTree(BinaryTreeNode root)
        {
            if (root == null)
            {
                return -1;
            }
            int leftheight = HeightofTree(root.left);
            int rightheight = HeightofTree(root.right);
            return Math.Max(leftheight, rightheight) + 1;
        }

        

        //Insert a Node 
        public static BinaryTreeNode insert(BinaryTreeNode root, int data)
        {
            if (root == null)
            {
                root = new BinaryTreeNode(data);
            }
            else if (data <= root.data)
            {
                root.left = insert(root.left, data);
            }
            else
            {
                root.right = insert(root.right, data);
            }
            return root;

        }
        


        //Size of binary tree:Number of nodes present in a tree

        public static int Sizeoftree(BinaryTreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                return Sizeoftree(root.left) + Sizeoftree(root.right) + 1;
            }
        }

        public static int SizeoftreeNR(BinaryTreeNode root)
        { 
           int count = 0;
            if (root == null)
            {
                return 0;
            }
             Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>();
             q.Enqueue(root);
            
              while (q.Count != 0)
              {
                root = q.Dequeue();
                count++;
                if (root.left != null)
                 {
                   q.Enqueue(root.left);
                 }
                if (root.right != null)
                 {
                  q.Enqueue(root.right);
                 }
              }
            return count;
        }
    
    

    }
}
