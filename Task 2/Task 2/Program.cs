namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            var num = 84;


            if(85 > num && num > 65)
            {
                Console.WriteLine("You will get Certificate");
            }
            else if(95 > num && num > 85)
            { 
                Console.WriteLine("You will get Honour Certificate");
            }
            else if (num > 95)
            {
                Console.WriteLine("Congratulations you will get High Honour Certificate");
            }
            else
            {
                Console.WriteLine("You Fail"); 
            }


            int num1 = 86;

            if(num1 > 95)
            {
                Console.WriteLine("Congratulations you will get High Honour Certificate");
            }
            else if(95 > num1 && num1 > 85) 
            {
                Console.WriteLine("You will get Honour Certificate");
            }
            else if(85 > num1 && num1 > 65)
            {
                Console.WriteLine("You will get Certificate");
            }
            else
            {
                Console.WriteLine("You Fail");
            }
             #endregion
        }
          
    }
}
