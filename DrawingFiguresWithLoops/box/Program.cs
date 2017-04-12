using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // First Line

            Console.Write("+ ");

            for (int i = 0; i < n-2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            // Middle Line
            for (int col = 0; col < n - 2; col++)
            {
                Console.Write("| ");

                for (int row = 0; row < n - 2; row++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
                // Last Line



            }
            Console.Write("+ ");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
