using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");
                if (!result.ContainsKey(color))
                {
                    result.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    string model = clothes[j];
                    if (!result[color].ContainsKey(model))
                    {
                        result[color].Add(model, 1);
                    }
                    else
                    {
                        result[color][model]++;
                    }
                }
            }
            string[] command = Console.ReadLine().Split();
            string resultColor = command[0];
            string resultModel = command[1];
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (item.Key == resultColor && cloth.Key == resultModel)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
