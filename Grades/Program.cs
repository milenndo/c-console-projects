using System;


namespace Grades
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            int failCount = 0;
            int goodCount = 0;
            int veryGoodCount = 0;
            int exellentCount = 0;

            for (int i = 0; i < n; i++)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                sum += currentGrade;
                if (currentGrade < 3)
                {
                    failCount++;
                }
                else if (currentGrade < 4)
                {
                    goodCount++;
                }
                else if (currentGrade < 5)
                {
                    veryGoodCount++;
                }
                else
                {
                    exellentCount++;
                }
            }
            Console.WriteLine($"Top students: {(exellentCount / (double)n).ToString("0.00%")}");

            Console.WriteLine($"Between 4.00 and 4.99: {(veryGoodCount / (double)n).ToString("0.00%")}");
            Console.WriteLine($"Between 3.00 and 3.99: {(goodCount / (double)n).ToString("0.00%")}");
            Console.WriteLine($"Fail: {(failCount / (double)n).ToString("0.00%")}");
            double avg = sum / n;
            Console.WriteLine($"Average: {avg.ToString("0.00")}");
        }
    }
}
