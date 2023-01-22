//to be cleaned up

using System;


namespace Lab1Mod2Ch5
{
    internal class Lab1Mod2Ch5
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();


            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer().ToLower();


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            switch (month)
            {
                case "march":
                    Console.WriteLine("You are an Aries.");
                    break;
                case "april":
                    Console.WriteLine("You are an Taurus.");
                    break;
                case "may":
                    Console.WriteLine("You are an Gemini.");
                    break;
                case "june":
                    Console.WriteLine("You are an Cancer.");
                    break;
                case "july":
                    Console.WriteLine("You are an Leo.");
                    break;
                case "august":
                    Console.WriteLine("You are an Virgo.");
                    break;
                case "september":
                    Console.WriteLine("You are an Libra.");
                    break;
                case "october":
                    Console.WriteLine("You are an Scorpio.");
                    break;
                case "november":
                    Console.WriteLine("You are an Sagittarius.");
                    break;
                case "december":
                    Console.WriteLine("You are an Capricornus.");
                    break;
                case "january":
                    Console.WriteLine("You are an Aquarius.");
                    break;
                case "february":
                    Console.WriteLine("You are an Pisces.");
                    break;
                default:
                    Console.WriteLine("Incorrect Month.");
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