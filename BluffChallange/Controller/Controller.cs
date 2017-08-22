using BluffChallange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffChallange.Controller
{
    /// <summary>
    /// Controller are used to communicate with the data layer.
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Letting the player rolling the dices with the number of players.
        /// </summary>
        /// <param name="numOfPlayers">Number of players that plays the round.</param>
        /// <returns>A List of players.</returns>
        public List<Player> letPlayersRollDices(int numOfPlayers)
        {
            List<Player> listOfPlayers = new List<Player>();
            Player[] player = new Player[numOfPlayers];
            Random random = new Random();
            for (int i = 0; i < numOfPlayers; i++)
            {
                player[i] = new Player(random);
                listOfPlayers.Add(player[i]);
            }
            return listOfPlayers;
        }
    }
}
