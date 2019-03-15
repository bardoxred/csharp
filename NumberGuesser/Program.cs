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
            title("Wesolowski Konrad", "First Version");
            
            Console.WriteLine("This program give you random number between 1-10");
            Random random = new Random();
            int winNumber = random.Next(1, 10);
            Console.WriteLine("This is your random number: "+winNumber);

            //-----------------------------------------------------------------------------

            Console.WriteLine("Can u write your name? ");
            string name = Console.ReadLine();
            bool isThatTrue = true;
            do
            {
                Console.WriteLine("Hello {0}, let's play a game!",name);
                Console.WriteLine("You have to guess computer number from 1 to 10");
                Console.WriteLine("Please, enter your quess");
            
                int randomNumber = random.Next(1, 10);
                int num = 0;
                int guessCount = 0;
           
                try
                {


                    while (num != randomNumber)
                    {

                        int numGuess = Convert.ToInt32(Console.ReadLine());


                        if (numGuess != randomNumber)
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You are wrong");
                            Console.ResetColor();

                        }
                        //else if ()
                        //{

                        //}
                        else
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You guessed!!!");
                            Console.ResetColor();
                            break;
                        }
                    }
                }
                catch (Exception mess)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(mess.Message);
                    Console.ResetColor();
                   
                }
                //---------------------------------------------------------------------------
                bool i = true;

                do
                {


                    Console.WriteLine("You want to play again [Y] or [N]");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "Y")
                    {
                        i = false;
                        Console.Clear();
                        continue;
                        
                    }

                    else if (playAgain.ToUpper() == "N")
                    {
                        i = false;
                        isThatTrue = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Thanks for playing! Cya! :D");
                        Console.ResetColor();
                        Console.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wrote wrong letter!!!");
                        Console.ResetColor();
                        Console.Clear();
                    }
                }
                while (i == true);
                //------------------------------------------------------------------------------------


            }

            while (isThatTrue == true);
            Console.ReadLine();
        }
        static void title(string author, string version)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This game is written by: " + author + "\nVersion: " + version);
            Console.ResetColor();
        }
    }
}
