namespace cs_con_net6;

public class Processor
{
    public static void CoreFuntionality()
    {
        Console.WriteLine("Enter 2 digits.");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        string rezult = "The sum of " + a + " and " + b + " is equal to " + (a + b);
        HelperFunction(rezult);
    }

    private static void HelperFunction(string handler)
    {
        Console.WriteLine("Helper function: "+ handler);
    }
}