class FinanceControlSystem
{
    public static void finance_control_system()
    {
        int ch;
        int transactions_cnt = 0;
        do
        {
            Console.WriteLine("Main Menu Loop");
            Console.WriteLine("1. Check Loan Eligibility.");
            Console.WriteLine("2. Calculate Tax.");
            Console.WriteLine("3. Enter Transactions");
            Console.WriteLine("4. Exit.");
            Console.Write("\n\nPlease enter your choice here : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            ch=choice;

            if (transactions_cnt >= 5 && choice == 3)
            {
                Console.WriteLine("\n\nTransactions limit exceeded. Exiting....");
                // transactions_cnt=0;
                // ch=4;
                return;
            }

            switch(choice){
                case 1:
                    Console.WriteLine("Thanks for the choice.\n\n");
                    Console.Write("Enter your age : ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your monthly income in rs : ");
                    int income = Convert.ToInt32(Console.ReadLine());
                    if (age >= 21 && income>=30000)
                    {
                        Console.WriteLine("\n\nYou are eligible for the loan.\n\n");
                    }
                    else if(age<21 && income>=30000)
                    {
                        Console.WriteLine("Sorry, the age must be greater than 20 to be eligible to loan.");
                    }
                    else if (income < 30000 && age>=21)
                    {
                        Console.WriteLine("Sorry, the monthly income ust be greater than or equal to 30000 rs to be eligible for loan.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, the age must be greater than 20 and income must be greater than or equal to 30000 to be eligible to loan.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Thanks for the choice.\n\n");
                    Console.Write("Enter your annual income in rs: ");
                    double annual_income = Convert.ToDouble(Console.ReadLine());
                    if(annual_income <= 250000)
                    {
                        Console.WriteLine("\n\nTax Rate : 0%\n\n");
                    }
                    else if(annual_income>250000 && annual_income <= 500000)
                    {
                        Console.WriteLine("\n\nTax Rate : 5%\n\n");
                    }
                    else if(annual_income>500000 && annual_income <= 1000000)
                    {
                        Console.WriteLine("\n\nTax Rate : 20%\n\n");
                    }
                    else
                    {
                        Console.WriteLine("\n\nTax Rate : 30%\n\n");
                    }
                    break;
                case 3:
                    Console.WriteLine("Thanks for your choice");
                    Console.Write("Enter amount to make transaction (in rs): ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Amount cannot be empty");
                        break;
                    }
                    if(!int.TryParse(input, out int result))
                    {
                        Console.WriteLine("Invalid amount entered.");
                    }
                    else{
                        int amount = Convert.ToInt32(input);
                        if(amount < 0)
                        {
                            Console.WriteLine("Negative transactions are not allowed.");
                        }
                        else
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("TRANSACTION SUCCESSFULL");
                            Console.WriteLine("\n\n");
                            transactions_cnt++;
                        }
                    }
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid Choice.");
                    return;
            }

        }while(ch!=4);
    }
}