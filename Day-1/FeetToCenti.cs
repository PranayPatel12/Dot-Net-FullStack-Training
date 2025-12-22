using System;
class FeetToCentimeter
{
    public static void convert_feet_to_centi()
    {

        Console.Write("Enter foot : ");
        double foot = Convert.ToDouble(Console.ReadLine());

        double centimeter = foot * 30.48;
        Console.WriteLine($"Converted value : {centimeter}");

    }
}