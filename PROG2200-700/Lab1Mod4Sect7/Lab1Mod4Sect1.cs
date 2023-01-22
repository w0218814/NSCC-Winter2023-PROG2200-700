using System;
using System.Text.RegularExpressions;

namespace Lab1Mod4Sect1
{ 
    // -------- Modification#1 --------
    enum monthCategory
{
    January = 0,
    February = 1,
    March = 2,
    April = 3,
    May = 4,
    June = 5,
    July = 6,
    August = 7,
    September = 8,
    October = 9,
    November = 10,
    December = 11,
}

    class Lab1Mod4Sect1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            Console.WriteLine("January = 0\nFebruary = 1\nMarch = 2\nApril = 3\nMay = 4\nJune = 5\nJuly = 6\nAugust = 7\nSeptember = 8\nOctober = 9\nNovember = 10\nDecember = 11");
            var month = int.Parse(TryAnswer());
            monthCategory monthName = (monthCategory)month;

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            switch (month)
            {
                case 2:
                    Console.WriteLine("You are an Aries.");
                    break;
                case 3:
                    Console.WriteLine("You are an Taurus.");
                    break;
                case 4:
                    Console.WriteLine("You are an Gemini.");
                    break;
                case 5:
                    Console.WriteLine("You are an Cancer.");
                    break;
                case 6:
                    Console.WriteLine("You are an Leo.");
                    break;
                case 7:
                    Console.WriteLine("You are an Virgo.");
                    break;
                case 8:
                    Console.WriteLine("You are an Libra.");
                    break;
                case 9:
                    Console.WriteLine("You are an Scorpio.");
                    break;
                case 10:
                    Console.WriteLine("You are an Sagittarius.");
                    break;
                case 11:
                    Console.WriteLine("You are an Capricornus.");
                    break;
                case 0:
                    Console.WriteLine("You are an Aquarius.");
                    break;
                case 1:
                    Console.WriteLine("You are an Pisces.");
                    break;
                default:
                    Console.WriteLine("Incorrect Month number.");
                    break;
            }
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}





