using System;

namespace DotNetNewFeatures
{
    internal static class Demo05_Tuples
    {
        public static void RunDemo()
        {
            var person = GetPerson();
            Console.WriteLine($"Name: {person.name}, Age: {person.age}");
        }

        private static (string name, int age) GetPerson()
        {
            return ("John Doe", 30);
        }
    }
}
