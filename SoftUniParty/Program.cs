using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputGuests = Console.ReadLine();
            HashSet<string> result = new HashSet<string>();
            while (inputGuests!="PARTY")
            {
                result.Add(inputGuests);
                inputGuests = Console.ReadLine();
            }
            string input = Console.ReadLine();
            while (input!="END")
            {
                result.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(result.Count);
            foreach (var item in result)
            {
                if(char.IsDigit(item[0]))
                {
                    Console.WriteLine(item); ;
                }                
            }
            foreach (var item in result)
            {
                if (char.IsLetter(item[0]))
                {
                    Console.WriteLine(item); ;
                }
            }
        }
    }
}
