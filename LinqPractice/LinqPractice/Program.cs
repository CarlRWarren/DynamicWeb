using System;
using System.Collections.Generic;
using BooksDB;
using BooksDB.Models;
using System.Linq;


namespace LinqPractice
{
    public static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> items)
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
    public class Program
    {
        private static List<Book> books = BookLoader.AllBooks.Where(o=>o!=null).ToList();
        public static void Main(string[] args)
        {
            LanguageCounts();
        }

        //get and print all titles
        public static void PrintAllTitles()
        {
            IEnumerable<string> titles = books.Select(book=>book.Title).OrderBy(t => t);
            titles.Print();
        }

        //what is length of and title of longest book
        public static void LongestTitle()
        {
            IEnumerable<string> titles = books.Select(book => book.Title);
            int maxLength = titles.Max(t => t.Length);
            IEnumerable<string> title = titles.Where(t=>t.Length==maxLength);
            Console.WriteLine($"Length: {maxLength}");
            title.Print();
        }

        //output each language code and how many are in each sorted alphabettically by language code
        public static void LanguageCounts()
        {
            var langCode = books.Select(b => b.Language)
                .GroupBy(l => l)
                .Select(g=> new { Lang=g.Key, Count=g.Count() })
                .OrderBy(lc => lc.Lang);
            langCode.Print();
        }
    }
}
