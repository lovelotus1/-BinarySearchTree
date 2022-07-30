using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displaying the message
            Console.WriteLine("Welcome to Binary Search Tree Program");
            Console.WriteLine();
            //Creating binary seaRch tree to insret and display node values(UC1)
            BinSearchTree<int> binaryTree = new BinSearchTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Display();
            Console.WriteLine("\n===================================================");
            Console.ReadLine();
        }
    }
}