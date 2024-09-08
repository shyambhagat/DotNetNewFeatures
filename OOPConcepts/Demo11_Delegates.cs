namespace OOPConcepts;

internal static class Demo11_Delegates
{
    public static void RunDemo()
    {
        MathOperation add = Add;
        MathOperation subtract = Subtract;

        Console.WriteLine($"Addition: {add(5, 3)}");
        Console.WriteLine($"Subtraction: {subtract(5, 3)}");
    }

    public delegate int MathOperation(int a, int b);

    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
}
