class Parent
{
    int data1;
    string data2;
    public Parent(int data1, string data2)
    {
        this.data1 = data1;
        this.data2 = data2;
        Console.WriteLine($"Base class constructor with data members {data1} and {data2}");
    }

    public void display()
    {
        Console.WriteLine($"Data1: {data1}, Data2: {data2}");
    }

    public int getIntData()
    {
        return data1;
    }

    public string getStringData()
    {
        return data2;
    }
}

class Child : Parent
{
    int std;
    bool isEligible;
    public Child(int std, bool isEligible, int age, string name) : base(age, name) // base is a keyword used to call parent constructor.
    {
        this.std = std;
        this.isEligible = isEligible;

        Console.WriteLine($"Child class Constructor with arguments {std} and {isEligible}");
    }

    public void display()
    {
        Console.WriteLine($"Data1: {std} , Data2: {isEligible}");
    }

    public int getData1()
    {
        return std;
    }

    public bool getData2()
    {
        return isEligible;
    }
}

