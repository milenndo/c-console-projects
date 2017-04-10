using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
            //WALL GREEN PAINT
            double sideWall = x * y;
            double windowWalls = 1.5 * 1.5;
            double doubleWalls = 2 * sideWall - 2 * windowWalls;
            double backWall = x * x;
            double entry = 1.2 * 2;
            double allBackAndEntry = 2 * backWall - entry;
            double areaWall = doubleWalls + allBackAndEntry;
            double greenPaint = areaWall * 1 / 3.4;
            Console.WriteLine($"{greenPaint:f2}");
            // ROOF RED PAINT

            double twoRegtangles = 2 * (x * y);
            double twoTriangles = 2 * (x * h / 2);
            double areaTri = twoRegtangles + twoTriangles;
            double redPaint = areaTri  / 4.3;
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
