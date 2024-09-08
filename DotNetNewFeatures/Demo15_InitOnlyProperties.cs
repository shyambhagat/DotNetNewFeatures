using System;

namespace DotNetNewFeatures
{
    internal static partial class Demo15_InitOnlyProperties
    {
        public static void RunDemo()
        {
            var person = new Client { FirstName = "John", LastName = "Doe" };
            Console.WriteLine(person);
        }
    }
}
