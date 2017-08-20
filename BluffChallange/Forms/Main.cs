﻿using BluffChallange.Model;
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
        List<Player> players;
        public List<Player> Players { get => players; set => players = value; }

        private void roll_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            BluffChallange.Controller.Controller controller = new BluffChallange.Controller.Controller();
            sb.AppendLine("Number of players : " + numOfPlayer.Text);
            Players = controller.letPlayersRollDices(Convert.ToInt32(numOfPlayer.Text));
            for(int i = 0; i < Convert.ToInt32(numOfPlayer.Text);i++)
            {
                sb.AppendLine("Dices for player : "
                    + i);
                Players[i].Dices = new List<string>();
                for (int j = 0; j < players[i].DiceCount; j++)
                {
                    Players[i].Dices.Add(Players[i].rollDice());
                    Players[i].convertRolledDice(players[i].rollDice());

                    sb.AppendLine(Players[i].rollDice());
                    

                }
            }
            
            GameOutput.Text = sb.ToString();
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
