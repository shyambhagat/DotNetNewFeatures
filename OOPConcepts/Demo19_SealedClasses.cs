namespace OOPConcepts;

internal static class Demo19_SealedClasses
{
    public static void RunDemo()
    {
        var finalClass = new FinalClass();
        finalClass.DisplayMessage();
    }

    public sealed class FinalClass
    {
        public void DisplayMessage() => Console.WriteLine("This is a sealed class.");
    }
}
