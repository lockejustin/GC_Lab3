using System;

namespace GC_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepPlaying = "";
            bool continueGame = true;
            
            Console.Write("Hello and welcome!  Please enter your name? "); //prompts for user name
            string name = Console.ReadLine();
            Console.WriteLine("Thank you " + name + ".");

            while (continueGame == true)  //runs the game as long as the user wants to continue
            {
                
                Console.Write("Please enter an integer between 1 and 100: ");
                int num = int.Parse(Console.ReadLine());
                
                while (num <= 1 || num >= 100) //validation for correct integer entry but breaks if alpha characters are entered
                {
                    Console.Write(name + ", your number is invalid.  Please enter an integer between 1 and 100: ");
                    num = int.Parse(Console.ReadLine());
                }


                if (num % 2 != 0 && num > 60)
                {
                    Console.WriteLine(num + " is odd and greater than 60.");
                }
                else if (num % 2 != 0 && num <= 60)
                {
                    Console.WriteLine(num + " is odd and less than or equal to 60.");
                }
                else if (num % 2 == 0 && num >= 2 && num <= 25)
                {
                    Console.WriteLine(num + " is even and less than or equal to 25.");
                }
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine(num + " is even and greater than or equal to 26 and and less than or equal to 60.");
                }
                else if (num % 2 == 0 && num > 60)
                {
                    Console.WriteLine(num + " is even and greater than 60.");
                }

                Console.Write("Would you like to play again? (y/n) "); //prompts user if they'd like to play again
                keepPlaying = Console.ReadLine();

                while (keepPlaying != "y" && keepPlaying != "n") //entry validation for continue prompt
                {
                    Console.Write("Your entry was invalid.  Please enter (y/n) ");
                    keepPlaying = Console.ReadLine();
                }
                
                if (keepPlaying == "y") //sets boolean value to continue the while loop to continue playing
                {
                    continueGame = true;
                }
                else
                {
                    continueGame = false;
                }
            }
            Console.WriteLine("Thanks for playing " + name + "!  Goodbye!");  //goodbye message that only runs after user wants to quit
        }
    }
}
