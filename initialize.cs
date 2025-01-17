using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class initialize
    {
        public initialize() { }

        public static void Initialize() //check to make sure the roller class can be loaded
        {
            try //catch errors in loading the program
            {
                roller TestRoller = new roller();
                System.Console.WriteLine("Welcome to the dice roller!"); //if it can be loaded
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error loading dice roller: " + e.Message);
            }
        }
    }
}
