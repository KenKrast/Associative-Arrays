using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] spots = commands.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string courseName = spots[0];
                string studentName = spots[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentName);

                commands = Console.ReadLine();
            }

            PrintCourses(courses);
        }

        private static void PrintCourses(Dictionary<string, List<string>> courses)
        {
            foreach (var kvp in courses)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"--{student}");
                }
            }
        }
    }
}
