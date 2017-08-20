namespace BluffChallange
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.numOfPlayerLabel = new System.Windows.Forms.Label();
            this.numOfPlayer = new System.Windows.Forms.ComboBox();
            this.roll = new System.Windows.Forms.Button();
            this.GameOutput = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.numOfPlayerLabel);
            this.panel.Controls.Add(this.numOfPlayer);
            this.panel.Controls.Add(this.roll);
            this.panel.Controls.Add(this.GameOutput);
            this.panel.Location = new System.Drawing.Point(-4, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(582, 334);
            this.panel.TabIndex = 0;
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
            this.roll.Text = "Role dices";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 332);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

