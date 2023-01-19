using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForLessons
{
    class Program
    {
        static void Main(string[] args)
        {

            fibonacciNumbers();
            Console.ReadLine();

        }
        static void fibonacciNumbers()
        {
            Console.Write("enter the number of fibonacci numbers: ");
            int numberOfFibonacciNumbers = int.Parse(Console.ReadLine());
            int[] numbersFibonacciMassive = new int[numberOfFibonacciNumbers + 2];

            numbersFibonacciMassive[0] = 1;
            numbersFibonacciMassive[1] = 1;

            for (int i = 2; i < numberOfFibonacciNumbers + 2; i++)
            {
                numbersFibonacciMassive[i] = numbersFibonacciMassive[i - 1] + numbersFibonacciMassive[i - 2];
                Console.Write($" {numbersFibonacciMassive[i]}");
            }
        }
    }
}
