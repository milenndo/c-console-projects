﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiss
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
