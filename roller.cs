using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class roller
    {
        private int rolls;

        public roller() { rolls = 0; }

        public static Array RollDice(int rolls)
        {
            for (int i = 0; i < rolls; i++)
            {
                int die1 = new Random().Next(1, 7);
                int die2 = new Random().Next(1, 7);
                int dieResult = die1 + die2;
                Console.WriteLine(dieResult);
            }
            return null;
        }
    }
}
