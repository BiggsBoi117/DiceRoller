using System;
using DiceRoller;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Dice sim loading...");
        initialize.Initialize();
        int rolls = userInput.UserInput();
        roller.RollDice(rolls);
    }
}