using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random winner = new Random();
            string[] Names = new string[30];
            {

                Console.WriteLine("Please enter a name.");
                var name = Console.ReadLine();

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
