namespace cs_con_net6;

public class Processor
{
    public static void CoreFuntionality()
    {
        Console.WriteLine("Helloqq to our program. Would you like to be said welcome again? 1 - Yes, 2 - No");
        int userRez = Convert.ToInt32(Console.ReadLine());
        if (userRez == 1)
        {
            qwe.NewMethod(out var arr, out var userRez, out var bye);
        }

        string bye = "GoodBye";
        HelperFunction(bye);
    }

        public static void HelperFunction(string handler)
        {
            Console.WriteLine("Helper function: "+ handler);//
            
        }

        public async Task<int> ExampleMethodAsync()
        {
            //...
            return 0;
        }
        //C#
    
        int foo(int a, int b, int c, int e, int r, int t, int y)
        {
            return a + b + c + e + r + t + y;
        }
    }
}