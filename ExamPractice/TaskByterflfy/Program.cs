using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskByterflfy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char specialChar = '*';
            
            
            //upper part
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 1)
                {
                    specialChar = '-';
                }

                Console.WriteLine(new string(specialChar, n - 2) 
                    + "\\ /" + new string(specialChar, n - 2));

                specialChar = '*';
            }
            Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    specialChar = '*';
                }

                Console.WriteLine(new string(specialChar, n - 2)
                    + "/ \\" + new string(specialChar, n - 2));

                specialChar = '-';
            }

        }
    }
}
