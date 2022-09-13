using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string[] words = Console.ReadLine().Split().Select(word => word.ToLower()).ToArray();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount.Add(word, 0);
                }

                wordCount[word]++;
            }

            string[] oddWords = wordCount.Where(word => word.Value % 2 == 1).Select(w => w.Key).ToArray();
            Console.WriteLine(string.Join(" ", oddWords));
        }
    }
}
