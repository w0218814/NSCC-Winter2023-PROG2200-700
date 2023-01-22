//to be cleaned up

using System;
using System.Xml.Linq;


namespace Lab1Mod2Ch5
{
    internal class Lab1Mod2Ch5
    {

        static void Main(string[] args)
        {
            bool check = false;

            Console.WriteLine("Please Enter the Name");
            var name = TryAnswer().ToLower();

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'a' && name[i] <= 'z' || name[i] == ' ')
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }

            }

            if (check == false)
            {
                Console.WriteLine("Enter Valid Value");
                name = TryAnswer().ToLower();
            }

            Console.WriteLine("What is your age?");
            var age = TryAnswer();
            bool checkAgain = false;

            Console.WriteLine("What month were you born in");
            var month = TryAnswer().ToLower();

            for (int i = 0; i < month.Length; i++)
            {
                if (month[i] >= 'a' && month[i] <= 'z' || month[i] == ' ')
                {
                    checkAgain = true;
                }
                else
                {
                    checkAgain = false;
                    break;
                }

            }

            if (checkAgain == false)
            {
                Console.WriteLine("Enter Valid Value");
                month = TryAnswer().ToLower();
            }


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            switch (month)
            {
                case "march":
                    Console.WriteLine("You are an Aries.");
                    break;
                case "april":
                    Console.WriteLine("You are a Taurus.");
                    break;
                case "may":
                    Console.WriteLine("You are a Gemini.");
                    break;
                case "june":
                    Console.WriteLine("You are a Cancer.");
                    break;
                case "july":
                    Console.WriteLine("You are a Leo.");
                    break;
                case "august":
                    Console.WriteLine("You are a Virgo.");
                    break;
                case "september":
                    Console.WriteLine("You are a Libra.");
                    break;
                case "october":
                    Console.WriteLine("You are a Scorpio.");
                    break;
                case "november":
                    Console.WriteLine("You are a Sagittarius.");
                    break;
                case "december":
                    Console.WriteLine("You are a Capricornus.");
                    break;
                case "january":
                    Console.WriteLine("You are an Aquarius.");
                    break;
                case "february":
                    Console.WriteLine("You are a Pisces.");
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