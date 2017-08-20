using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffChallange.Model
{
    public class Player
    {
        private int diceCount = 6;
        Random random;
        public Player(Random random) => this.random = random;

        public int DiceCount { get => diceCount; set => diceCount = value; }

        public string rollDice()
        {
            Dice dice = new Dice();
            return dice.roll(random);
           
        }
    }
}
