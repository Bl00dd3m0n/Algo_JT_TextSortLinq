using System;
using System.Collections.Generic;
using System.IO;

namespace Algo_JT_TextSortLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Sorting");
            SortList();
            Console.WriteLine("Sort Dictionary");
            SortDictionary();
        }

        private static void SortDictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Dictionary<int, string> sorted = new Dictionary<int, string>();
            PopulateWords(dictionary);
            DictionarySort ds = new DictionarySort();

            sorted = ds.SortAlphabetically(dictionary);
            Console.WriteLine("Reversed Order press any key to print it");
            PrintDictionary(sorted);

            sorted = ds.FindWordsStartingWith("Z", dictionary);
            Console.WriteLine("All words starting with Z press any key to print it");
            PrintDictionary(sorted);

            sorted = ds.FindWordsStartingWith("He", dictionary);
            Console.WriteLine("All words starting with He press any key to print it");
            PrintDictionary(sorted);

            sorted = ds.FindWordsWithLetterAtPoint("e", 2, dictionary);
            Console.WriteLine("All words starting with the second letter |e| press any key to print it");
            PrintDictionary(sorted);
        }

        private static void SortList()
        {
            List<string> words = new List<string>();
            PopulateWords(words);
            ListLinqSorting lls = new ListLinqSorting();
            List<string> sorted = new List<string>();
            sorted = lls.SortAlphabetically(words);
            Console.WriteLine("Reversed Order press any key to print it");
            PrintList(sorted);
            sorted = lls.FindWordsStartingWith("Z", words);
            Console.WriteLine("All words starting with Z press any key to print it");
            PrintList(sorted);
            sorted = lls.FindWordsStartingWith("He", words);
            Console.WriteLine("All words starting with He press any key to print it");
            PrintList(sorted);
            sorted = lls.FindWordsWithLetterAtPoint("e", 2, words);
            Console.WriteLine("All words starting with the second letter |e| press any key to print it");
            PrintList(sorted);
        }
        private  static void PrintDictionary(Dictionary<int, string> dictionary)
        {
            Console.ReadKey();
            foreach (var word in dictionary)
            {
                Console.Write(word);
            }
            Console.WriteLine("finished printing press any key to go to the next sort");
            Console.ReadKey();
            Console.Clear();
        }
        private static void PrintList(List<string> sorted)
        {
            Console.ReadKey();
            foreach (var word in sorted)
            {
                Console.Write(word);
            }
            Console.WriteLine("finished printing press any key to go to the next sort");
            Console.ReadKey();
            Console.Clear();
        }
        public static void PopulateWords(List<string> words)
        {
            string data;
            FileStream fsSource = new FileStream("C:/Users/Jonathan Taylor/Documents/GitHub/Algo_JT_TextSortLinq/Algo_JT_TextSortLinq/Algo_JT_TextSortLinq/words.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource))
            {
                data = sr.ReadToEnd();
            }
            string word = "";
            foreach(char letter in data)
            {
                word += letter;
                if(letter == '\n')
                {
                    words.Add(word);
                    word = "";
                }
            }
        }
        public static void PopulateWords(Dictionary<int, string> words)
        {
            string data;
            FileStream fsSource = new FileStream("C:/Users/Jonathan Taylor/Documents/GitHub/Algo_JT_TextSortLinq/Algo_JT_TextSortLinq/Algo_JT_TextSortLinq/words.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource))
            {
                data = sr.ReadToEnd();
            }
            string word = "";
            foreach (char letter in data)
            {
                word += letter;
                if (letter == '\n')
                {
                    words.Add(words.Count+1,word);
                    word = "";
                }
            }
        }
    }
}
