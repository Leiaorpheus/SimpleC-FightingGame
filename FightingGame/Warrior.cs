using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class Warrior
    {    // name
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // rand number
        Random rnd = new Random();

        // constructors
        public Warrior (string name = "warrior", 
                        double health = 0,  
                        double attackMax = 0,
                        double blockMax = 0)

        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;

        }

        // attack
        public double attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        // block
        public double block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
