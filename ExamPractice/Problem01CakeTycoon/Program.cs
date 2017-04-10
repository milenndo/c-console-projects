using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycooon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cakesPerDay = ulong.Parse(Console.ReadLine());
            double flourPerCake = double.Parse(Console.ReadLine());
            uint flourKgA = uint.Parse(Console.ReadLine());
            ulong truffle = ulong.Parse(Console.ReadLine());
            uint pricePerTruffle = uint.Parse(Console.ReadLine());


            double cakes = flourKgA / flourPerCake;
            ulong truffleTotal = truffle * pricePerTruffle;
            decimal cakePrice = truffleTotal / cakesPerDay * 1.25m;

            double flourRequired = cakesPerDay * flourPerCake;
            double kiloNeeded = flourRequired - flourKgA;

            if (cakes >= cakesPerDay)
            {
                Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
            }
            else
            {
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", Math.Floor(cakes), kiloNeeded);
            }
        }
    }
}