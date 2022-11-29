namespace cs_con_net6
{
    public class Processor
    {
        #region MyRegion

    

        #endregion

        public static void CoreFuntionality()
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine("Helloqq to our program. Would you like to be said welcome again? 1 - Yes, 2 - No");
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
            Console.WriteLine("Helper function: "+ handler);//
        }

        //C#
    
        int foo(int a, int b, int c, int e, int r, int t, int y)
        {
            return a + b + c + e + r + t + y;
        }
    }
}   