using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1 ;
            int n;
            Console.WriteLine("Podaj ile chcesz wypisać wyrazów ciągu Fibonacciego");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wyrazy:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(b);
                b = b + a;
                a = b - a;
                
            }
            Console.ReadLine();
        }
    }
}
