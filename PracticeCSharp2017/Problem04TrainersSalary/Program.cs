using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04TrainersSalary
{
    class Program
    {
        static void Main()
        {

            //int lectures = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double lecturesRate = budget / lectures;
            


            // counter Lectors form zero
            int lectorJelev = 0;
            int lectorRoYaL = 0;
            int lectorRoli = 0;
            int lectorTrofon = 0;
            int lectorSino = 0;
            int othesLectors = 0;


            

            for (int i = 1; i <= lectures; i++)
            {
                string lector = Console.ReadLine();

                    if (lector == "Jelev") lectorJelev++;
                
                    if (lector == "RoYaL" ) lectorRoYaL++;
                
                    if (lector == "Roli") lectorRoli++;
               
                    if (lector == "Trofon") lectorTrofon++;
               
                    if (lector == "Sino") lectorSino++;
               
                    if (lector != "Jelev" && lector != "RoYaL" 
                     && lector != "Roli" && lector != "Trofon" 
                     && lector != "Sino") othesLectors++;
                
                

            }
            Console.WriteLine("Jelev salary: {0:f2} lv", lectorJelev * lecturesRate);
            Console.WriteLine("RoYaL salary: {0:f2} lv", lectorRoYaL * lecturesRate);
            Console.WriteLine("Roli salary: {0:f2} lv", lectorRoli * lecturesRate);
            Console.WriteLine("Trofon salary: {0:f2} lv", lectorTrofon * lecturesRate);
            Console.WriteLine("Sino salary: {0:f2} lv", lectorSino * lecturesRate);
            Console.WriteLine("Others salary: {0:f2} lv", othesLectors * lecturesRate);

        }
    }
}
