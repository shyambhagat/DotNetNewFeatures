namespace OOPConcepts;

internal static class Demo29_GenericClasses
{
    public static void RunDemo()
    {
        var intContainer = new Container<int>(123);
        var stringContainer = new Container<string>("Hello");

        Console.WriteLine(intContainer.GetItem());
        Console.WriteLine(stringContainer.GetItem());
    }

    public class Container<T>
    {
        private T _item;

        public Container(T item)
        {
            _item = item;
        }

        public T GetItem() => _item;
    }
}
