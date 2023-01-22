using System;

static class ProgramHelpers
{

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
            result = false;
        }
    }
}