using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char lastSymbol = char.Parse(Console.ReadLine());
            char skipSymbol = char.Parse(Console.ReadLine());

            int counter = 0;


            for (char symbol1 = firstSymbol; symbol1 <= lastSymbol; symbol1++)
            {
                if (symbol1 != skipSymbol)
                {
                    for (char symbol2 = firstSymbol; symbol2 <= lastSymbol; symbol2++)
                    {
                        if (symbol2 != skipSymbol)
                        {
                            for (char symbol3 = firstSymbol; symbol3 <= lastSymbol; symbol3++)
                            {
                                if (symbol3 != skipSymbol)
                                {
                                    counter++;
                                    string currentOutput =
                                        symbol1.ToString() +
                                        symbol2.ToString() +
                                        symbol3.ToString();

                                    Console.Write($"{currentOutput} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }

    }
}
