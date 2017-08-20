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
        }

        private void roll_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            BluffChallange.Controller.Controller controller = new BluffChallange.Controller.Controller();
            sb.AppendLine("Number of players : " + numOfPlayer.Text);
            List<Player> players = controller.letPlayersRollDices(Convert.ToInt32(numOfPlayer.Text));
            for(int i = 0; i < Convert.ToInt32(numOfPlayer.Text);i++)
            {
                sb.AppendLine("Dices for player : "
                    + i);
                for(int j = 0; j < players[i].DiceCount; j++)
                {
                    sb.AppendLine(players[i].rollDice());
                }
            }
            GameOutput.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BluffChallange.Forms.BidForm bid = new BluffChallange.Forms.BidForm();
            bid.Show();
        }
    }
}
