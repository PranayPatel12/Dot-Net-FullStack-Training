// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.setName("Alice");
        student.setAge(20);
        student.setMarks(91);

        Console.WriteLine("Student Name: " + student.getName());
        Console.WriteLine("Student Age: "+ student.getAge());
        Console.WriteLine("Student Marks: "+student.getMarks());
    }
}