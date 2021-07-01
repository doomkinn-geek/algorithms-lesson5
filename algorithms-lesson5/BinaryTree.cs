using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lesson5
{
    class Node
    {
        int data;
        Node left;
        Node right;

        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
        }

        public Node()
        {
            data = default(int);
            left = null;
            right = null;
        }

        public Node(int value, Node lChild, Node rChild)
        {
            data = value;
            left = lChild;
            right = rChild;
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
    }    

    class BinaryTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(int value)
        {
            Node p = new Node(value);
            root = p;
        }      

        public void BFS(Node root)
        {
            if (root == null)
                return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                Console.WriteLine(node.Data);
                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }

        public void DFS(Node root)
        {
            if (root == null)
                return;

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while(stack.Count > 0)
            {
                Node node = stack.Pop();
                Console.WriteLine(node.Data);

                if (node.Right != null)
                    stack.Push(node.Right);
                if (node.Left != null)
                    stack.Push(node.Left);                
            }
        }
    }
}
