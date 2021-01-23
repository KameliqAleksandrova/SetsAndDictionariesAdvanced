using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> result = new Dictionary<double, int>();
            for (int i = 0; i < inputLine.Length; i++)
            {
                double number = inputLine[i];
                if(!result.ContainsKey(number))
                {
                    result.Add(number,0);
                }
                result[number]++;
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
