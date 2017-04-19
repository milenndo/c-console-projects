using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {

            double lengthA = double.Parse(Console.ReadLine());
            double heightB = double.Parse(Console.ReadLine());

            double twoSides = lengthA * (lengthA / 2) * 2;
            double backWallKv = (lengthA / 2) * (lengthA / 2);
            double backWallTr = (lengthA / 2 * (heightB - lengthA / 2)) / 2;
            double backWall = backWallKv + backWallTr;
            double enter = (lengthA / 5) * (lengthA / 5);
            double frontWall = backWall - enter;
            double areaWalls = twoSides + backWall + frontWall;
            double greenPaint = areaWalls / 3;
            double areaRoof = lengthA * (lengthA / 2) * 2;
            double redPaint = areaRoof / 5;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
