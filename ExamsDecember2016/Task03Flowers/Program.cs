using System;


namespace Task03Flowers
{
    class Program
    {
        static void Main()
        {
            int hrizCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipCount = int.Parse(Console.ReadLine());

            string season = Console.ReadLine();
            string checkHoliday = Console.ReadLine();
            bool isHoliday = false;
            if (checkHoliday == "Y")
            {
                isHoliday = true;
            }

            double flowerSetSum = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    flowerSetSum = hrizCount * 2.00 + rosesCount * 4.10 + tulipCount * 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    flowerSetSum = hrizCount * 3.75 + rosesCount * 4.50 + tulipCount * 4.15;
                    break;
                
                   

            }

            if (isHoliday)
            {
                flowerSetSum *= 1.15; 
            }
            if (tulipCount > 7 && season == "Spring")
            {
                flowerSetSum *= 0.95;
            }

            if (rosesCount >= 10 && season == "Winter")
            {
                flowerSetSum *= 0.90;
            }

            if (hrizCount + rosesCount + tulipCount > 20)
            {
                flowerSetSum *= 0.80;
            }
            Console.WriteLine((flowerSetSum + 2).ToString("0.00"));
        }
    }
}
