namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            for (int i = 1; i <= 100; i++)
            { 
                if (i % 5 == 0 && i % 3 == 0) 
                {
                    Console.WriteLine($"{i} is divisible by both 3 and 5");
                }
                else
                {
                    Console.WriteLine($"{i} is not divisible by both 3 and 5");
                }
                #endregion

            }
        }
    }
}
