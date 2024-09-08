namespace OOPConcepts;

internal static class Demo26_Association
{
    public static void RunDemo()
    {
        var teacher = new Teacher("Mr. Smith");
        var student = new Student("Jane Doe");
        teacher.Teach(student);
    }

    public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public void Teach(Student student) => Console.WriteLine($"{Name} is teaching {student.Name}");
    }

    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }
}
