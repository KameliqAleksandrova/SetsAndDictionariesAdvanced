using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> output = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string countrie = input[1];
                string town = input[2];
                if(!output.ContainsKey(continent))
                {
                    output.Add(continent, new Dictionary<string, List<string>>());
                }
                if(!output[continent].ContainsKey(countrie))
                {
                    output[continent].Add(countrie, new List<string>());
                }
                output[continent][countrie].Add(town);  
            }
            foreach (var (key, value) in output)
            {
                Console.WriteLine($"{key}:");
                foreach (var item in value)
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
