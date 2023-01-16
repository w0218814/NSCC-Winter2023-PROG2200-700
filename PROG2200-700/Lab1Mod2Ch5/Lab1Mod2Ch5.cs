using System;


namespace Lab1Mod2Ch5
{
    internal class Lab1Mod2Ch5
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            int Y;

            if (string.IsNullOrEmpty(name))
                while (Int32.TryParse(name, out Y))
                {
                    Console.WriteLine("Field cannot be a number, try again.");

                    name = TryAnswer();
                }
            {
                Console.WriteLine("Field can't be empty! Please try again once more");
                name = Console.ReadLine();
            }


            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            int X;


            if (string.IsNullOrEmpty(age))
                while (!Int32.TryParse(age, out X))
                {
                    Console.WriteLine("Not a valid integer, please try again.");

                    age = TryAnswer();
                }
            {
                Console.WriteLine("Field can't be empty! Please try again once more");
                age = Console.ReadLine();
            }

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();
            int Z;

            if (string.IsNullOrEmpty(month))
                while (Int32.TryParse(month, out Z))
                {
                    Console.WriteLine("Field cannot be a number, try again.");

                    month = TryAnswer();
                }
            {
                Console.WriteLine("Field can't be empty! Please try again once more");
                month = Console.ReadLine();
            }

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if (month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
            else if (month == "october")
            {
                Console.WriteLine("you are a Scorpio.");
            }
            else if (month == "november")
            {
                Console.WriteLine("you are a Sagittarius.");
            }
            else if (month == "december")
            {
                Console.WriteLine("you are a Capricornus.");
            }
            else if (month == "january")
            {
                Console.WriteLine("you are a Aquarius.");
            }
            else if (month == "february")
            {
                Console.WriteLine("you are a Pisces.");
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