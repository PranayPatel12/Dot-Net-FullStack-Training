using System;

class Student
{
    private string name;
    private int age;
    private int marks;

    public void setName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }
        this.name = name;
    }
    public string getName()
    {
        return name;
    }
    public void setAge(int age)
    {
        if (age < 0)
        {
            Console.WriteLine("Age cannot be negative.");
            return;
        }
        this.age = age;
    }

    public int getAge()
    {
        return age;
    }

    public void setMarks(int marks)
    {
        if(marks<0 || marks > 100)
        {
            Console.WriteLine("Marks should be between 0 and 100.");
            return;
        }
        this.marks = marks;
    }

    public int getMarks()
    {
        return marks;
    }
}