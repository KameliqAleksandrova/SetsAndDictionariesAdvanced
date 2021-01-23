using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> result = new SortedSet<string>();
            for (int i = 0; i < num; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    string element = elements[j];
                    result.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
