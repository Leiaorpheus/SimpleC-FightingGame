using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior max = new Warrior("Teddy", 1500, 120, 50);
            Warrior bob = new Warrior("Neighbour's cat", 500, 300, 300);
            Battle.startFighting(max, bob);

        }
    }
}
