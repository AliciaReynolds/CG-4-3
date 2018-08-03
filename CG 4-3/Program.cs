using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random winner = new Random();

            //string[] array = new string[30];
            //Console.WriteLine("Please enter a name.");
            //string answer = Console.ReadLine();

            //string[] name = new string[(int.Parse(answer))];


            string[] name = new string[30];

            {
                //Console.WriteLine("Please enter a name.");
                //string answer = Console.ReadLine();

                for (int Names = 0; Names < 31; Names++)


                {
                    //This allows to have the question asked to enter the names
                    Console.WriteLine("Please enter a name.");
                    string answer = Console.ReadLine();

                   string entered = Convert.ToString(Names);


                    //if (names == null) break;

                
                if (string.IsNullOrEmpty(entered))
                {
                    break;
                }
                }

                //Random winner = new Random();
                //string Winner = answer[winner.Next(answer.Length)];
                //Console.WriteLine($"The winner of the raffle is {answer}!!");

                    //int mIndex = winner.Next(name.Length);
                    //Console.WriteLine($"The winner of the raffle is {mIndex}!!");


             }

            Console.ReadLine();
        }
    }
}
