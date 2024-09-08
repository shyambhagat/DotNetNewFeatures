namespace OOPConcepts;

internal static class Demo23_Indexers
{
    public static void RunDemo()
    {
        var collection = new StringCollection();
        collection[0] = "Hello";
        collection[1] = "World";
        Console.WriteLine($"{collection[0]} {collection[1]}");
    }

    public class StringCollection
    {
        private string[] _strings = new string[10];

        public string this[int index]
        {
            get => _strings[index];
            set => _strings[index] = value;
        }
    }
}
