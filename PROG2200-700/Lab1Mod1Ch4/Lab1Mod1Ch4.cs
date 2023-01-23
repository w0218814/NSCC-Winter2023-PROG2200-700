using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students?");
            var studentCount = int.Parse(Console.ReadLine());
            var studentArray = new string[studentCount, 2];

            for (int i = 0; i < studentArray.GetLength(0); i++)
            {
                Console.WriteLine("Name of Student: ");
                studentArray[i, 0] = Console.ReadLine();

                Console.WriteLine("Student Grade: ");
                studentArray[i, 1] = Console.ReadLine();

            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade {1}", studentArray[i, 0], studentArray[i, 1]);
            }
        }
    }
}