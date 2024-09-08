namespace DotNetNewFeatures
{
    internal static partial class Demo15_InitOnlyProperties
    {
        public class Client
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }

            public override string ToString() => $"{FirstName} {LastName}";
        }
    }
}
