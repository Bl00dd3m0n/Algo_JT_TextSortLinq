using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo_JT_TextSortLinq
{
    class DictionarySort
    {
        public Dictionary<int, string> SortAlphabetically(Dictionary<int, string> words)
        {
            Dictionary<int, string> sorted = new Dictionary<int, string>(words.OrderByDescending(key => key.Value));
            return sorted;
        }
        public Dictionary<int, string> FindWordsStartingWith(string Letter, Dictionary<int, string> words)
        {
            Dictionary<int, string> sorted = new Dictionary<int, string>(words.Where(x=>x.Value.StartsWith(Letter)));
            return sorted;
        }
        public Dictionary<int, string> FindWordsWithLetterAtPoint(string letter, int position, Dictionary<int, string> words)
        {
            Dictionary<int, string> sorted = new Dictionary<int, string>(words.Where(x => x.Value.Substring(position-1,1) == letter));
            return sorted;
        }
    }
}
