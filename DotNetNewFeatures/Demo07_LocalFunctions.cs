using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo07_LocalFunctions
    {
        public static void RunDemo()
        {
            Console.WriteLine(Factorial(5));

            int Factorial(int n)
            {
                if (n <= 1) return 1;
                return n * Factorial(n - 1);
            }
        }
    }

}
