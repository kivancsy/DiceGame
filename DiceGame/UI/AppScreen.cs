using DiceGame.App;
using DiceGame.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceGame.UI
{
    public class AppScreen
    {
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.PrintChar("\nHey there, I see you have woken up from your deep slumber." +
                "\nWhat's that? Who am I? Where are you?" +
                "\nWell, simply, these are not the questions you should be asking, they do not matter." +
                "\nWhat matters is, would you like to soothe this inquisitive appetite of yours with a game of dice?", true, 30);
            Utility.PressEnterToProceed();
        }
        public static void PlayerInput()
        {
            ConsoleKeyInfo inputKey = Console.ReadKey(true);
            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Utility.PrintChar("\nWonderful! Finally a play mate!");
                Utility.PressSpaceToRoll();
            }
            else if (inputKey.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Utility.PrintChar("Are you refusing me friend?", false);
                Utility.PressEnterToProceed();
                ConsoleKeyInfo inputKey2 = Console.ReadKey(true);

                if (inputKey2.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Utility.PrintChar("Good.\nLet's play then, shall we?");
                    Utility.PressSpaceToRoll();
                }
                else
                {
                    Utility.PrintDot();
                    Utility.PrintChar("THEN ROT IN THE DEEPEST PITS OF THE VOID, YOU SHALL!", false);
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
            }

        }

        public static void DiceGameUI()
        {

            while (true)
            {
                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    int playerDice = DiceGameUIPlayer();
                    int wizardDice = DiceGameUIWizard();
                    DiceRollWinner.WinOrLose(playerDice, wizardDice);

                }
                else
                {
                    Console.Clear();
                    Utility.PrintChar("Roll the dice friend. For your own good.",false);
                    Utility.PressSpaceToRoll();
                    ConsoleKeyInfo inputKey2 = Console.ReadKey(true);
                    if (inputKey2.Key == ConsoleKey.Spacebar)
                    {
                        int playerDice = DiceGameUIPlayer();
                        int wizardDice = DiceGameUIWizard();
                        DiceRollWinner.WinOrLose(playerDice, wizardDice);
                    }
                    else
                    {
                        Console.Clear();
                        Utility.PrintDot();
                        Utility.PrintChar("YOG-SOTHOTH, FNAIY'GHEE VULTGTMM,FHTAGN! YHN'AI MGEP NAWL!", false);
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                }
            }

        }

        public static int DiceGameUIWizard()
        {
            WizardDiceRoll wizardDiceRoll = new WizardDiceRoll();
            WizardDice wizardDice = new WizardDice();
            wizardDice.Dice = wizardDiceRoll.RollTheDice();
            Utility.PrintDice(6, false);
            Utility.PrintChar($"\nThe Wizard has rolled : {wizardDice.Dice}");
            Thread.Sleep(1000);
            return wizardDice.Dice;
        }
        public static int DiceGameUIPlayer()
        {
            PlayerDiceRoll playerDiceRoll = new PlayerDiceRoll();
            PlayerDice playerDice = new PlayerDice();
            playerDice.Dice = playerDiceRoll.RollTheDice();
            Utility.PrintDice(6, true);
            Utility.PrintChar($"\nYou have rolled : {playerDice.Dice}");
            Thread.Sleep(1000);
            return playerDice.Dice;
        }
    }
}
