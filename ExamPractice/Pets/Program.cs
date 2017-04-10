using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kilosFood = int.Parse(Console.ReadLine());
            double foodPerDayDog = double.Parse(Console.ReadLine());
            double foodPerCat = double.Parse(Console.ReadLine());
            double foodPerTurtle = double.Parse(Console.ReadLine());

        double totalFoodNeeded = (foodPerCat + foodPerDayDog + foodPerTurtle / 1000) * days;

            double diff = kilosFood - totalFoodNeeded;

            if (diff >= 0)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(diff));
            }
            else
            {

                diff = Math.Abs(diff);
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(diff));
            }
        }


        
    }
}
