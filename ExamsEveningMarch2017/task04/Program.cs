using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    class Program
    {
        static void Main()
        {
            int mouths = int.Parse(Console.ReadLine());

            double water = 20;
            double internet = 15;
            double waterM = water * mouths;
            double internetM = internet * mouths;

            double SumEleBill = 0;

            for (int i = 1; i <= mouths; i++)
            {
                double bill1 = double.Parse(Console.ReadLine());
                SumEleBill += bill1;
            }
            //Console.WriteLine(SumEleBill);
            double outherBill = SumEleBill + waterM + internetM + ((SumEleBill+ waterM + internetM)* 20 / 100);
            //Console.WriteLine(outherBill);
            double average = (SumEleBill + waterM + internetM + outherBill) / mouths;
            //Console.WriteLine(average);

            Console.WriteLine("Electricity: {0:f2} lv", SumEleBill);
            Console.WriteLine("Water: {0:f2} lv", waterM);
            Console.WriteLine("Internet: {0:f2} lv", internetM );
            Console.WriteLine("Other: {0:f2} lv", outherBill);
            Console.WriteLine("Average: {0:f2} lv", average);

        }

    }                                      
                                           
                                           
}                                          
                                           
                                           
                                           
                                           
                                           
                                           
                                           
                                           
                                       

                                       
                                       
                                       
                                       
                                       
                                       
                                                                                                                          
                                            
                                                            
           

          

            







