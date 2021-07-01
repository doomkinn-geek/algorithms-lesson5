using System;

namespace algorithms_lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(50);
            tree.Root.Left = new Node(22);
            tree.Root.Right = new Node(25);
            tree.Root.Left.Left = new Node(28, new Node(64), new Node(34));
            tree.Root.Left.Right = new Node(11);
            tree.Root.Right.Left = new Node(5, new Node(67), new Node(46));
            tree.Root.Right.Right = new Node(77);
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
