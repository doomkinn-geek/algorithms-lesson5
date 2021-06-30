using System;

namespace algorithms_lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkBinaryTree<int> tree = new LinkBinaryTree<int>(50);
            tree.Root.Left = new Node<int>(22, new Node<int>(33), new Node<int>(44));
            tree.Root.Right = new Node<int>(222, new Node<int>(333), new Node<int>(444));
            tree.Root.Left.Left = new Node<int>(2222, new Node<int>(3333), new Node<int>(4444));
            tree.Root.Left.Right = new Node<int>(1111, new Node<int>(5555), new Node<int>(6666));
            tree.Root.Right.Left = new Node<int>(0, new Node<int>(7777), new Node<int>(8888));
            tree.Root.Right.Right = new Node<int>(0, new Node<int>(77777), new Node<int>(88888));
            tree.BFS(new Node<int>(50));

            Console.ReadLine();
        }        
    }
}
