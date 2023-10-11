using DiceGame.Dice;
using DiceGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.App
{
    internal class PlayerDiceRoll:BaseDiceRoll
    {
        Random playerRandom = new Random();
        PlayerDice playerDice = new PlayerDice();
        public override int RollTheDice()
        {
            playerDice.Dice = playerRandom.Next(1, 12);
            return playerDice.Dice;
        }
    }
}
