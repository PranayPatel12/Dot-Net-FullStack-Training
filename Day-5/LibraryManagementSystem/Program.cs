// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using LibrarySystem.Items;
using ItemsAlias = LibrarySystem.Items;

class Program
{
    static void Main()
    {
        LibraryItem book = new ItemsAlias.Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemId = 101
        };

        LibraryItem magazine = new ItemsAlias.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemId = 201
        };

        List<LibraryItem> items = new List<LibraryItem>
        {
            book,
            magazine
        };

        foreach(var item in items)
        {
            item.DisplayInfo();
            Console.WriteLine($"Late Fee for 3 days: {item.CalculateLateFee(3)}");
            Console.WriteLine();
        }


    }
}