using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal collectMoney = decimal.Parse(Console.ReadLine());
            decimal widthFloor  = decimal.Parse(Console.ReadLine());
            decimal ledgthFloor = decimal.Parse(Console.ReadLine());
            decimal SideTriangle = decimal.Parse(Console.ReadLine());
            decimal heigthTriangle = decimal.Parse(Console.ReadLine());
            decimal priceForOneTile = decimal.Parse(Console.ReadLine());
            decimal sumForHandyman = decimal.Parse(Console.ReadLine());

            decimal areafloor = widthFloor * ledgthFloor;
            decimal areaTile = SideTriangle * heigthTriangle / 2;
            decimal neededTiles = Math.Ceiling(areafloor / areaTile) + 5;
            decimal totalSum = (neededTiles * priceForOneTile) + sumForHandyman;

            decimal moneyLeft = collectMoney - totalSum;
            decimal moneyNeedMore = totalSum - collectMoney ;


            

           if (totalSum <= collectMoney)
           {
               
               Console.WriteLine("{0:F2} lv left.", moneyLeft);
           
           }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.", moneyNeedMore);
            }
            

               
            





        }
    }
}
