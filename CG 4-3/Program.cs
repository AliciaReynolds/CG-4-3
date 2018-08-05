using System;

namespace CG_4_3_help2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter up to 30 names

            Console.WriteLine("Please Enter up to 30 names.");

            //This defines the array and saves them

            string[] Name = new string[30];

            //This is used to so that we can pull the array tackle box out of the curly brackets to use outside of the loop
            var nameEntered = 0;

            for (int Entered = 0; Entered < 30; Entered++)
            {
                //This allows us to enter names into the array. 'Name' is the variable name of the for the tackle box sections within the array, 'Entered' is the name space.

                Name[Entered] = Console.ReadLine();

                //this says that when the user hits enter, that would be considered a blank space -- not a null
                if (Name[Entered] == " ")
                {
                    break;
                }

                //This makes the variable mentioned above and defining it within the loop to be all the array tacklebox info that the user entered
                nameEntered = Entered;

            }
            //This is the code allows to start the random compiler

            var randomizer = new Random();

            //This defines the variable of the randomizer and defines the perameters of the randomizer to be 0 (which is 1 in code) to the end of the array (the variable defined that we pulled out
            var winner = randomizer.Next(0, nameEntered);


            Console.WriteLine($"The Winner is {Name[winner]}!!!");

            //This is for the the list of the names that didn't win.  This is a loop.  You need to run the loop to pull the names out.  This allows to do that.
            //what this means 'foreach (var type [name of variable] is {array name})
            foreach (string Everyone in Name)
            {
                //this is an if statement so that if the loop ever hits an 'enter' space, if the user didn't enter all 30 names, then it will break out of the loop to print out the list of names
                if (Everyone == " ") break;

                /*this is an if statement so that whomever the randomizer picked out as the winner, will not be picked for the 'loser list' but will continue the loop so that way all the names after
                the winner's name will still be included into the 'list of losers'*/

                if (Name[winner] == Everyone) continue;

                /*This statement will then print out the list of everyone that had entered the raffle but lost*/

                Console.WriteLine($"{Everyone} has lost.");
            }

            /*This is a way to do the loop above instead of the 'for(int i = 0; i < length; i++)' code
            'for' looping is better to use when  you have defined size for your loop
            'foreach' looping is better when you don't know the size of your loop
            int i = 0;
            foreach (string entered in Name)
            {
               Name[i] = Console.ReadLine();
               if (Name[i] == " ") break;
               if (i>= 30) break;
               i++;
           }*/


            Console.ReadLine();

        }
    }
}
