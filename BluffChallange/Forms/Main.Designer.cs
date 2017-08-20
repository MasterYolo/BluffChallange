namespace BluffChallange
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel = new System.Windows.Forms.Panel();
            this.makeABidButton = new System.Windows.Forms.Button();
            this.callLiesButton = new System.Windows.Forms.Button();
            this.numOfPlayerLabel = new System.Windows.Forms.Label();
            this.numOfPlayer = new System.Windows.Forms.ComboBox();
            this.roll = new System.Windows.Forms.Button();
            this.GameOutput = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.makeABidButton);
            this.panel.Controls.Add(this.callLiesButton);
            this.panel.Controls.Add(this.numOfPlayerLabel);
            this.panel.Controls.Add(this.numOfPlayer);
            this.panel.Controls.Add(this.roll);
            this.panel.Controls.Add(this.GameOutput);
            this.panel.Location = new System.Drawing.Point(-4, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(582, 334);
            this.panel.TabIndex = 0;
            // 
            // makeABidButton
            // 
            this.makeABidButton.Location = new System.Drawing.Point(98, 21);
            this.makeABidButton.Name = "makeABidButton";
            this.makeABidButton.Size = new System.Drawing.Size(75, 23);
            this.makeABidButton.TabIndex = 5;
            this.makeABidButton.Text = "Make a bid";
            this.makeABidButton.UseVisualStyleBackColor = true;
            this.makeABidButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // callLiesButton
            // 
            this.callLiesButton.Location = new System.Drawing.Point(17, 21);
            this.callLiesButton.Name = "callLiesButton";
            this.callLiesButton.Size = new System.Drawing.Size(75, 23);
            this.callLiesButton.TabIndex = 4;
            this.callLiesButton.Text = "Call lies!";
            this.callLiesButton.UseVisualStyleBackColor = true;
            // 
            // numOfPlayerLabel
            // 
            this.numOfPlayerLabel.AutoSize = true;
            this.numOfPlayerLabel.Location = new System.Drawing.Point(238, 27);
            this.numOfPlayerLabel.Name = "numOfPlayerLabel";
            this.numOfPlayerLabel.Size = new System.Drawing.Size(92, 13);
            this.numOfPlayerLabel.TabIndex = 3;
            this.numOfPlayerLabel.Text = "Number of players";
            // 
            // numOfPlayer
            // 
            this.numOfPlayer.FormattingEnabled = true;
            this.numOfPlayer.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.numOfPlayer.Location = new System.Drawing.Point(346, 24);
            this.numOfPlayer.Name = "numOfPlayer";
            this.numOfPlayer.Size = new System.Drawing.Size(121, 21);
            this.numOfPlayer.TabIndex = 2;
            this.numOfPlayer.Text = "2";
            // 
            // roll
            // 
            this.roll.Location = new System.Drawing.Point(495, 22);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(75, 23);
            this.roll.TabIndex = 1;
            this.roll.Text = "Start round";
            this.roll.UseVisualStyleBackColor = true;
            this.roll.Click += new System.EventHandler(this.roll_Click);
            // 
            // GameOutput
            // 
            this.GameOutput.Location = new System.Drawing.Point(3, 51);
            this.GameOutput.Name = "GameOutput";
            this.GameOutput.Size = new System.Drawing.Size(576, 280);
            this.GameOutput.TabIndex = 0;
            this.GameOutput.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 332);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "BluffChallange";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.RichTextBox GameOutput;
        private System.Windows.Forms.ComboBox numOfPlayer;
        private System.Windows.Forms.Label numOfPlayerLabel;
        private System.Windows.Forms.Button makeABidButton;
        private System.Windows.Forms.Button callLiesButton;
    }
}

