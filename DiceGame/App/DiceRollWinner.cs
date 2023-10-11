using DiceGame.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceGame.App
{
    internal class DiceRollWinner
    {
        public static void WinOrLose(int x, int y)
        {
            if (x > y)
            {
                Console.Clear();
                Utility.PrintChar("\nAh Congratulations friend! Now let me satisfy your natural curiosity about this occurrence...\n");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (x < y)
            {
                Console.Clear();
                Utility.PrintDot();
                Utility.PrintChar("\nThat is not dead which can eternal lie," +
                    " And with strange aeons even death may die.\nSleep well friend.", false);
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else
            {
                Utility.PrintChar("Hmmmm...");
                Console.Clear();   
                Utility.PrintChar("A tie is not...");
                Console.Clear();
                Utility.PrintChar("ACCEPTABLE!",false);
                AppScreen.DiceGameUI();
            }
        }
    }
}
