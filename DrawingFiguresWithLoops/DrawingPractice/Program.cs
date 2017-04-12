using System;


namespace DrawingPractice
{
    class Program
    {
        static void Main()
        {

            var sideOfSqure = int.Parse(Console.ReadLine());
            for (var row = 0; row < sideOfSqure; row++)
            {

                for (int col = 0; col < sideOfSqure; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
