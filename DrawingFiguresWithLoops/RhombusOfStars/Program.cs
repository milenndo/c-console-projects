using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {



            //            *
            //           * *
            //          * * *
            //         * * * *
            //          * * *
            //           * *
            //            *

            var n = int.Parse(Console.ReadLine());

            // first line

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }



            }
        }
    }
}
