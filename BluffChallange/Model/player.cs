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
        public int Bid { get => bid; set => bid = value; }
        public int Facevalue { get => facevalue; set => facevalue = value; }

        int bid;
        int facevalue;

        public int convertRolledDice(string faceValue)
        {
            if(faceValue.Equals("star"))
            {
                Facevalue = 6;
            }
            else
            {
                Facevalue = facevalue;
            }
            return Facevalue;
        }

        public string rollDice()
        {
            Dice dice = new Dice();
            return dice.roll(random);
           
        }
    }
}
