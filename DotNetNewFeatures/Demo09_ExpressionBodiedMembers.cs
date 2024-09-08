using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo09_ExpressionBodiedMembers
    {
        public static void RunDemo()
        {
            var person = new Person { Name = "Jane Doe", Age = 28 };
            Console.WriteLine(person);
        }

    }

}
