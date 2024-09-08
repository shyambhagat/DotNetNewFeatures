using System;

namespace DotNetNewFeatures
{
    internal static class Demo10_RequiredMembers
    {
        public static void RunDemo()
        {
            var person = new Employee { Name = "John Doe", Age = 30 };
            Console.WriteLine(person);
        }
    }
}
