using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int startEndDots = 2 * n - 1;

            Console.Write(new string('.', startEndDots));
            Console.Write(@"/|\");
            Console.WriteLine(new string('.', startEndDots));

            Console.Write(new string('.', startEndDots));
            Console.Write(@"\|/");
            Console.WriteLine(new string('.', startEndDots));


            for (int row = 0; row < 2*n; row++)
            {
                Console.WriteLine(
                    new string('.', startEndDots - row) +
                    "*" +
                    new string('-', row) +
                    "*" +
                    new string('-', row) +
                    "*" +
                    new string('.', startEndDots - row));

            }
            Console.WriteLine(new string ('*', 4 * n + 1 ));
            Console.Write("*");
            for (int i = 0; i < 2* n; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();



            Console.WriteLine(new string('*', 4 * n + 1));
        }

    }
}
