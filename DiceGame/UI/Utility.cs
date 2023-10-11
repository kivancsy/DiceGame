using DiceGame.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Utility
    {
        public static void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
        public static void PressEnterToProceed()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMessage("\n\nPress the enter key to proceed");

        }
        public static void PrintChar(string text, bool positive = true, int timer = 50)
        {
            if (positive == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i]);
                    Thread.Sleep(timer);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i]);
                    Thread.Sleep(50);
                }
            }

        }
        public static void PrintDot(int timer = 3)
        {
            Console.Clear();
            for (int i = 0; i < timer; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Clear();
        }
        public static void PrintDice(int timer = 6, bool player = true)
        {
            if (player == true)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Yellow;
                for (int i = 0; i < timer; i++)
                {
                    Console.Write("■ ");
                    Thread.Sleep(500);
                }

                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < timer; i++)
                {
                    Console.Write("■ ");
                    Thread.Sleep(500);
                }

                Console.Clear();
            }
            
        }
        public static void PressSpaceToRoll()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMessage("\n\nPress the space button to roll the dice.");
        }
    }

}
