using DiceGame.Dice;
using DiceGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.App
{
    internal class WizardDiceRoll:BaseDiceRoll
    {
        Random wizardRandom = new Random();
        WizardDice wizardDice = new WizardDice();
        public override int RollTheDice()
        {
            wizardDice.Dice = wizardRandom.Next(1, 12);
            return wizardDice.Dice;
        }
    }
}
