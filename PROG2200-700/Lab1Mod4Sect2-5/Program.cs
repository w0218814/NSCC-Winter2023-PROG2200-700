using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1Mod4Sect2_5


{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;

            Console.WriteLine(x);

            Five(out x);

            Console.WriteLine(x);

            Double(ref x);
            Console.WriteLine(x);

            var test = "1.5";
            var outDouble = 0.0;
            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            Console.WriteLine("Test value is {0}", outDouble);
            test = "Ronan";
            outDouble = 0.0;
            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble));
            Console.WriteLine("Test value is {0}", outDouble);


        }

        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        static void Double(ref int a)
        {
            a = a * 2;
            Console.WriteLine(a);
        }
        static bool ParseDouble(string testString, out double outDouble)
        {
            outDouble = 0.0;
            bool result = false;
         
            try
            {
                if (double.Parse(testString).GetType() == outDouble.GetType())
                {
                    outDouble = double.Parse(testString);
                    result = true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Caught Exception");
            }
            return result;
        }
    }
}
