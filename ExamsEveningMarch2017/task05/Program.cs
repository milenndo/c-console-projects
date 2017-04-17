using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 1;
            int height = 4 * n + 4;

            string dot = (".");
            string star = ("+");
            string nCherta = (@"\"); 
            string traba = ("|");
            string kadrava = ("~");


            // 4 * n + 4 - reda

            Console.WriteLine("+" + new string ('~', n-2) + "+" + new string ('.', width - n));

            for (int row = 0; row < 2 * n + 1   ; row++)
            {
                
                
                    Console.WriteLine("|" + new string('.',  row) + nCherta + new string ('~', n - 2) + nCherta + new string('.', 2 * n - row ));
            
                

            }

            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine(new string('.', i) + nCherta + new string('.', 2 * n - i) + traba + new string('~', n - 2) + traba);
            }


            Console.WriteLine(new string('.', width - n) + "+" + new string('~', n - 2) + "+"  );


            Console.WriteLine();











        }
    }
}
