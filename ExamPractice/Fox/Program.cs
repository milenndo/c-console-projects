using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // Upper part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', i + 1) + "\\");
                Console.Write(new string('-', 2 * n - 1 - 2 * i) + "/");
                Console.WriteLine(new string('*', i + 1));
            }

            //Midlle part
            for (int i = 0; i < n / 3; i++)
            {

                Console.Write("|" + new string('*', n / 2 + i) + "\\");
                Console.Write(new string('*', n - 2 * i) + "/");
                Console.WriteLine(new string('*', n / 2 + i) + "|");
            }

            //Low part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', i + 1) + "\\");
                Console.Write(new string('*', 2 * n - 1 - 2 * i) + "/");
                Console.WriteLine(new string('-', i + 1));
            }
        }
    }
}
