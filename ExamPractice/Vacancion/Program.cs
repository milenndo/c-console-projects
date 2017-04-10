using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancion
{
    class Program
    {
        static void Main(string[] args)
        {
            int elederlyCount = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double transportMoney = 0;

            if (transport == "airplane")
            {
                transportMoney = elederlyCount * 70.00 + studentsCount * 50.00;
            }
            else if (transport == "train")
            {
                transportMoney = elederlyCount * 24.99 + studentsCount * 14.99;

                if (elederlyCount + studentsCount >= 50)
                {
                    transportMoney /= 2;
                }
            }
            else if (transport == "boat")
            {
                transportMoney = elederlyCount * 42.99 + studentsCount * 39.99;
            }
            else if (transport == "bus")
            {
                transportMoney = elederlyCount * 32.50 + studentsCount * 28.50;
            }

            double totalMoney = (transportMoney * 2 + nights * 82.99) * 1.1;

            Console.WriteLine("{0:f2}", totalMoney);
        }

    }
}
