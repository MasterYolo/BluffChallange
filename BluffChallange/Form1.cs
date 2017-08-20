using BluffChallange.Model;
using BluffChallange.Controller;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BluffChallange
{
    public partial class Form1 : Form
    {
        public Form1()
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
        
    }
}
