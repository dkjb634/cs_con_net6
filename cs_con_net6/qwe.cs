using cs_con_net6;

static internal class qwe
{
    public static void NewMethod(out int[] arr, out int userRez, out string bye)
    {
        arr = new[] { 1, 2, 3 };
        Console.WriteLine("Helloqq to our program. Would you like to be said welcome again? 1 - Yes, 2 - No");
        userRez = Convert.ToInt32(Console.ReadLine());
        if (userRez == 1)
        {
            Processor.CoreFuntionality();
        }

        bye = "GoodBye";
        Processor.HelperFunction(bye);
    }
}