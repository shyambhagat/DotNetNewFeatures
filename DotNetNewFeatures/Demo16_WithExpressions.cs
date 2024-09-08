using System;

namespace DotNetNewFeatures
{
    internal static class Demo16_WithExpressions
    {
        public static void RunDemo()
        {
            var person = new Person("John", "Doe");
            var person2 = person with { LastName = "Smith" };
            Console.WriteLine(person);
            Console.WriteLine(person2);
        }

        public record Person(string FirstName, string LastName);
    }
}
