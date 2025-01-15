using System;
using DiceRoller;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Dice sim loading...");
        Initialize();
        int rolls = Program.UserInput();
        roller.RollDice(rolls);

    }

    private static int UserInput()
    {
        while (true)
        {
            System.Console.WriteLine("How many rolls?");
            try
            {
                int rolls = int.Parse(Console.ReadLine());
                return rolls;
            }
            catch
            {
                System.Console.WriteLine("Please enter a valid number");
            }
        }
    }

    private static void Initialize()
    {
        try
        {
            roller TestRoller = new roller();
            System.Console.WriteLine("Welcome to the dice roller!");
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Error loading dice roller: " + e.Message);
        }
    }
}