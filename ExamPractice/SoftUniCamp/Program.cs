using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int totalStudentsCnt = 0;
            
            int carCnt = 0;
            int minivanCnt = 0;
            int smallBusCnt = 0;
            int bigBusCnt = 0;
            int trainCnt = 0;



            for (int i = 0; i < groupsCount; i++)
            {
                int studentsCount = int.Parse(Console.ReadLine());

                totalStudentsCnt += studentsCount;

                if (studentsCount <= 5)
                {
                    carCnt += studentsCount;
                }
                else if (studentsCount <= 12)
                {
                    minivanCnt += studentsCount;
                }
                else if (studentsCount <= 25)
                {
                    smallBusCnt += studentsCount;
                }
                else if (studentsCount <= 40)
                {
                    bigBusCnt += studentsCount;
                }
                else 
                {
                    trainCnt += studentsCount;
                }

            }

            double carPercent = (double)carCnt / totalStudentsCnt * 100;
            double minivanPercent = minivanCnt / (double)totalStudentsCnt * 100;
            double smallBusPercent = (double)smallBusCnt / totalStudentsCnt * 100;
            double bigBusPercent = (double)bigBusCnt / totalStudentsCnt * 100;
            double trainPercent = (double)trainCnt / totalStudentsCnt * 100;

            Console.WriteLine("{0:f2}%", carPercent);
            Console.WriteLine("{0:f2}%", minivanPercent);
            Console.WriteLine("{0:f2}%", smallBusPercent);
            Console.WriteLine("{0:f2}%", bigBusPercent);
            Console.WriteLine("{0:f2}%", trainPercent);

            
        }

    }
}
