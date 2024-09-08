using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo03_NullConditionalOperators
    {
        public static void RunDemo()
        {
            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 28, Occupation = "Doctor" },
                new Person { Name = null, Age = 35, Occupation = "Engineer" },
                null, // Adding a null entry to demonstrate null-conditional operator
                new Person { Name = "Charlie", Age = 22, Occupation = "Student" }
            };

            foreach (var person in people)
            {
                int? age = person?.Age;
                string name = person?.Name?.ToUpper();
                string occupation = person?.Occupation;

                // Using string interpolation to output information
                Console.WriteLine($"Person Info: Name = {name ?? "Unknown"}, Age = {age?.ToString() ?? "Unknown"}, Occupation = {occupation ?? "Unknown"}");

                try
                {
                    person?.PrintName(person.Name); // Safely call PrintName
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"Exception caught: {ex.Message}");
                }
            }

            Console.WriteLine("End of processing.");
        }
    }
}
