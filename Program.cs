using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AppInfo();  // call method for app info


            Name(); // call method to ask user name

            // game logic
            while (true) { 

                //correct guess, using random number
                //int correctNumber = 2;

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // initial guess
                int guess = 0;

                Console.Write("Guess a number between 1 and 10: ");
            

                while (guess != correctNumber)
                {
                    // get user guess
                    string input = Console.ReadLine();

                    // error handling. 
                    if(!int.TryParse(input, out guess)){

                        MessageColor(ConsoleColor.Red, "Please enter a number."); // call method display message color

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        MessageColor(ConsoleColor.Red, "Wrong, try again..."); // call method display message color
                    }
                }

                MessageColor(ConsoleColor.Green, "CORRECT"); // call method display message color

                // ask user to play again
                Console.WriteLine("Do you want to play again? [Y / N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        // method that asks user name & greets
        static void Name()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            
            Console.WriteLine("{0}, Welcome! Let us play a guessing game...", name);
            Console.WriteLine();

        }

        // method that prints AppInfo
        static void AppInfo()
        {
            // variables
            string appName = "GUESS THE NUMBER!";
            string appVersion = "1.0.0";
            string appAuthor = "Neo Matlala";

            // heading color to green
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //reset console text color
            Console.ResetColor();
            Console.WriteLine();
        }

        // method prints color message
        static void MessageColor( ConsoleColor color, string message)
        {
            // heading color to yellow
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            //reset console text color
            Console.ResetColor();
        }
    }
}
