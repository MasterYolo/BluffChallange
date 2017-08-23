using System;
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
                for (int k = i + 1; k < players.Count; k++)
                {

                    if (players.Count > 2)
                    {
                        if (players[i].RoundScore > players[k].RoundScore)
                        {
                            i++;
                            k++;
                            if (players[i].RoundScore > players[k].RoundScore)
                            {
                                players[k].DiceCount -= 1;
                                players[k].Dices.Take(players[i].Dices.Count - 1);
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                            else if (players[i].RoundScore < players[k].RoundScore)
                            {
                                players[i].DiceCount -= 1;
                                players[i].Dices.Take(players[i].Dices.Count - 1);
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                            else if (players[i].RoundScore.Equals(players[k].RoundScore))
                            {
                                //If it is a tie. Just reset scores
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }

                        }
                        else if (players[i].RoundScore < players[k].RoundScore)
                        {
                            i++;
                            k++;
                            if (players[i].RoundScore < players[k].RoundScore)
                            {
                                players[i].DiceCount -= 1;
                                players[i].Dices.Take(players[i].Dices.Count - 1);
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                            else if (players[i].RoundScore > players[k].RoundScore)
                            {
                                players[k].DiceCount -= 1;
                                players[k].Dices.Take(players[i].Dices.Count - 1);
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                            else if (players[i].RoundScore.Equals(players[k].RoundScore))
                            {
                                //If it is a tie. Just reset scores
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                        }
                        else if (players[i].RoundScore.Equals(players[k].RoundScore))
                        {
                            i++;
                            k++;
                            if (players[i].RoundScore < players[k].RoundScore)
                            {
                                players[i].DiceCount -= 1;
                                players[i].Dices.Take(players[i].Dices.Count - 1);
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                            else if (players[i].RoundScore > players[k].RoundScore)
                            {
                                players[k].DiceCount -= 1;
                                players[k].Dices.Take(players[i].Dices.Count - 1);
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                            else if (players[i].RoundScore.Equals(players[k].RoundScore))
                            {
                                //If it is a tie. Just reset scores
                                players[i].RoundScore = 0;
                                players[k].RoundScore = 0;
                            }
                        }
                    }
                    //Player count less than three.
                    else
                    {
                        if (players[i].RoundScore < players[k].RoundScore)
                        {
                            players[i].DiceCount -= 1;
                            players[i].Dices.Take(players[i].Dices.Count - 1);
                            players[i].RoundScore = 0;
                            players[k].RoundScore = 0;
                        }
                        else if (players[i].RoundScore > players[k].RoundScore)
                        {
                            players[k].DiceCount -= 1;
                            players[k].Dices.Take(players[i].Dices.Count - 1);
                            players[i].RoundScore = 0;
                            players[k].RoundScore = 0;
                        }
                        else if (players[i].RoundScore.Equals(players[k].RoundScore))
                        {
                            //If it is a tie. Just reset scores
                            players[i].RoundScore = 0;
                            players[k].RoundScore = 0;
                        }
                    }
                }
            }
        }
    }
}
