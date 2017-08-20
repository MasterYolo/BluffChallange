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
        }

        private void bidButton_Click(object sender, EventArgs e)
        {

        }
    }
}
