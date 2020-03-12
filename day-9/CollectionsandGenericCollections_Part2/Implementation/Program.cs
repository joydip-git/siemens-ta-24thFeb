using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    class Program
    {        
        static void Main()
        {
            Console.Write("enter a sentence: ");
            string sentence = Console.ReadLine();

            //find separators to split the sentence
            var separators = FindSeparators(sentence);

            if (separators != null)
            {
                //convert hashset to an array
                char[] separatorArray = ConvertSetToArray(separators);

                //split the sentence using Split() method of string class, which returns a string array
                string[] words = sentence.Split(separatorArray, StringSplitOptions.RemoveEmptyEntries);

                //iterate through that array and find out which word has appeared and how many times they appear in the sentence
                SortedList<string, int> wordCount = FindWordCount(words);

                //display
                foreach (KeyValuePair<string, int> item in wordCount)
                {
                    Console.WriteLine($"{item.Key}:{item.Value}");
                }
            }
            //do not call me, let me call you, let's watch a movie
            /*
             * call:2
             * do:1
             * let:1
             * me:2
             * not:1
             * you:1
             * */
        }
        static HashSet<char> FindSeparators(string sentence)
        {
            HashSet<char> separators = null;
            if (sentence != null && sentence != string.Empty)
            {
                separators = new HashSet<char>();
                foreach (char ch in sentence)
                {
                    if (!char.IsLetter(ch) && !char.IsDigit(ch) && ch != 39)
                    {
                        separators.Add(ch);
                    }
                }
            }
            return separators;
        }

        private static char[] ConvertSetToArray(HashSet<char> separators)
        {
            char[] finalSeparators = null;
            if (separators != null && separators.Count > 0)
            {
                finalSeparators = new char[separators.Count];
                int index = 0;
                foreach (char ch in separators)
                {
                    finalSeparators[index] = ch;
                    index++;
                }
            }
            return finalSeparators;
        }

        private static SortedList<string, int> FindWordCount(string[] words)
        {
            SortedList<string, int> wordsCount = new SortedList<string, int>();
            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    int count = wordsCount[word];
                    count++;
                    wordsCount[word] = count;
                }
                else
                    wordsCount.Add(word, 1);
            }
            return wordsCount;
        }
    }
}
