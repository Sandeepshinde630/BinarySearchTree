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
            BinarySearch.Insert(22);
            BinarySearch.Insert(40);
            BinarySearch.Insert(60);
            BinarySearch.Insert(95);
            BinarySearch.Insert(11);
            BinarySearch.Insert(65);
            BinarySearch.Insert(3);
            BinarySearch.Insert(16);
            BinarySearch.Insert(63);
            BinarySearch.Insert(67);
            BinarySearch.Display();
            BinarySearch.GetSize();
        }
    }
}
