﻿using System;

namespace SnakeandLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This problem simulates a Snake and Ladder Game");
            int StartPositon = StartPosition.StartPositionInitialisation();
            Console.WriteLine("Start Position " + StartPositon);
            int roll = DiceRoll.DiceRollValue();
            Console.WriteLine("value of Dice Roll " + roll);
            int Position = CheckOption.Option(roll, StartPositon);
            Console.WriteLine("Position " + Position);
        }
    }
}