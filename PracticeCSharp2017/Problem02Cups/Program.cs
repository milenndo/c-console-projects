using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsExpectation = int.Parse(Console.ReadLine());
            int personals = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            // Изработване на 1 чаша
            decimal cupPrice = Math.Round(4.20m, 2);
            //WriteLine(cupPrice);
            
            // One personal work's hours
            double workHours = personals * workDays * 8;
            //Console.WriteLine(workHours);

            // Amount  cups into hours

            double cupAmounts = (Math.Floor( workHours / 5));
            //Console.WriteLine(cupAmounts);
            //Console.WriteLine(cupsExpectation);
            


            if (cupAmounts < cupsExpectation)
            {
                
                double losses = cupsExpectation - cupAmounts;
                Console.WriteLine("Losses: {0}", (decimal)losses * cupPrice);

            }
            else
            {
                double extraMoney = cupAmounts - cupsExpectation;
                Console.WriteLine("{0} extra money", (decimal)extraMoney * cupPrice);
            }

        }
    }
}
