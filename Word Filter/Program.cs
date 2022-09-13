using System;
using System.Linq;

namespace Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            string[] evenLenghWord = words.Where(word => word.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, evenLenghWord));
        }
    }
}
