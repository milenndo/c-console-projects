using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int konNum = int.Parse(Console.ReadLine());

            int move = 0;                                      
            int sumN = 0;
            int sumM = 0;


            while (true)
            {
                for (int numN = 1; numN <= N; numN++)
                {
                    sumN = N * 2;
                    move++;
                    sumN += sumN * numN;
                    //Console.WriteLine(sumN);

                    if (sumN >= konNum)
                    {
                        Console.WriteLine($"{move} moves");
                        Console.WriteLine($"Score: {sumN} >= {konNum}");
                        break;
                    }

                }


                for (int numM = M; numM >= 0; numM--)
                {
                    sumM = M * 3;
                    move++;
                    sumM += sumM * numM;
                    Console.WriteLine(sumM);



                    if (true)
                    {
                        Console.WriteLine($"{move} moves");
                        Console.WriteLine($"Score: {sumM} >= {konNum}");
                        break;
                    }

                }
            }                                                   
            
            //int sum = sumN + sumM;
            //Console.WriteLine(sum);                                               
           





        }
    }
}
