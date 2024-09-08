namespace OOPConcepts;

internal static class Demo06_Methods
{
    public static void RunDemo()
    {
        var calculator = new Calculator();
        int sum = calculator.Add(5, 3);
        Console.WriteLine($"Sum: {sum}");
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }
}
