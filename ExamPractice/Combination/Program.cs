using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char forbiddenLetter = char.Parse(Console.ReadLine());
            int cnt = 0;

            for (char i = firstLetter; i <= lastLetter; i++)
            {
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        if (k != forbiddenLetter && j != forbiddenLetter && i != forbiddenLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                            cnt ++;
                        }
                        
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
