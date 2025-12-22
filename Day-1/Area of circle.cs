// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class Aoc
{
    public static void area_of_circle()
    {
        // Console.WriteLine("Welcome to C# Console Application");
        Console.WriteLine("Enter r : ");

        double r = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * r * r;

        Console.WriteLine("Area of circle = " + area);
    }
}