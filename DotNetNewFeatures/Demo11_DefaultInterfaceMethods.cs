using System;

namespace DotNetNewFeatures
{
    internal static class Demo11_DefaultInterfaceMethods
    {
        public static void RunDemo()
        {
            IGreeter greeter = new Greeter();
            greeter.Greet();
            greeter.DefaultGreet();
        }
    }

    public interface IGreeter
    {
        void Greet();
        void DefaultGreet() => Console.WriteLine("Hello from default implementation!");
    }

    public class Greeter : IGreeter
    {
        public void Greet() => Console.WriteLine("Hello from Greeter!");
    }
}
