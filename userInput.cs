using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class userInput
    {
        public userInput() { }

        public static int UserInput() //user input function
        {
            while (true) //error handling
            {
                System.Console.WriteLine("How many rolls?");
                try
                {
                    int rolls = int.Parse(Console.ReadLine());
                    return rolls; //return user input as long as it is a number
                }
                catch
                {
                    System.Console.WriteLine("Please enter a valid number");
                }
            }
        }


    }
}
