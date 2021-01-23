using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(!result.ContainsKey(number))
                {
                    result.Add(number, 0);
                }
                result[number]++;
            }
            foreach (var item in result)
            {
                if(item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }

            }
        }
    }
}
