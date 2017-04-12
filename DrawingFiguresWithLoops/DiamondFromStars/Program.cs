using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFromStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // Works with odd numbers
            int stars = 1;
            int dashes = n / 2;
            int rows = n / 2 + 1;

            //Work with even numbers
            if (n % 2 == 0)
            {
                stars++;
                dashes--;
                rows--;
            }
            for (int i = 0; i < rows; i++)
            {
                Console.Write(new string('-', dashes - i));
                Console.Write(new string('*', stars + 2 * i));
                Console.WriteLine(new string('-', dashes - i));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("|" + new string('*', n-2) + "|");
            }
            
            
        }
    }
}
