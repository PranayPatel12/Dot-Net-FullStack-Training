using System;

namespace LibrarySystem.Items
{
    public class Magazine : LibraryItem
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Item Type: Magazine");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item Id: {ItemId}");
        }

        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 0.5;
        }
    }
}