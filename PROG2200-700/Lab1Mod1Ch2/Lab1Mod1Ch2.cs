using System;
using System.Xml.Linq;


namespace Lab1Mod1Ch2

{
    class Lab1Mod1Ch2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the pass code?");
            var code = Console.ReadLine();

            switch (code)
            {

                case "secret":
                    Console.WriteLine("Authenticated");
                    Console.WriteLine("Change Password? y/n");

                    if (Console.ReadLine() != "n")
                        Console.WriteLine("What is the new pass code for this session?");
                    code = Console.ReadLine();
                    Console.WriteLine("The new pass code for this session is " + code);
                    break;

                default:
                    Console.WriteLine("Not Authenticated");
                    break;
            }

        }
    }
}