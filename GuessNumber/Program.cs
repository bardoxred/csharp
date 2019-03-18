using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess number beetwen 1-100; ");
            int a;
            
           

            Random number = new Random();
            bool isTrue = true;
            int result = number.Next(0, 101);
            do
            {
                

                Console.WriteLine("Enter your quess");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < result)
                    {

                        Console.WriteLine("Number is greater.");


                    }
                    else if (a == result)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed. Congratulation!\nComputer rolled:" + result);
                        Console.ResetColor();
                        isTrue = false;
                    }
                    else if (a > result)
                    {
                        Console.WriteLine("Number is lower.");


                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("It's not a number! Try again!");
                    Console.ResetColor();
                }
                
               
            }
            while (isTrue == true);



            Console.ReadLine();
        }
    }
}
