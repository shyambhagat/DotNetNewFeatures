namespace OOPConcepts;

internal static class Demo10_Interfaces
{
    public static void RunDemo()
    {
        var printer = new Printer();
        printer.Print("Hello, World!");
    }

    public interface IPrinter
    {
        void Print(string message);
    }

    public class Printer : IPrinter
    {
        public void Print(string message) => Console.WriteLine(message);
    }
}
