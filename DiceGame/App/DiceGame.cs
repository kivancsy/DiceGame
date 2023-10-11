using DiceGame.App;
using DiceGame.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class DiceGame
    {
        static void Main(string[] args)
        {
            AppScreen.Introduction();
            AppScreen.PlayerInput();
            AppScreen.DiceGameUI();
            Console.ReadLine();
        }
    }
}
