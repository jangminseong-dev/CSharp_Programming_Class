using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Sentense : ");
            string hw4_str = Console.ReadLine();

            var words = hw4_str.Split(' ');
            var wordCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word)) wordCounts[word]++;
                else wordCounts.Add(word, 1);
            }

            var mostCommonWord = wordCounts.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            var mostCommonCount = wordCounts[mostCommonWord];
            
            Console.WriteLine(mostCommonWord.ToString() + " / " + mostCommonCount.ToString());
            Console.ReadKey();
        }
    }
}