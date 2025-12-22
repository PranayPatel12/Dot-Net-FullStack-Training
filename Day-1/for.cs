class For
{
    public static void for_loop()
    {
        // Console.WriteLine("Multiplication of 20 : ");
        // for(int i=1; i<=10; i++)
        // {
        //     Console.WriteLine($"20 X {i} = {i*20}");
        // }

        for(int i=20; i<=30; i++)
        {
            Console.WriteLine($"Multiplication of {i}");
            for(int j=1; j<=10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i*j}");
            }
        }

        

    }
}