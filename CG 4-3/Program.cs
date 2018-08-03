using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random winner = new Random();

            //string[] array = new string[30];
            Console.WriteLine("Please enter a name.");
            string[] Names = new string[30];
            {
                for (int name = 0; name < 31; name++)
                {

                    Names[] = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    { 
                    break;
                }

                int mIndex = winner.Next(name.Length);
                Console.WriteLine("The winner of the raffle is {0}!!");


            }


            Console.ReadLine();
        }
    }
}
