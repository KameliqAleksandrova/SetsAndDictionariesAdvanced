using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second= new HashSet<int>();
            for (int i = 0; i < numbers[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                first.Add(num);
            }
            for (int i = 0; i < numbers[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                second.Add(num);
            }
            List<int> unique = first.Intersect(second).ToList();
            Console.WriteLine(string.Join(" ", unique));
        }
    }
}
