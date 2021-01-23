using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input!= "end of contests")
            {
                string[] contestsLine = input.Split(":");
                string contest = contestsLine[0];
                string contestPassword = contestsLine[1];
                if(!contests.ContainsKey(contest))
                {
                    contests.Add(contest, contestPassword);
                }
                input = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
            string inputSub = Console.ReadLine();
            while (inputSub!= "end of submissions")
            {
                string[] submissionLine = inputSub.Split("=>");
                //"{contest}=>{password}=>{username}=>{points}
                string currentContest = submissionLine[0];
                string password = submissionLine[1];
                string username = submissionLine[2];
                int point = int.Parse(submissionLine[3]);
                if(!contests.ContainsKey(currentContest) || password!=contests[currentContest])
                {
                    inputSub = Console.ReadLine();
                    continue;
                }
                if(!submissions.ContainsKey(username))
                {
                    submissions.Add(username, new Dictionary<string, int>());
                }
                if(!submissions[username].ContainsKey(currentContest))
                {
                    submissions[username].Add(currentContest, point);
                }
                else
                {
                    if(point>submissions[username][currentContest])
                    {
                        submissions[username][currentContest] = point;
                    }
                }
                inputSub = Console.ReadLine();
            }

            var result = submissions.OrderByDescending(kvp => kvp.Value.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {result.Key} with total {result.Value.Values.Sum()} points.");
            Console.WriteLine($"Ranking:");
            foreach (var (key,value) in submissions.OrderBy(x=>x.Key))
            {
                Console.WriteLine(key);
                foreach (var kvp in value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
