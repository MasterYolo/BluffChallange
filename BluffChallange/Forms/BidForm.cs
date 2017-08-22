using BluffChallange.Model;
using System;
using System.Windows.Forms;

namespace BluffChallange.Forms
{
    /// <summary>
    /// BidForm handles the action when the player is pressing the "Make bid" button
    /// </summary>
    public partial class BidForm : Form
    {
        Player player;
        public BidForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            for(int i = 0; i < player.Dices.Count; i++)
            {
                numOfDices.Items.Add(i.ToString());
                numOfDices.Text = i.ToString();
                valueOfDice.Text = "star";
            }
            
        }

        /// <summary>
        /// The bid button to make a bid. 
        /// </summary>
        /// <param name="sender">An sender object</param>
        /// <param name="e">An EventArgs object</param>
        private void bidButton_Click(object sender, EventArgs e)
        {
            player.Bid = player.convertRolledDice(numOfDices.Text) * player.convertRolledDice(valueOfDice.Text);
            
            Close();
        }
    }
}
