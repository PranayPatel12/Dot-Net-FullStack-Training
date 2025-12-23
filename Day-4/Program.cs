// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
class Program
{
    public static void Main()
    {
        // Parent class object
        Parent parentobj1 = new Parent(22, "Pranay");
        parentobj1.display();
        Console.WriteLine("Int with get data method : "+parentobj1.getIntData());

        // Child class Object
        Child childObj1 = new Child(16, true, 21, "Pranay Javvaji");
        childObj1.display();
        Console.WriteLine($"Get method1 : {childObj1.getData1()}");
        Console.WriteLine($"Get method2 : {childObj1.getData2()}");
    }
}
