using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo_JT_TextSortLinq
{
    class ListLinqSorting
    {
        public ListLinqSorting()
        {

        }
        public List<string> SortAlphabetically(List<string> words)
        {
            List<string> sorted = new List<string>(words);
            sorted.Reverse();
            return sorted;
        }
        public List<string> FindWordsStartingWith(string Letter, List<string> words)
        {
            List<string> sorted = words.FindAll(x=>x.StartsWith(Letter));
            return sorted;
        }
        public List<string> FindWordsWithLetterAtPoint(string letter, int position, List<string> words)
        {
            List<string> sorted = words.FindAll(x => x.Substring(position-1,1) == letter);
            return sorted;
        }
    }
}
