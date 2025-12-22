class SecToMin
{
    public static void seconds_to_min()
    {
        Console.Write("Enter seconds : ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        int min = seconds/60;

        Console.WriteLine($"Seconds to Minutes : {min}min");
    }
}