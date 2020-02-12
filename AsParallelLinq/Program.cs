using Separator;
using System;
using System.Linq;

namespace AsParallelLinq
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('-', 50);
            SeparateEvent separateEvent = new SeparateEvent();
            separateEvent.OnSeparate += consoleSeparator.Separator;
            int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8  };
            (from n in numbers.AsParallel()
             select Factorial(n)).ForAll(Console.WriteLine);
            separateEvent.Display();
            //foreach (var x in factorials)
            //{
            //    Console.WriteLine(x);
                
            //}
        }

        private static int Factorial(int n)
        {
            int result = 1;
            for (int i =1; i <=n; i++)
            {
                result *= i;
            }
            //Console.WriteLine($"result = {result}");
            
            return result;
        }
       
    }
}
