namespace OOPConcepts;

internal static class Demo24_Composition
{
    public static void RunDemo()
    {
        var car = new Car(new Engine("V8"));
        car.Start();
    }

    public class Engine
    {
        public string Type { get; set; }

        public Engine(string type)
        {
            Type = type;
        }

        public void Start() => Console.WriteLine($"Engine {Type} started.");
    }

    public class Car
    {
        private readonly Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void Start() => _engine.Start();
    }
}
