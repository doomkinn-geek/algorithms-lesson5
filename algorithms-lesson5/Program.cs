using System;

namespace algorithms_lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>(50);
            tree.Root.Left = new Node<int>(22);
            tree.Root.Right = new Node<int>(25);
            tree.Root.Left.Left = new Node<int>(28, new Node<int>(64), new Node<int>(34));
            tree.Root.Left.Right = new Node<int>(11);
            tree.Root.Right.Left = new Node<int>(5, new Node<int>(67), new Node<int>(46));
            tree.Root.Right.Right = new Node<int>(77);
            Console.WriteLine("BFS:");
            Console.WriteLine(new string('=' ,40));
            tree.BFS(tree.Root);
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("DFS:");
            Console.WriteLine(new string('=', 40));
            tree.DFS(tree.Root);
            Console.WriteLine(new string('=', 40));

            Console.ReadLine();
        }        
    }
}
