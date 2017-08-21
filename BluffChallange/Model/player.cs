using System;
using System.Collections.Generic;

namespace BluffChallange.Model
{
    public class Player
    {
        Random random;
        public Player(Random random) => this.random = random;
        public int Bid { get => bid; set => bid = value; }
        public List<string> Dices { get => dices; set => dices = value; }
        public int RoundScore { get => roundScore; set => roundScore = value; }
        public int DiceCount { get => diceCount; set => diceCount = value; }

        List<string> dices;
        int diceCount;
        int bid;
        int roundScore;
        
        public Player()
        {
            dices = new List<string>();
        }

        public int convertRolledDice(string faceValue)
        {
            int returnvalue = 0;
            if(faceValue.Equals("star"))
            {
                returnvalue = 6;
            }
            else
            {
                returnvalue = Convert.ToInt32(faceValue);
            }
            return returnvalue;
        }

        public string rollDice()
        {
            
            Dice dice = new Dice();
            return dice.roll(random);

           
        }
    }
}
