using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            HashSet<string> result = new HashSet<string>();
            while (inputLine!="END")
            {
                string[] input = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string numberCar = input[1];
                if(command=="IN")
                {
                    result.Add(numberCar);
                }
                else
                {
                    result.Remove(numberCar);
                }

                inputLine = Console.ReadLine();
            }
            if(result.Count>0)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
