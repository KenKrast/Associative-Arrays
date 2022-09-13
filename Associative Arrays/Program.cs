using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            SortedDictionary<int, int> keyValue = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (!keyValue.ContainsKey(number))
                {
                    keyValue.Add(number, 0);
                }
                keyValue[number]++;
            }

            foreach (var keys in keyValue)
            {
                Console.WriteLine($"{keys.Key} -> {keys.Value}");
            }
            
        }
    }
}
    