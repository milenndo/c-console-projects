using System;


namespace Problem05Hourglass
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // draw clock  height and width 2 * n + 1;

            string stars = new string('*', 2 * n + 1 );
            Console.WriteLine(stars);
            int width = 2 * n + 1;
            int height = 2 * n + 1;
            string dot = (".");
            string star = ("*");
            string monkey = ("@");


            //up part
            Console.WriteLine(dot + star + new string(' ', 2 * n + 1 - 4) + star + dot);



            for (int i = 2; i < n; i++)
            {
                Console.WriteLine(new string('.', i) + "*" + new string('@',width/2 - 1 - i ) + new string('@', n  - i) + "*" + new string('.', i ));


            }
            Console.Write(new string('.', width / 2) + "*" + new string('.', width / 2));

            
            Console.WriteLine();
            // down part
            for (int i = width / 2; i > 2; i--)
            {
                Console.WriteLine(new string('.', i -1) + "*" + new string(' ', width/2 - i) + "@" + new string(' ', width/2 - i) + "*" +  new string('.', i - 1));
               
            }
            
            Console.WriteLine("." + "*" + new string ('@', width - 4) + "*" + ".");








            Console.WriteLine(stars);
            







        }
    }
}
