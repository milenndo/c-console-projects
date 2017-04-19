using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameMoves = int.Parse(Console.ReadLine());
            

            
            double range09 = 0;
            double range1019 = 0;
            double range2029 = 0;
            double range3039 = 0;
            double range4050 = 0;
             
            double invalidN = 0;

            double result = 0.0;






            for (double i = 1; i <= gameMoves; i++)
            {
                int  current = int.Parse(Console.ReadLine());


                if (current >= 0 && current <= 9)
                {
                   result += 0.2 * current;
                   range09++;


                }

                else if (current >= 10 && current <= 19)
                {
                    result += 0.3 * current;
                    range1019++;


                }

                else if (current >= 20 && current <= 29)
                {
                    result += 0.4 * current ;
                    range2029++;


                }
                else if (current >= 30 && current <= 39)
                {
                    result +=  50;
                    range3039++;
                   
                }




                else if (current >= 40 && current <= 50)
                {

                   result += 100;
                   range4050++;
                   
                    
                }
                
                else
                {
                    result /= 2;
                    invalidN++;
                }
                
            }

            Console.WriteLine("{0:F2}", result);
            Console.WriteLine("From 0 to 9: {0:F2}%", (range09 / gameMoves ) * 100);
            Console.WriteLine("From 10 to 19: {0:F2}%", (range1019 / gameMoves) * 100);
            Console.WriteLine("From 20 to 29: {0:F2}%", (range2029 / gameMoves) * 100);
            Console.WriteLine("From 30 to 39: {0:F2}%", (range3039 / gameMoves) * 100);
            Console.WriteLine("From 40 to 50: {0:F2}%", (range4050 / gameMoves) * 100);
            Console.WriteLine("Invalid numbers: {0:F2}%", (invalidN / gameMoves) * 100);
        }
    }
}




