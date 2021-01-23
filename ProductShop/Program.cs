using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> result = new Dictionary<string, Dictionary<string, double>>();
            while (input!= "Revision")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = command[0];
                string product = command[1];
                double prise = double.Parse(command[2]);
                if(!result.ContainsKey(shopName))
                {
                    result.Add(shopName, new Dictionary<string, double>());
                }
               if(!result[shopName].ContainsKey(product))
                {
                    result[shopName].Add(product, 0);
                }
                result[shopName][product] = prise;
                input = Console.ReadLine();
            }
            var output = result.OrderBy(x => x.Key);
            foreach (var (key,value) in output)
            {
                Console.WriteLine($"{key}->");
                foreach (var item in value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
