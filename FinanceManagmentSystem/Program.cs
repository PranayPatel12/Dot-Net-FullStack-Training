// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    public static void Main()
    {
        int ch;
        int balance = 30000;
        do
        {
            Console.WriteLine("\nMENU : \n");
            Console.WriteLine("1. Debit Operations.");
            Console.WriteLine("2. Credit Operations.");
            Console.WriteLine("3. Exit.");
            Console.Write("\nEnter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            ch = choice;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nCredit Menu : ");
                    Console.WriteLine("1.Calculate Net Salary.");
                    Console.WriteLine("2.Calculate fixed deposit interest.");
                    Console.WriteLine("3.Evaluate Credit Card Reward points.");
                    Console.WriteLine("4.Check Employee Bonus Eligibility.");
                    
                    Console.Write("\nEnter your choice : ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1)
                    {
                        Credit.net_salary();
                    }
                    else if (c == 2)
                    {
                        Credit.fixed_deposit_interest();
                    }
                    else if (c == 3)
                    {
                        Credit.reward_points();
                    }
                    else if(c == 4)
                    {
                        Credit.bonus_eligibility();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice.Exiting...");
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("Debit Menu : ");
                    Console.WriteLine("1.Limit Validation of ATM Withdrawal.");
                    Console.WriteLine("2.Evaluate EMI burden.");
                    Console.WriteLine("3.Calculate daily spending based on transactions.");
                    Console.WriteLine("4.Check minimum balance compliance.");
                    Console.Write("Enter your choice : ");
                    int cho = Convert.ToInt32(Console.ReadLine());
                    if (cho == 1)
                    {
                        Debit.withdraw();
                    }
                    else if (cho == 2)
                    {
                        Debit.determine_emi_management();
                    }
                    else if (cho == 3)
                    {
                        Debit.daily_spending_calc();
                    }
                    else if (cho == 4)
                    {
                        Debit.min_balance(balance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice. Exiting...");
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid Choice. Exiting...");
                    return;
            }

        }while(ch != 3);
    }
}
