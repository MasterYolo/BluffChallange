using BluffChallange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffChallange.Controller
{
    public class Controller
    {
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
