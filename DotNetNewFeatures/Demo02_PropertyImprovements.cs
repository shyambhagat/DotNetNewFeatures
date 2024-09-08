using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo02_PropertyImprovements
    {
        public static void RunDemo()
        {
            var person = new Person
            {
                Name = "John Doe",
                Age = 30,
                Occupation = "Software Developer"
            };

            Console.WriteLine(person);
            Console.WriteLine($"Name using GetName(): {person.GetName()}");
            Console.WriteLine($"Age using GetAge(): {person.GetAge()}");

        }

    }

}
