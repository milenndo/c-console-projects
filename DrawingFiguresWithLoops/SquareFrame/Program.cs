using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            #region first Line

            Console.Write("+ ");

            for (int i = 0; i < n - 2 ; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            #endregion




            #region midle lines

            for (int counter = 0; counter < n - 2; counter++)
            {

            
                Console.Write("| ");

                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }
            #endregion








            #region last Line

            Console.Write("+ ");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            #endregion last Line
        }
    }
}