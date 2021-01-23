using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
           
            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] commandLine = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandLine[1];
                string vloggerName = commandLine[0];
                if (command == "joined")
                {                    
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        vloggers[vloggerName].Add("followers", new SortedSet<string>());
                        vloggers[vloggerName].Add("following", new SortedSet<string>());
                    }
                }
                else
                {
                    string vloggerNameTwo = commandLine[2];
                    if(vloggers.ContainsKey(vloggerName) && vloggers.ContainsKey(vloggerNameTwo) 
                        && !vloggerName.Equals(vloggerNameTwo))
                    {
                        vloggers[vloggerName]["following"].Add(vloggerNameTwo);
                        vloggers[vloggerNameTwo]["followers"].Add(vloggerName);
                    }                 
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count} vloggers in its logs.");
            vloggers = vloggers
                .OrderByDescending(x => x.Value["followers"].Count())
                .ThenBy(x => x.Value["following"].Count())
                .ToDictionary(x => x.Key, v => v.Value);
            int count = 1;
            foreach (var (key, value) in vloggers)
            {
                Console.WriteLine($"{count++}. {key} : {value["followers"].Count} followers, {value["following"].Count} following");
                if (count == 2)
                {
                    foreach (var item in value["followers"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
            }
        }
    }
}

