using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamand
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int startStars = 2 - n % 2;
            int topRows = (n + 1) / 2;
            int lowRows = n - topRows;

            //Top row
            int startDashes = (n - startStars) / 2;
            Console.Write(new string('-', startDashes));
            Console.Write(new string('*', startStars));
            Console.WriteLine(new string('-', startDashes));

            //Top other rows

            for (int i = 0; i < topRows - 1; i++)
            { 
                int insideDashes =startStars + i * 2;
                int outerDashes = (n - 2 - insideDashes) / 2;
                Console.Write(new string('-', outerDashes));
                Console.Write('*');
                Console.Write(new string('-', insideDashes));
                Console.Write('*');
                Console.Write(new string('-', outerDashes ));
                Console.WriteLine();
            }
            

            //low Rows
            for (int i = 0; i < lowRows; i++)
            {

            }

            Console.WriteLine();

        }
    }
}
