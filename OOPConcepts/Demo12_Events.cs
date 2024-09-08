namespace OOPConcepts;

internal static class Demo12_Events
{
    public static void RunDemo()
    {
        var publisher = new Publisher();
        var subscriber = new Subscriber(publisher);

        publisher.PublishEvent("Hello, World!");
    }

    public class Publisher
    {
        public event EventHandler<string> OnPublish;

        public void PublishEvent(string message)
        {
            OnPublish?.Invoke(this, message);
        }
    }

    public class Subscriber
    {
        public Subscriber(Publisher publisher)
        {
            publisher.OnPublish += HandleEvent;
        }

        private void HandleEvent(object sender, string message)
        {
            Console.WriteLine($"Event received: {message}");
        }
    }
}
