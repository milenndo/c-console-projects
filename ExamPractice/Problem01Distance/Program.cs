using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstSpeed= decimal .Parse(Console.ReadLine());
            decimal  firstTimeInMinute = decimal.Parse(Console.ReadLine());
            decimal  secondTimeInMinute = decimal.Parse(Console.ReadLine());
            decimal  thirdTimeInMinute = decimal.Parse(Console.ReadLine());

            decimal secondSpeed = firstSpeed + firstSpeed / 10;
            decimal thirdSpeed = secondSpeed - ((secondSpeed * 5) / 100);
            

            decimal distanceAfterStart = firstSpeed * firstTimeInMinute / 60;
            decimal distanceAfterSpeedUp = secondSpeed * secondTimeInMinute / 60;
            decimal distanceAfterSpeedDown = thirdSpeed * thirdTimeInMinute / 60;

            decimal finalDistance = distanceAfterStart + distanceAfterSpeedUp + distanceAfterSpeedDown;
            Console.WriteLine("{0:f2}", finalDistance);
            
            

        }
    }
}
