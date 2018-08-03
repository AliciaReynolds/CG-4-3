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
            string answer = Console.ReadLine();
            string[] name = new string[30];

            {
                for (int names = 0; names < 31; names++)
                {
                    string Names = Convert.ToString(names);
                    //if (names == null) break;

                    if (string.IsNullOrEmpty(Names))
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
