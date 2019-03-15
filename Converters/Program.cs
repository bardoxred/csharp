using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Przeliczniki
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string choose;
            do
            {
                Console.WriteLine("Choose program you want to turn on");
                Console.WriteLine("1. Conversion Celsius degrees to Fahrenheit degrees");
                Console.WriteLine("2. Conversion Fahrenheit degrees to Celsius degrees");
                Console.WriteLine("3. Speed conversion from m/s to km/h");
                Console.WriteLine("4. Speed conversion from km/h to m/s");

                Console.WriteLine("Press R to restart");
                Console.WriteLine("Press E to exit");
                
                choose = Console.ReadLine();
                

                if (choose.ToLower() == "e")
                {
                    Console.WriteLine("You choose: " + choose);
                    Console.WriteLine("Press enter to exit");
                    break;
                }
                Console.WriteLine("You choose: " + choose);
                switch (choose)
                {
                    case "1":
                        Console.WriteLine("This is Converter from Celsius to Fahrenheit");
                        Console.WriteLine("Enter a number of Celsius degrees: ");
                        double num1;
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You have enter that much Celsius degrees: "+num1);
                        double num2 = (32 + (1.8 * num1));
                        Console.WriteLine("Number of Fahrenheit: " + num2+" degrees");
                        Thread.Sleep(3000);
                        
                        break;

                    case "2":
                        Console.WriteLine("This is Converter from Fahrenheit to Celsius");
                        Console.WriteLine("Enter a number of Fahrenheit degrees: ");
                        double a;
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You have enter that much Fahrenheit degrees: " + a);
                        double b = ((a-32)/1.8);
                        Console.WriteLine("Number of Fahrenheit: " + b+" degrees");
                        Thread.Sleep(3000);

                        break;

                    case "3":
                        Console.WriteLine("This is Converter from km/h to m/s");
                        Console.WriteLine("Enter a number of km: ");
                        double c;
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You have enter that much km: " + c);
                        double d = (c/3.6);
                        Console.WriteLine("Number of m/s: " + d+"m/s");
                        Thread.Sleep(3000);

                        break;

                    case "4":
                        Console.WriteLine("This is Converter from m/s to km/h");
                        Console.WriteLine("Enter a number of meters: ");
                        double num3;
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You have enter that much meters: " + num3);
                        double num4 = (num3 * 3.6);
                        Console.WriteLine("Number of km/h: " + num4+"km/h");
                        Thread.Sleep(3000);

                        break;

                    case "R":
                        Console.WriteLine("Restarting..." );
                        
                        break;

                    default:
                        Console.WriteLine("This number doesn't excist or you wrote word");
                        break;

                }

                
                Console.WriteLine("Restarting...");
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine(i + "...");
                    Thread.Sleep(1000);
                    
                }
                Console.Clear();
            }


            while (choose == choose.ToLower()|| choose == choose.ToUpper());
            Console.Clear();
            Console.ReadLine();

        }
    }
}