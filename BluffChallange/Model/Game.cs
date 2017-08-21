using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffChallange.Model
{
   public class Game
    {
        public void counRoundScore(Player player)
        {
            for (int i = 0; i < player.Dices.Count; i++)
            {
                player.RoundScore += player.convertRolledDice(player.Dices[i]);
            }
        }
        public void compareScores(List<Player> players)
        {
            for(int i = 0; i < players.Count-1; i++)
            {
                if(players[i].RoundScore < players[i+1].RoundScore)
                {
                    players[i].DiceCount -= 1;
                    players[i].Dices.Take(players[i].Dices.Count - 1);
                }
                else if(players[i].RoundScore.Equals(players[i+1].RoundScore))
                {
                    //Since it is a tie. Do not do anything
                }
                else
                {
                    players[i + 1].DiceCount -= 1;
                    players[i + 1].Dices.Take(players[i].Dices.Count - 1);
                }
            }
        }
    }
}
