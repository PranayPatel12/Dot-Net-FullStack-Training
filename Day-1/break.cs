class Break
{
    public static void break_statement()
    {
        for(int i=1; i<=10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine($"i == 5. Breaking !!!");
                break;
            }
            Console.WriteLine($"i = {i}");
        }
    }
}