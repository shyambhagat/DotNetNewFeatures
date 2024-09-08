using System;

namespace DotNetNewFeatures
{
    internal static class Demo12_NullCoalescingAssignment
    {
        public static void RunDemo()
        {
            List<int> numbers = null;
            numbers ??= new List<int>();
            numbers.Add(5);
            Console.WriteLine(numbers.Count);
        }
    }
}
