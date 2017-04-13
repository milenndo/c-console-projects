using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int finalInterval = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int combination = 0;
          
            for (int i = startInterval; i >= finalInterval; i--)
            {
                for (int j = startInterval; j >= finalInterval; j--)
                {
                    combination++;
                    if(i + j == magicalNum)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combination,i,j,magicalNum);
                        return;
                    }
                }
            }

            for (int i = startInterval; i >= finalInterval; finalInterval--)
            {
                for (int j = startInterval; j >= finalInterval; finalInterval--)
                {
                    combination++;
                    if (i+j != 0)
                    {
                        Console.WriteLine("{0} combinations - neither equals {1}", combination - 1, magicalNum);
                        return;
                    }
                }
            }

           


            

            
            
            



        }
    }
}
