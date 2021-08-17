using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinarySearchTree Demo!");
            BinarySearchTree<int> BinarySearch = new BinarySearchTree<int>(56);
            BinarySearch.Insert(30);
            BinarySearch.Insert(70);
            BinarySearch.Display();
        }
    }
}
