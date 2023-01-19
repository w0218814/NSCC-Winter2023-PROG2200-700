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
            var month = TryAnswer();


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            switch (month)
            {
                case "march":
                    Console.WriteLine("you are an Aries.");
                    break;
                case "april":
                    Console.WriteLine("you are an Taurus.");
                    break;
                case "may":
                    Console.WriteLine("you are an Gemini.");
                    break;
                case "june":
                    Console.WriteLine("you are an Cancer.");
                    break;
                case "july":
                    Console.WriteLine("you are an Leo.");
                    break;
                case "august":
                    Console.WriteLine("you are an Virgo.");
                    break;
                case "september":
                    Console.WriteLine("you are an Libra.");
                    break;
                case "october":
                    Console.WriteLine("you are an Scorpio.");
                    break;
                case "november":
                    Console.WriteLine("you are an Sagittarius.");
                    break;
                case "december":
                    Console.WriteLine("you are an Capricornus.");
                    break;
                case "january":
                    Console.WriteLine("you are an Aquarius.");
                    break;
                case "february":
                    Console.WriteLine("you are an Pisces.");
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