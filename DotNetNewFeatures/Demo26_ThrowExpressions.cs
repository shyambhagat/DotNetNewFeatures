namespace DotNetNewFeatures;

internal static class Demo26_ThrowExpressions
{
    public static void RunDemo()
    {
        var person = new Person(null, 28);
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
        }
    }
}
