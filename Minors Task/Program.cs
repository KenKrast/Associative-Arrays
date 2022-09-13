using System;
using System.Collections.Generic;

namespace Minors_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(input))
                {
                    items.Add(input, 0);
                }

                items[input] += quantity;
                input = Console.ReadLine();
            }

            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

    }
}
