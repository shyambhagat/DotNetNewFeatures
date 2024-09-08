using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo06_PatternMatching
    {
        public static void RunDemo()
        {
            object[] items = {
                "Hello",
                123,
                45.6,
                null,
                new Person { Name = "Alice", Age = 28, Occupation = "Doctor" },
                new Person { Name = "Bob", Age = 40, Occupation = "Engineer" },
                new Person { Name = "Charlie", Age = 22, Occupation = "Student" }
            };

            foreach (var item in items)
            {
                PrintType(item);
            }
        }

        private static void PrintType(object item)
        {
            switch (item)
            {
                case int i:
                    Console.WriteLine($"Integer: {i}");
                    break;
                case string s:
                    Console.WriteLine($"String: {s}");
                    break;
                case double d:
                    Console.WriteLine($"Double: {d}");
                    break;
                case null:
                    Console.WriteLine("Null");
                    break;
                case Person p when p.Age > 30:
                    Console.WriteLine($"Person: {p.Name}, Age: {p.Age}, Occupation: {p.Occupation} - Senior");
                    break;
                case Person p:
                    Console.WriteLine($"Person: {p.Name}, Age: {p.Age}, Occupation: {p.Occupation} - Junior");
                    break;
                default:
                    Console.WriteLine("Unknown type");
                    break;
            }

        }
    }
}
