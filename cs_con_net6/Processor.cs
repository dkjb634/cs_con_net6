namespace cs_con_net6;

public class Processor
{
    public static void CoreFuntionality()
    {
        Console.WriteLine("Welcome to our program. Would you like to be said welcome again? 1 - Yes, 2 - No");
        int userRez = Convert.ToInt32(Console.ReadLine());
        if (userRez == 1)
        {
            CoreFuntionality();
        }

        string bye = "GoodBye";
        HelperFunction(bye);
    }

    public static void HelperFunction(string handler)
    {
        Console.WriteLine("Helper function: "+ handler);
    }
}