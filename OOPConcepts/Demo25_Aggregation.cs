namespace OOPConcepts;

internal static class Demo25_Aggregation
{
    public static void RunDemo()
    {
        var department = new Department("HR");
        var employee = new Employee("Jane Doe", department);
        Console.WriteLine(employee.GetInfo());
    }

    public class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public Department Department { get; set; }

        public Employee(string name, Department department)
        {
            Name = name;
            Department = department;
        }

        public string GetInfo() => $"Name: {Name}, Department: {Department.Name}";
    }
}
