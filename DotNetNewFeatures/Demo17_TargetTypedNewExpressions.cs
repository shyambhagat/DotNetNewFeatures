using System;

namespace DotNetNewFeatures
{
    internal static class Demo17_TargetTypedNewExpressions
    {
        public static void RunDemo()
        {
            Person person = new("John", "Doe");
            Console.WriteLine(person);
        }

        public record Person(string FirstName, string LastName);
    }
}
