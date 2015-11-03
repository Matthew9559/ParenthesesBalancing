using System;

namespace Balancing
{
    class Program
    {
        static void Main(string[] args)
        {
            const char openParand = ('(');
            const char closeParand = (')');

            var inputString = "(if (any? x) sum (/1 x))";
            var counter = 0;

            foreach (var letter in inputString)
            {
                if (letter.Equals(openParand))
                {
                    counter++;
                }
                if (letter.Equals(closeParand))
                {
                    counter--;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
        }
    }
}
