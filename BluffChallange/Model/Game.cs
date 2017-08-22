using System.Collections.Generic;
using System.Linq;

namespace BluffChallange.Model
{
    /// <summary>
    /// The game class.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// counts the score for each player for each round.
        /// </summary>
        /// <param name="player">Object Player which is a class that holds the player object. </param>
        public void countRoundScore(Player player)
        {
            for (int i = 0; i < player.DiceCount; i++)
            {
                player.RoundScore += player.convertRolledDice(player.Dices[i]);
            }
        }
        /// <summary>
        /// Compares the score of the players that playess the game.
        /// TODO compare more than i+1 objects
        /// </summary>
        /// <param name="players">Object Player which is a class that holds the player object. </param>
        public void compareScores(List<Player> players)
        {
            for(int i = 0; i < players.Count-1; i++)
            {
                if(players[i].RoundScore < players[i+1].RoundScore)
                {
                    players[i].DiceCount -= 1;
                    players[i].Dices.Take(players[i].Dices.Count - 1);
                    players[i].RoundScore = 0;
                    players[i + 1].RoundScore = 0;
                }
                else if(players[i].RoundScore.Equals(players[i+1].RoundScore))
                {
                    //If it is a tie. Just reset scores
                    players[i].RoundScore = 0;
                    players[i + 1].RoundScore = 0;
                }
                else
                {
                    players[i + 1].DiceCount -= 1;
                    players[i + 1].Dices.Take(players[i].Dices.Count - 1);
                    players[i].RoundScore = 0;
                    players[i + 1].RoundScore = 0;
                }
            }
        }
    }
}
