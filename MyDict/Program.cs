using System;
using System.Collections.Generic;

namespace MyDict
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new SortedDictionary
            //of strings, with string keys
            SortedDictionary<string, string> myDict = new SortedDictionary<string, string>();

            //Adding key/value pairs in myDict
            myDict.Add("Australia", "Canberra");
            myDict.Add("Belgium", "Brussels");
            myDict.Add("NetherLand", "Amsterdam");
            myDict.Add("China", "Beijing");
            myDict.Add("Russia", "Moscow");
            myDict.Add("India", "Delhi");
            // To get count of key/value pairs in myDict

            Console.WriteLine("Total key/value pairs"+" in myDict are: "+ myDict.Count);

            //To get the keys alone,
            //use the keys property
            SortedDictionary<string, string>.KeyCollection keyColl = myDict.Keys;

            //The elements of the MyCollection
            //Are strongly typed with the type
            //that was specified for dictionary keys
            foreach (string s in keyColl)
            {
                Console.WriteLine($"Key = {s}");
            }
        }
    }
}
