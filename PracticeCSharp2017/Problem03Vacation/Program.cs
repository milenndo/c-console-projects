using System;


namespace Problem03Vacation
{
    class Program
    {
        static void Main()
        {
            double  budget = double.Parse(Console.ReadLine());
            
            string season = Console.ReadLine();
            
            
            
            // bugeat < 1000 leva

            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    string place = "Camp";
                    string location = "Alaska";
                    double price = budget * 0.65;
                    Console.WriteLine($"{location} - {place} - {price:f2}");
                }
                if (season == "Winter")
                {
                    string place = "Camp";
                    string location = "Morocco";
                    double price = budget * 0.45;
                    Console.WriteLine($"{location} - {place} - {price:f2}");
                }
 
            }

            // budget > 1000<= 3000

            if (budget > 1000 && budget <= 3000)
            {
                if (season == "Summer")
                {
                    string place = "Hut";
                    string location = "Alaska";
                    double price = budget * 0.80;
                    Console.WriteLine($"{location} - {place} - {price:f2}");
                }
                if (season == "Winter")
                {
                    string place = "Hut";
                    string location = "Morocco";
                    double price = budget * 0.60;
                    Console.WriteLine($"{location} - {place} - {price:f2}");
                }

            }

            // budget > 3000;
            if (budget >= 3000)
            {
                if (season == "Summer")
                {
                    string place = "Hotel";
                    string location = "Alaska";
                    double price = budget * 0.90;
                    Console.WriteLine($"{location} - {place} - {price:f2}");
                }
                if (season == "Winter")
                {
                    string place = "Hotel";
                    string location = "Morocco";
                    double price = budget * 0.90;
                    Console.WriteLine($"{location} - {place} - {price:f2}");
                }

                
            }
           
        }
    }
}
