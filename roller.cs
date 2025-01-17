using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class roller //Method does heavy lifting (rolling, storing, converting, and printing)
    {
        private int rolls; //initialize variable so input can be stored

        public roller() { rolls = 0; } //default to rolls=0 for error handling on initialization

        public static int[] RollDice(int rolls) //the rolling function
        {
            int[] counts = new int[11]; //initialize array
            
            for (int i = 0; i < rolls; i++) //loop dice rolls as many times as the user inputs
            {
                int die1 = new Random().Next(1, 7);
                int die2 = new Random().Next(1, 7);
                int dieResult = die1 + die2; //add die1 and die2

                counts[dieResult - 2]++; //increment on current die result to track occurrences
            }
            
            for (int i = 0; i < counts.Length; i++) //convert counts to percentages
            {
                counts[i] = Math.Round(counts[i] * 100 / rolls, 2);
            }

            for (int i = 0; i < counts.Length; i++) //print results
            {
                Console.WriteLine(i + 2 + ": " + counts[i]);
            }

            return counts;
        }
    }
}
