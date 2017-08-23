using System;
using System.Collections.Generic;

namespace BluffChallange.Model
{
    /// <summary>
    /// Dice - Represents a dice.
    /// </summary>
    public class Dice
    {
        List<string> sides = new List<string>{ "1", "2", "3", "4", "5", "star" };
        public List<string> Sides { get => sides; set => this.sides = value; }
        /// <summary>
        /// Picks a random value from 1 to star.
        /// </summary>
        /// <param name="random">A singelton random object</param>
        /// <returns></returns>
        public string roll(Random random)
        {
           
            Dice dice = new Dice();
            int choosenIndex = random.Next(dice.Sides.Count);
            string dicevalue = sides[choosenIndex];
            return dicevalue;
        }
    }
}
