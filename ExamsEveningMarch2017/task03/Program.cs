using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine();
            int kmMouth = int.Parse(Console.ReadLine());


            if (kmMouth <= 5000)
            {
                if  (season == "Spring" || season == "Autumn" )
                {
                    double salaryBeforeTax = (kmMouth * 0.75 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }
                if  (season == "Summer")
                {
                    double salaryBeforeTax = (kmMouth * 0.90 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }
                if (season == "Winter")
                {
                    double salaryBeforeTax = (kmMouth * 1.05 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }

            }




            if (kmMouth > 5000 && kmMouth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    double salaryBeforeTax = (kmMouth * 0.95 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }
                if (season == "Summer")
                {
                    double salaryBeforeTax = (kmMouth * 1.10 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }
                if (season == "Winter")
                {
                    double salaryBeforeTax = (kmMouth * 1.25 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }



             }

            if (kmMouth > 10000 && kmMouth <= 20000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    double salaryBeforeTax = (kmMouth * 1.45 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }
                if (season == "Summer")
                {
                    double salaryBeforeTax = (kmMouth * 1.45 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }
                if (season == "Winter")
                {
                    double salaryBeforeTax = (kmMouth * 1.45 * 4);
                    double salaryAfterTax = salaryBeforeTax - (salaryBeforeTax * 10 / 100);
                    Console.WriteLine("{0:f2}", salaryAfterTax);
                }



            }



        }

    }
}
