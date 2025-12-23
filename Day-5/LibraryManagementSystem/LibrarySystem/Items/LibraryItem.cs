using System;

namespace LibrarySystem.Items
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ItemId { get; set; }

        public abstract void DisplayInfo();
        public abstract double CalculateLateFee(int daysLate);
    }
}