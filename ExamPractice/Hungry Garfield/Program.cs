using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalMoney = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal spentForPizza = (pizzaPrice * pizzaQuantity) / rate;
            decimal spentForLasagna = (lasagnaPrice * lasagnaQuantity) / rate; ;
            decimal spentForSandwich = (sandwichPrice * sandwichQuantity) / rate ;

            decimal totalNeeded = spentForPizza + spentForLasagna + spentForSandwich;

            if (totalMoney - totalNeeded >= 0)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", totalMoney - totalNeeded);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", Math.Abs(totalMoney - totalNeeded));

            }
        }
    }
}
