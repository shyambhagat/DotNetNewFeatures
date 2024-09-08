namespace OOPConcepts;

internal static class Demo20_InnerClasses
{
    public static void RunDemo()
    {
        var outer = new OuterClass();
        var inner = new OuterClass.InnerClass();
        inner.DisplayMessage();
    }

    public class OuterClass
    {
        public class InnerClass
        {
            public void DisplayMessage() => Console.WriteLine("This is an inner class.");
        }
    }
}
