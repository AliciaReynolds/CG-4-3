using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random winner = new Random();

            Console.WriteLine("Please enter a name.");
            string[] Names = Console.ReadLine().Split(' ');
            {
                for (int name = 0; name < 31; name++)
                {

                    array[Name] = double.Parse(Names);

                if (string.IsNullOrEmpty(Name))
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
