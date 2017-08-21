using BluffChallange.Model;
using BluffChallange.Controller;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// For the challange that I started this project from
/// http://honeypot.softwareskills.se/#/contest/55f67c9b92be260c0f8a62ac
/// </summary>
namespace BluffChallange
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Players = controller.letPlayersRollDices(Convert.ToInt32(numOfPlayer.Text));

        }
        static int roundCounter;
        List<Player> players;
        BluffChallange.Controller.Controller controller = new BluffChallange.Controller.Controller();

        public List<Player> Players { get => players; set => players = value; }

        private void roll_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine("Number of players : " + numOfPlayer.Text);
           
            Game game = new Game();
            
            

            for (int i = 0; i < Convert.ToInt32(numOfPlayer.Text);i++)
            {
                sb.AppendLine("\nDices for player : "
                    + i);

                Players[i].Dices = new List<string>();

                if (roundCounter.Equals(0))
                {
                    Players[i].DiceCount = Convert.ToInt32(startingDiceCombobox.Text);

                }
                else
                {
                    Players[i].DiceCount = Players[i].Dices.Count;
                }
                    

                for (int j = 0; j < Players[i].DiceCount; j++)
                {
                    Players[i].Dices.Add(Players[i].rollDice());
                    Players[i].convertRolledDice(players[i].rollDice());

                    sb.AppendLine(Players[i].rollDice());
                }
                
                if (Players[i].Dices.Count < 1)
                {
                    sb.AppendLine("player : " + i + " has no dices left");
                }

                game.counRoundScore(Players[i]);

                sb.AppendLine("Player " + i + ". Round score : " + players[i].RoundScore);
                sb.AppendLine();

            }
            for(int i = 0; i < Players.Count-1;i++)
            {
                if(Players[i].RoundScore < Players[i + 1].RoundScore)
                {
                    sb.AppendLine("Player : " + i+1 + " Has won the round");
                    Players[i].DiceCount -= 1;
                }
                else if(Players[i].RoundScore.Equals(Players[i+1].RoundScore))
                {
                    sb.AppendLine("It's a tie");
                }
                else
                {
                    sb.AppendLine("Player : " + i + " Has won the round");
                    Players[i + 1].DiceCount -= 1;

                }
            }
            game.compareScores(Players);
            GameOutput.Text = sb.ToString();
            roundCounter += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    BluffChallange.Forms.BidForm bidForm = new BluffChallange.Forms.BidForm(Players[0]);
                    bidForm.Show();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please start the round before making a bid.");
            }
        }
    }
}
