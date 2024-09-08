using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo04_ExceptionFilter
    {
        public static void RunDemo()
        {
            var data = new List<string> { "42", "hello", "100", "world", "200" };

            foreach (var item in data)
            {
                try
                {
                    int number = ParseStringToInt(item);
                    Console.WriteLine($"Parsed number: {number}");
                }
                catch (FormatException ex) when (ex.Message.Contains("Input string was not in a correct format"))
                {
                    Console.WriteLine($"Specific error handled: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General error handled: {ex.Message}");
                }
            }

            static int ParseStringToInt(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Input cannot be null or whitespace.", nameof(input));

                return int.Parse(input); // This will throw FormatException for non-numeric strings
            }
        }

    }

}
