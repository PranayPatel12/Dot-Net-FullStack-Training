namespace LibrarySystem.Items
{
    public class eBook : LibraryItem
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Item Type : eBook");
            Console.WriteLine($"Title: {Title}");
        }

        public override double CalculateLateFee(int daysLate)
        {
            return 0;
        }

        public void Download()
        {
            Console.WriteLine("eBook downloaded successfully.");
        }
    }
}