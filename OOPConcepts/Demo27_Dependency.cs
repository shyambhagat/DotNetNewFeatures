namespace OOPConcepts;

internal static class Demo27_Dependency
{
    public static void RunDemo()
    {
        var logger = new Logger();
        var service = new Service(logger);
        service.PerformAction("Action performed.");
    }

    public class Logger
    {
        public void Log(string message) => Console.WriteLine($"Log: {message}");
    }

    public class Service
    {
        private readonly Logger _logger;

        public Service(Logger logger)
        {
            _logger = logger;
        }

        public void PerformAction(string message)
        {
            // Perform some action
            _logger.Log(message);
        }
    }
}
