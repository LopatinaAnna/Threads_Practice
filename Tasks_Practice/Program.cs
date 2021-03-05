using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasks_Practice
{
    class Program
    {
        static List<int> numbers = new List<int>();
        static int printedCount = 0;

        static void Main(string[] args)
        {
            Task.Run(WriteNumbers);
            Task.Run(PrintNumbers);

            Console.ReadLine();
        }

        static void WriteNumbers()
        {
            for (int i = 2; numbers.Count < 15; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }
        }

        static void PrintNumbers()
        {
            while (printedCount < 15)
            {
                if (numbers.Count % 5 == 0)
                {
                    Console.WriteLine("Print");
                    for (int i = printedCount; i < printedCount + 5; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                    printedCount += 5;
                }
            }
            Console.WriteLine("Finish");
        }

        static bool IsPrime(int n)
        {
            if (n > 1)
            {
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
