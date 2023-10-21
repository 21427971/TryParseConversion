using System;

namespace TryParseConversion
{//Msimango KSI
    class Program
    { /* A C# program to convert a string value to integer using a TryParse method.
       If the string value is a text, it will skip the first statement to the else statement.
      If the value is a number,it will output the result*/
        static void Main(string[] args)
        {
            string value = "100";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Unable to find measurement");
            }
            if (result > 0)
            {
                Console.WriteLine($"The measurement report is {202 + result}");
            }
        }
        
    }
}
