﻿using BluffChallange.Model;
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
    /// <summary>
    /// The main form for the Bluff challange.
    /// </summary>
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            players = controller.letPlayersRollDices(Convert.ToInt32(numOfPlayer.Text));

        }
        static int roundCounter;
        List<Player> players;
        BluffChallange.Controller.Controller controller = new BluffChallange.Controller.Controller();

        public List<Player> Players { get => players; set => players = value; }

        /// <summary>
        /// roll_Click - Starts the round
        /// </summary>
        /// <param name="sender">A sender object</param>
        /// <param name="e">An event object</param>
        private void roll_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number of players : " + numOfPlayer.Text);
            Game game = new Game();

            for (int i = 0; i < Convert.ToInt32(numOfPlayer.Text);i++)
            {
                sb.AppendLine("\nDices for player : "
                    + i);
                players[i].Dices = new List<string>();
                //If it is the first round of a game
                if (roundCounter.Equals(0))
                {

                    players[i].DiceCount = Convert.ToInt32(startingDiceCombobox.Text);
                    numOfPlayer.Enabled = false;

                }
                for (int j = 0; j < players[i].DiceCount; j++)
                {
                    players[i].Dices.Add(players[i].rollDice());
                    players[i].convertRolledDice(players[i].rollDice());

                    sb.AppendLine(players[i].rollDice());
                }
                if (players[i].Dices.Count < 1)
                {
                    sb.AppendLine("player : " + i + " has no dices left");
                    numOfPlayer.Enabled = true;
                }
                game.countRoundScore(players[i]);
                sb.AppendLine("Player " + i + ". Round score : " + players[i].RoundScore);
                sb.AppendLine();
            }
            for (int i = 0; i < players.Count-1;i++)
            {
                if(players[i].RoundScore < players[i + 1].RoundScore)
                {
                    sb.AppendLine("Player : " + (i+1) + " Has won the round");

                }
                else if(players[i].RoundScore.Equals(players[i+1].RoundScore))
                {
                    sb.AppendLine("It's a tie");

                }
                else
                {
                    sb.AppendLine("Player : " + i + " Has won the round");
                }
            }
            game.compareScores(players);
            GameOutput.Text = sb.ToString();
            roundCounter += 1;   
        }
        /// <summary>
        /// Button to press if the player wants to make a bid.
        /// </summary>
        /// <param name="sender">A sender object</param>
        /// <param name="e">An event object</param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    BluffChallange.Forms.BidForm bidForm = new BluffChallange.Forms.BidForm(players[0]);
                    bidForm.Show();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please start the round before making a bid.");
            }
        }

        /// <summary>
        ///numOfPlayer_SelectedIndexChanged - Fixes the bugg to edit to more playerss
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numOfPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
             Players = controller.letPlayersRollDices(Convert.ToInt32(numOfPlayer.Text));
        }
    }
}
