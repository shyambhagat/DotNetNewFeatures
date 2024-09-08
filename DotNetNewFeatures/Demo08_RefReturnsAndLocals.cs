using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo08_RefReturnsAndLocals
    {
        public static void RunDemo()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            ref int refToNumber = ref FindNumber(3, numbers);
            refToNumber = 42; // Update the array element
            Console.WriteLine(string.Join(", ", numbers));

            ref int FindNumber(int number, int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return ref numbers[i];
                    }
                }
                throw new IndexOutOfRangeException($"{nameof(number)} not found");
            }
        }
    }
}
