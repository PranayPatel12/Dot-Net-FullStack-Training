using System;
using LibrarySystem.Interfaces;

namespace LibrarySystem.Items
{
    public class Book : LibraryItem, IReservable, INotifiable
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Item Type: Book");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemId}");
        }

        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 1.0;
        }

        void IReservable.Reserve()
        {
            Console.WriteLine("Book reserved successfully.");
        }

        void INotifiable.NotifyUser(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }
}