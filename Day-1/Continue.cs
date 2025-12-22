class Continue
{
    public static void continue_statement()
    {
        for(int i=1; i<=10; i++)
        {
            if(i == 4)
            {
                Console.WriteLine($"e{i} is invisible. Skipping e{i}");
                continue;
            }
            Console.WriteLine($"Player killed e{i}");
        }
    }
}