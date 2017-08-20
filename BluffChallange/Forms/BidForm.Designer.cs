namespace BluffChallange.Forms
{
    partial class BidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numOfDicesLabel = new System.Windows.Forms.Label();
            this.bidButton = new System.Windows.Forms.Button();
            this.numOfDices = new System.Windows.Forms.ComboBox();
            this.valueOfDice = new System.Windows.Forms.ComboBox();
            this.valueOfDiceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.valueOfDiceLabel);
            this.panel1.Controls.Add(this.valueOfDice);
            this.panel1.Controls.Add(this.numOfDicesLabel);
            this.panel1.Controls.Add(this.bidButton);
            this.panel1.Controls.Add(this.numOfDices);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 87);
            this.panel1.TabIndex = 0;
            // 
            // numOfDicesLabel
            // 
            this.numOfDicesLabel.AutoSize = true;
            this.numOfDicesLabel.Location = new System.Drawing.Point(-3, 15);
            this.numOfDicesLabel.Name = "numOfDicesLabel";
            this.numOfDicesLabel.Size = new System.Drawing.Size(84, 13);
            this.numOfDicesLabel.TabIndex = 2;
            this.numOfDicesLabel.Text = "Number of dices";
            // 
            // bidButton
            // 
            this.bidButton.Location = new System.Drawing.Point(78, 53);
            this.bidButton.Name = "bidButton";
            this.bidButton.Size = new System.Drawing.Size(75, 23);
            this.bidButton.TabIndex = 1;
            this.bidButton.Text = "Bid";
            this.bidButton.UseVisualStyleBackColor = true;
            this.bidButton.Click += new System.EventHandler(this.bidButton_Click);
            // 
            // numOfDices
            // 
            this.numOfDices.FormattingEnabled = true;
            this.numOfDices.Location = new System.Drawing.Point(87, 12);
            this.numOfDices.Name = "numOfDices";
            this.numOfDices.Size = new System.Drawing.Size(41, 21);
            this.numOfDices.TabIndex = 0;
            // 
            // valueOfDice
            // 
            this.valueOfDice.FormattingEnabled = true;
            this.valueOfDice.Location = new System.Drawing.Point(196, 12);
            this.valueOfDice.Name = "valueOfDice";
            this.valueOfDice.Size = new System.Drawing.Size(39, 21);
            this.valueOfDice.TabIndex = 3;
            this.valueOfDice.Items.AddRange(new object[] {"1",
            "2",
            "3",
            "4",
            "5",
            "star"});
            // 
            // valueOfDiceLabel
            // 
            this.valueOfDiceLabel.AutoSize = true;
            this.valueOfDiceLabel.Location = new System.Drawing.Point(155, 15);
            this.valueOfDiceLabel.Name = "valueOfDiceLabel";
            this.valueOfDiceLabel.Size = new System.Drawing.Size(34, 13);
            this.valueOfDiceLabel.TabIndex = 4;
            this.valueOfDiceLabel.Text = "Value";
            // 
            // BidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 88);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BidForm";
            this.Text = "Bids";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bidButton;
        private System.Windows.Forms.ComboBox numOfDices;
        private System.Windows.Forms.Label numOfDicesLabel;
        private System.Windows.Forms.Label valueOfDiceLabel;
        private System.Windows.Forms.ComboBox valueOfDice;
    }
}