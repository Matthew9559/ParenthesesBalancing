using System;

namespace Balancing
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "(if (any? x) sum (/1 x))";

            var doParands = new ParandBalancer();

            var result = doParands.CheckParands(inputString);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
