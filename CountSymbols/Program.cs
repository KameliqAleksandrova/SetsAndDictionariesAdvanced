﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> elements = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char element = input[i];
                if(!elements.ContainsKey(element))
                {
                    elements.Add(element, 0);
                }
                elements[element]++;
            }
            var result = elements.OrderBy(x => x.Key);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
