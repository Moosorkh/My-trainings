using System;
using System.Collections.Generic;

namespace Geeks4Geeks
{
    class GfG: IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            return x.CompareTo(y);
        }
    }
    public class geek
    {

        static void Main(string[] args)
        {
            List<int> list1 = new List<int>
            {
                //list elements 
                1,5,6,2,4,3
            };
            Console.WriteLine("Original List");
            foreach (int g in list1)
            {
                //Display Original list
                Console.WriteLine(g);
            }
            //"gg" is the object of class GFG
            GfG gg = new GfG();
            Console.WriteLine("\nSort with a comparer:");
            //use of List<T>.Sort(IComparer<T>)
            //method. The comparer is "gg"
            list1.Sort(gg);
            foreach (int g in list1)
            {
                //Display sorted list
                Console.WriteLine(g);
            }
        }
    }
}

