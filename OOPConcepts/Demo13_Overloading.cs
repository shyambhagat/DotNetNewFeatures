namespace OOPConcepts;

internal static class Demo13_Overloading
{
    public static void RunDemo()
    {
        var calculator = new Calculator();
        Console.WriteLine($"Add(int, int): {calculator.Add(5, 3)}");
        Console.WriteLine($"Add(double, double): {calculator.Add(5.5, 3.3)}");
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;
    }
}
