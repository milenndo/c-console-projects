using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishPriceBazar
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudkilos = double.Parse(Console.ReadLine());
            double safridKilos = double.Parse(Console.ReadLine());
            int midiKilos = int.Parse(Console.ReadLine());

            double totalPalamud = (skumriqPrice + skumriqPrice * 0.6) * palamudkilos;
            double totalSafrid = cacaPrice * 1.8 * safridKilos;
            double totalMidi = 7.5 * midiKilos;

            double result = totalPalamud + totalSafrid + totalMidi;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
