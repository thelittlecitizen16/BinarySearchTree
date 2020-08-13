using System;
using BinarySearchTree;

namespace CheckBTS
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree.BinarySearchTree b = new BinarySearchTree.BinarySearchTree(5);
            b.AddItem(9);
            b.AddItem(6);
            b.AddItem(2);
            b.AddItem(4);
            b.AddItem(-4);

            Console.WriteLine(b.GetMin());
            Console.WriteLine(b.GetMax());
            Console.WriteLine(b.DeleteItem(2));
            Console.WriteLine(b.Contains(2));
            Console.WriteLine(b.Contains(4));

        }
    }
}
