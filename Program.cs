using System;
using System.Collections.Generic;
namespace Genlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Ms.");
            myList.Add("Ankita");
            myList.Add("Kharche");

            //Printing Item
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            //Sorting List
            myList.Sort();
            Console.WriteLine("\n After Sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            //Removing Items
            myList.Remove("Ms.");
            Console.WriteLine("\nRemoving Ms.");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            //Inserting Item in the middle
            myList.Insert(2, "N.");
            Console.WriteLine("\nInserting N. at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
        }
    }
    
}
