using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03CarToGo
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
                        

            if (budget <= 100.00)
            {
                
                     if (season == "Summer")
                     {
                         string carClass = "Economy class";
                         string carType = "Cabrio";
                         double priceCarS = budget * 0.35;
                         Console.WriteLine("{0}", carClass);
                         Console.WriteLine("{0} - {1:f2}", carType, priceCarS);
                     }
                     if (season == "Winter")
                     {
                         string carClass = "Economy class";
                         string carType = "Jeep";
                         double priceCarW = budget * 0.65;
                         Console.WriteLine("{0}", carClass);
                         Console.WriteLine("{0} - {1:f2}", carType, priceCarW );


                     }

            }

            if (budget > 100.00 && budget <= 500)
            {

                if (season == "Summer")
                {
                    string carClass = "Compact class";
                    string carType = "Cabrio";
                    double priceCarS = budget * 0.45;
                    Console.WriteLine("{0}", carClass);
                    Console.WriteLine("{0} - {1:f2}", carType, priceCarS);
                }
                if (season == "Winter")
                {
                    string carClass = "Compact class";
                    string carType = "Jeep";
                    double priceCarW = budget * 0.80;
                    Console.WriteLine("{0}", carClass);
                    Console.WriteLine("{0} - {1:f2}", carType, priceCarW);


                }

            

            }

            if (budget > 500)
            {

                if (season == "Summer")
                {
                    string carClass = "Luxury class";
                    string carType = "Jeep";
                    double priceCarS = budget * 0.90;
                    Console.WriteLine("{0}", carClass);
                    Console.WriteLine("{0} - {1:f2}", carType, priceCarS);
                }
                if (season == "Winter")
                {
                    string carClass = "Luxury class";
                    string carType = "Jeep";
                    double priceCarW = budget * 0.90;
                    Console.WriteLine("{0}", carClass);
                    Console.WriteLine("{0} - {1:f2}", carType, priceCarW);


                }

            }




        }

    }
}
