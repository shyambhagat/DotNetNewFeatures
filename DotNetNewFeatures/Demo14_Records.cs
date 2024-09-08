using System;

namespace DotNetNewFeatures
{
    internal static class Demo14_Records
    {
        public static void RunDemo()
        {
            var person = new Person("John", "Doe");
            Console.WriteLine(person);
            var person2 = person with { LastName = "Smith" };
            Console.WriteLine(person2);
        }

        public record Person(string FirstName, string LastName);
    }
}
