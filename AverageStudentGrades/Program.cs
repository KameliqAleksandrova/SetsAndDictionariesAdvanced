using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> result = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputLine[0];
                decimal grade = decimal.Parse(inputLine[1]);
                if (!result.ContainsKey(name))
                {
                    result.Add(name, new List<decimal>());
                }
                result[name].Add(grade);
            }
            foreach (var item in result)
            {
                string name = item.Key;
                List<decimal> grades = item.Value;
                decimal average = grades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
