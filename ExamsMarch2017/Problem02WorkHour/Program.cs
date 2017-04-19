using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02WorkHour
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int humansAmount = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            double hoursFromRepair = humansAmount * workingDays * 8;
            //Console.WriteLine(hoursFromRepair);

            
            if (hoursFromRepair > hours)
            {
                double leftHours = hoursFromRepair - hours;
                Console.WriteLine("{0} hours left", leftHours);
            }
            if (hoursFromRepair  < hours)
            {
                double overTime = hours - hoursFromRepair;
                Console.WriteLine("{0} overtime", overTime);
                double penalties = overTime * workingDays;
                Console.WriteLine("Penalties: {0}", penalties);
            }



        }
    }
}
