using BluffChallange.Model;
using System;
using System.Windows.Forms;

namespace BluffChallange.Forms
{
    public partial class BidForm : Form
    {
        Player player;
        public BidForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            for(int i = 0; i < player.DiceCount; i++)
            {
                numOfDices.Items.Add(i.ToString());
                numOfDices.Text = i.ToString();
                valueOfDice.Text = "star";
            }
            
        }

        private void bidButton_Click(object sender, EventArgs e)
        {
            player.Bid = player.convertRolledDice(numOfDices.Text) * player.convertRolledDice(valueOfDice.Text);
            
            Close();
        }
    }
}
