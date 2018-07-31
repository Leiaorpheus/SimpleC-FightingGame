using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    static class Battle
    {
        // start fight
        public static void startFighting(Warrior w1, Warrior w2)
        {
            while (true)
            {
                if (getGameOverResult(w1, w2) == "Game Over")
                {
                    Console.WriteLine("Game over");
                    break;
                }

                if (getGameOverResult(w2, w1) == "Game Over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
            }
        }



        // loop give each a chance to attack and block
        // calculate attack and block
        public static string getGameOverResult(Warrior w1PlaceHolder, Warrior w2PlaceHolder)
        {

            double warAAttack = w1PlaceHolder.attack();
            double warBBlockAmount = w1PlaceHolder.block();

            // how much B is damaged
            double warBDamamgeAmount = warAAttack - warBBlockAmount;
            if (warBDamamgeAmount > 0)
            {
                w2PlaceHolder.Health -= warBDamamgeAmount;
                if (w2PlaceHolder.Health < 0)
                {
                    w2PlaceHolder.Health = 0;
                }
            } else
            {
                warBDamamgeAmount = 0;
            }

            Console.WriteLine("{0} Attacks {1}, and {1} deals with {2} damage", w1PlaceHolder.Name, w2PlaceHolder.Name, warBDamamgeAmount);
            Console.WriteLine("{0} has {1} health", w2PlaceHolder.Name, w2PlaceHolder.Health);
           
            // check if one is dead
            if (w2PlaceHolder.Health <= 0)
            {
                Console.WriteLine("{0} has died, and {1} has win", w2PlaceHolder.Name, w1PlaceHolder.Name);
                return "Game Over";
            }

            return "Continue";
        }


    }
}
