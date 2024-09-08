using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNewFeatures
{
    internal static class Demo01_CallerInformationAttributes
    {
        public static void RunDemo()
        {
            var logger = new Logger();
            logger.MethodA();
            logger.MethodB();
            logger.MethodC();
        }

    }

    public class Logger
    {
        public void MethodA()
        {
            LogMessage("This is a message from MethodA.");
        }

        public void MethodB()
        {
            LogMessage("This is a message from MethodB.");
        }

        public void MethodC()
        {
            LogMessage("This is a message from MethodC.");
        }

        public void LogMessage(string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Member Name: {memberName}");
            Console.WriteLine($"File Path: {filePath}");
            Console.WriteLine($"Line Number: {lineNumber}");
            Console.WriteLine();
        }
    }
}
