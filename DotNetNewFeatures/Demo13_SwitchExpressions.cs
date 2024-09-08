using System;

namespace DotNetNewFeatures
{
    internal static class Demo13_SwitchExpressions
    {
        public static void RunDemo()
        {
            Console.WriteLine(GetDayType(DayOfWeek.Monday));
            Console.WriteLine(GetDayType(DayOfWeek.Saturday));
        }

        private static string GetDayType(DayOfWeek day) => day switch
        {
            DayOfWeek.Saturday or DayOfWeek.Sunday => "Weekend",
            _ => "Weekday"
        };
    }
}
