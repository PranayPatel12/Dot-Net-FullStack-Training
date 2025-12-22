class Credit
{
    public static void net_salary()
    {
        Console.Write("Enter your total salary : ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Net salary credited: ₹{salary-(10*salary/100)}");
    }

    public static void fixed_deposit_interest()
    {
        Console.Write("Enter principal amount : ");
        int principal = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter rate of interest : ");
        int rate_of_interest = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter time : ");
        int time  = Convert.ToInt32(Console.ReadLine());
        int simple_interest = (principal*rate_of_interest*(time/12))/100;
        Console.WriteLine($"Fixed Deposit maturity amount: ₹{simple_interest+principal}");
    }
    public static void reward_points()
    {
        Console.Write("Enter total credit card spending : ");
        int credit_card_spending = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Reward points earned: {credit_card_spending/100}");
    }   

    public static void bonus_eligibility()
    {
        Console.Write("Enter your Annual salary : ");
        int annual_salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your years of service : ");
        int years_of_service = Convert.ToInt32(Console.ReadLine());
        if(annual_salary>=50000 && years_of_service>=3)
        {
            Console.WriteLine("You are eligible for bonus.");
        }
        else
        {
            Console.WriteLine("Sorry, You are not eligible for bonus.");
        }
    }
}