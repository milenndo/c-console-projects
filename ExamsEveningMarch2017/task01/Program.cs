using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareArea = double.Parse(Console.ReadLine());
            double kilosGreepePerSquare = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double AllGrape = squareArea * kilosGreepePerSquare - brak;
            double grapeRakia = AllGrape * 0.45 / 7.5;
            //Console.WriteLine(rakia);

            double profitRakia = (double)grapeRakia * 9.8m;
            //Console.WriteLine(profitRakia);


            double sellGrape = AllGrape * 0.55;
            double profitSellGrape = (double)sellGrape * 1.5m;

            Console.WriteLine("{0:f2}", profitRakia );
            Console.WriteLine("{0:f2}", profitSellGrape);


        }
    } 
}
