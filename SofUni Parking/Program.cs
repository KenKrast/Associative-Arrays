using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Enumeration;

namespace SofUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingUsers = new Dictionary<string, string>();

            int userCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < userCount; i++)
            {
                var commands = Console.ReadLine().Split();
                var action = commands[0];
                var user = commands[1];
                //var plateNumber = commands[2];

                switch (action)
                {
                    case "register":
                        var plateNumber = commands[2];
                        if (FindIfUserDoesNotExists(parkingUsers, user))
                        {
                            parkingUsers.Add(user, plateNumber);
                            PrintResult($"{user} registered {plateNumber} successfully");
                        }
                        else
                        {
                            PrintResult($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (FindIfUserDoesNotExists(parkingUsers, user))
                        {
                            PrintResult($"ERROR: user {user} not found");
                        }
                        else
                        {
                            PrintResult($"{user} unregistered successfully");
                            parkingUsers.Remove(user);
                        }
                        break;
                }
            }

            foreach (var parkingUser in parkingUsers)
            {
                PrintResult($"{parkingUser.Key} => {parkingUser.Value}");
            }

        }

        

        static bool FindIfUserDoesNotExists(Dictionary<string, string> parking, string user) => !parking.ContainsKey(user);

        static void PrintResult(string result) => Console.WriteLine(result);
        
    }
}
