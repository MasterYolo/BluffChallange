using System;
using System.Collections.Generic;

namespace BluffChallange.Model
{
    /// <summary>
    /// Player - 
    /// The player class. This class represents a player.
    /// The class is using properties to set values.
    /// </summary>
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
        /// <summary>
        /// creates a new List of strings each time the player object is created.
        /// </summary>
        public Player()
        {
            dices = new List<string>();
        }

        /// <summary>
        /// convertRolledDice - 
        /// Converts the "Wild cards" to a value.
        /// </summary>
        /// <param name="faceValue">The value of a dice.</param>
        /// <returns></returns>
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

        /// <summary>
        /// rollDice - Cretes a new random value for the dice with the singelton random object.
        /// </summary>
        /// <returns></returns>
        public string rollDice()
        {
            
            Dice dice = new Dice();
            return dice.roll(random);

           
        }
    }
}
