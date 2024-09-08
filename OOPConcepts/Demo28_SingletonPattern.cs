namespace OOPConcepts;

internal static class Demo28_SingletonPattern
{
    public static void RunDemo()
    {
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        Console.WriteLine(instance1 == instance2 ? "Instances are the same." : "Instances are different.");
    }

    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance => _instance;
    }
}
