using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemoreal
{
    //first, let's declare a simple print extension method for all basic collections
    public static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> items)// this before parameter tells compiler this method is going to act on variable after this
        {
            if (items != null)
            {
                foreach (T item in items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }

    class Program
    {
        private static int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main(string[] args)
        {
            /*sugar-free (plain) syntax
            Extensions.Print(nums);*/
            /*extension (sugar) syntax nums.*/
            PrintEvens();
        }

        //get and print all even numbers from nums
        public static void PrintEvens()
        {
            //comprehension sytax
            //IEnumerable<int> evens = from int num in nums
            //                         where num % 2 == 0
            //                         select num;
            //extension
            IEnumerable<int> evens = nums.Where(num => num % 2 == 0);//.Select(num => num); only need select if you want projection //.Take(number) to get the first ones that are encountered
            evens.Print();
        }
    }
}
