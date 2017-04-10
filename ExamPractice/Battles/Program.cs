using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {

            int fistPlayerPokemons = int.Parse(Console.ReadLine());
            int secondPlayerPokemons = int.Parse(Console.ReadLine());
            int maxFights = int.Parse(Console.ReadLine());

            int fightCnt = 0;

            for (int i = 1; i <= fistPlayerPokemons; i++)
            {
                for (int j = 1; j <= secondPlayerPokemons; j++)
                {
                    if (fightCnt >= maxFights)
                    {
                        break;
                    }

                    Console.Write($"({i} <-> {j}) ");
                    fightCnt++;

                    
                }
            }




        }
    }
}
