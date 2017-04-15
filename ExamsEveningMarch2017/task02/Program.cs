using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double areaHouse = double.Parse(Console.ReadLine());
            double numWindows = double.Parse(Console.ReadLine());
            double squareMeterSteropor = double.Parse(Console.ReadLine());
            double priceSquareParet = double.Parse(Console.ReadLine());

            double pureHousseArea = (areaHouse - (numWindows * 2.4) );
            double pureHouseArea = pureHousseArea + pureHousseArea/10; // pure area plus 10%
            //Console.WriteLine(pureHouseArea);

            double neededPackS = Math.Ceiling(pureHouseArea / squareMeterSteropor);
            //Console.WriteLine(neededPackS);

            double AllSprice = (Math.Round( neededPackS * priceSquareParet, 2));
            //Console.WriteLine(AllSprice);

            if (budget >= AllSprice)
            {
                double leftMoney = budget - AllSprice;
                Console.WriteLine($"Spent: {AllSprice:f2}");
                Console.WriteLine($"Left: {leftMoney:f2}");
            }
            else 
            {
                double needMoney = AllSprice - budget;
                Console.WriteLine($"Need more: {needMoney:f2}");
            }
            



        }
    }
}
