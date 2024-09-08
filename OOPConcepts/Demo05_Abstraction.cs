namespace OOPConcepts;

internal static class Demo05_Abstraction
{
    public static void RunDemo()
    {
        var rectangle = new Rectangle(5, 10);
        var circle = new Circle(7);

        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");
    }

    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
    }
}
