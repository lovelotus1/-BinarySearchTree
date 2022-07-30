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

            while (true)
            {
                Console.WriteLine("1: Insert Default Values \n2: Insert More Values \n3: Display Binary Tree Values \n4: Get Size of Binary Tree" + "\n5 Check The Value Exist or Not \n6: Exit");
                Console.Write("Enter a Choice from Above :");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Inserting default values in binary tree
                        binaryTree.Insert(30);
                        binaryTree.Insert(70);
                        binaryTree.Insert(40);
                        binaryTree.Insert(22);
                        binaryTree.Insert(60);
                        binaryTree.Insert(95);
                        binaryTree.Insert(11);
                        binaryTree.Insert(65);
                        binaryTree.Insert(3);
                        binaryTree.Insert(16);
                        binaryTree.Insert(63);
                        binaryTree.Insert(67);
                        Console.WriteLine("Values is Inserted into Binary Tree\n");
                        break;
                    case 2:
                        //Taking the value from user to enter value in binary tree
                        Console.Write("Enter Any Value in Binary Search Tree : ");

                        binaryTree.GetSize();
                        break;
                    case 5:
                        //Checking the given Value exists or not (UC3)
                        Console.Write("Enter a Value to Check if its Exist or Not in Binary Tree :");
                        int valCheck = int.Parse(Console.ReadLine());
                        bool result = binaryTree.IfValueExists(valCheck, binaryTree);
                        if (result)
                        {
                            Console.WriteLine("The Given Value {0} is Present in Binary Tree \n", valCheck);
                        }
                        else
                        {
                            Console.WriteLine("The Given Value {0} is not Present in Binary tree \n", valCheck);
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        continue;
                }
            }
            Console.ReadLine();
        }
    }
}