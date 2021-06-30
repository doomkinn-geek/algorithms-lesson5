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

    class LinkBinaryTree<T>
    {
        private Node<T> root;//Root node
        public Node<T> Root
        {
            get { return root; }
        }

        public LinkBinaryTree()
        {
            root = null;
        }

        public LinkBinaryTree(T value)
        {
            Node<T> p = new Node<T>(value);
            root = p;
        }

        //Three kinds of depth traversal

        //Sequential traversal

        public void InOrder(Node<T> node)
        {
            if (root == null)
                return;
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Data);
                InOrder(node.Right);
            }
        }

        //Preorder traversal

        public void PreOrder(Node<T> node)
        {
            if (root == null)
                return;
            if (node != null)
            {
                Console.Write(node.Data);
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        //Post order traversal

        public void PostOrder(Node<T> node)
        {
            if (root == null)
                return;

            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Data);
            }
        }

        //-------Breadth traversal----------Using queues is also known as FIFO
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
    }
}
