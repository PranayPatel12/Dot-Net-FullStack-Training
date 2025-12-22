class Debit
{
    private static int dailyLimit = 40000;
    public static void withdraw()
    {
        Console.Write("Enter the amount : ");
        int amount = Convert.ToInt32(Console.ReadLine());
        if(amount > dailyLimit)
        {
            Console.WriteLine("\nDaily ATM withdrawal limit exceeded.\n");
            return;
        }
        Console.WriteLine("\nWithdrawal permitted within daily limit.\n");
    }

    public static void determine_emi_management()
    {
        Console.Write("Enter your salary : ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter EMI : ");
        int emi = Convert.ToInt32(Console.ReadLine());
        if(emi <= 0.4 * salary)
        {
            Console.WriteLine("EMI is financially manageable");
        }
        else
        {
            Console.WriteLine("EMI exceeds safe income limit");
        }
    }

    public static void daily_spending_calc()
    {
        Console.Write("Enter the number of transactions per day : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int total_debit = 0;
        for(int i=1; i<=number; i++)
        {
            Console.Write("Enter transaction amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            total_debit += amount;
        }

        Console.WriteLine($"Total debit amount for the day: ₹{total_debit}");
    }

    public static void min_balance(int balance)
    {
        if (balance >= 2000)
        {
            Console.WriteLine("Minimum balance requirement satisfied.");
        }
        else
        {
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        }
    }
}