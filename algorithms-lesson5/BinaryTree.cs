using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lesson5
{
    class Node<T>
    {
        T data;
        Node<T> left;
        Node<T> right;

        public Node(T value)
        {
            data = value;
            left = null;
            right = null;
        }

        public Node()
        {
            data = default(T);
            left = null;
            right = null;
        }

        public Node(T value, Node<T> lChild, Node<T> rChild)
        {
            data = value;
            left = lChild;
            right = rChild;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node<T> Right
        {
            get { return right; }
            set { right = value; }
        }
    }

    class BinaryTree<T>
    {
        private Node<T> root;
        public Node<T> Root
        {
            get { return root; }
        }

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T value)
        {
            Node<T> p = new Node<T>(value);
            root = p;
        }
        
        public void PrintTree()
        {
            if (root == null)
                return;

            Console.WriteLine(root.Data);

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                Console.WriteLine(node.Data);
                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }        

        public void BFS(Node<T> root)
        {
            if (root == null)
                return;

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                Console.WriteLine(node.Data);
                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }

        public void DFS(Node<T> root)
        {
            if (root == null)
                return;

            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(root);
            while(stack.Count > 0)
            {
                Node<T> node = stack.Pop();
                Console.WriteLine(node.Data);
                if (node.Left != null)
                    stack.Push(node.Left);

                if (node.Right != null)
                    stack.Push(node.Right);
            }
        }
    }
}
