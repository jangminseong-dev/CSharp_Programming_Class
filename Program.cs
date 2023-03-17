using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1번 문제
            string hw1_str = "";
            Console.Write("Enter Integer : ");
            hw1_str = Console.ReadLine();
            if (Regex.Replace(hw1_str, @"[^0-9]", "") != "")
            {
                if (int.Parse(hw1_str) > 0)
                    Console.WriteLine(hw1_str + " is positive number.");
                else if (int.Parse(hw1_str) < 0)
                    Console.WriteLine(hw1_str + " is negative number.");
                else
                    Console.WriteLine(hw1_str + " is Zero.");
            }
            else
                Console.WriteLine("Error: Input is only integer.");
            Console.ReadKey();

            //2번 문제
            Console.Write("Enter String : ");
            string hw2_str = Console.ReadLine();
            int count = 0;

            foreach(char ch in hw2_str.ToLower())
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    count++;
            }
            Console.WriteLine("The number of vowels is " + count.ToString());
            Console.ReadKey();

            //3번 문제
            Console.Write("Enter Integers(스페이스로 구분) : ");
            string hw3_str = Console.ReadLine();
            var nums = hw3_str.Split(' ');
            List<int> hw3_result = new List<int>();

            foreach (string item in nums)
            {
                int num = int.Parse(item);
                if (!hw3_result.Contains(num)) hw3_result.Add(num);
            }
            // foreach (int num in hw3_result)
            //     Console.Write(num + " ");

            Console.WriteLine($"{String.Join(", ", hw3_result)}");
            Console.ReadKey();

            //4번 문제
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

            //5번 문제
            Console.Write("Enter Integers(스페이스로 구분) : ");
            string hw5_str = Console.ReadLine();
            int[] hw5_result = Array.ConvertAll(hw5_str.Split(' '), int.Parse);

            Array.Sort(hw5_result);
            Console.WriteLine($"{String.Join(", ", hw5_result)}");
            Console.ReadKey();

            //6번 문제
            Console.Write("Enter Sentense : ");
            string hw6_str = Console.ReadLine();
            string hw6_result = Regex.Replace(hw6_str, @"\d", "");
            Console.WriteLine($"{hw6_result.ToUpper()}");
            Console.ReadKey();

            //7번 문제
            string hw7_str = "";
            Console.Write("Enter Integer : ");
            hw7_str = Console.ReadLine();
            if (Regex.Replace(hw7_str, @"[^0-9]", "") != "")
            {
                Console.WriteLine(Convert.ToString(int.Parse(hw7_str), 2));
            }
            else
                Console.WriteLine("Error: Input is only integer.");
            Console.ReadKey();
        }
    }
}