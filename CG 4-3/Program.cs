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
            string[] name = new string[int.Parse(answer)];

            {
                for (int names = 0; names < 31; names++)
                {
                    int names = int.Parse(name);

                if (string.IsNullOrEmpty(names))
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
