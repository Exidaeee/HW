using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);    
            tree.Add(8);    
            tree.Add(1);    
            tree.Add(7);    
            tree.Add(4);
            tree.Add(6);
            tree.Add(9);
            tree.Add(2);
            Console.Write("Preorder: ");
           var preorder =tree.Preorder();//531248769
            foreach (var item in preorder)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();    
            Console.Write("Postorder: ");
            var postorder = tree.Postorder();//214367985
            foreach (var item in postorder)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Inorder: ");
            var inorder = tree.Intorder();
            foreach (var item in inorder)
            {
                Console.Write(item + " ");
            }
        }
    }
}