using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffChallange.Model
{
    public class Dice
    {
        List<string> sides = new List<string>{ "1", "2", "3", "4", "5", "star" };
        public List<string> Sides { get => sides; set => this.sides = value; }
        public string roll(Random random)
        {
           
            Dice dice = new Dice();
            int choosenIndex = random.Next(dice.Sides.Count);
            string dicevalue = sides[choosenIndex];
            return dicevalue;
        }
    }
}
