﻿
using System;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("What city do you live in?");
            var city = Console.ReadLine();

            Console.WriteLine("What is your current career?");
            var career = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your city is: {0}", city);
            Console.WriteLine("Your career is: {0}", career);

        }
    }
}
