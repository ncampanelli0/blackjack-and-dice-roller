namespace DiceRoller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numDiceSide = new NumericUpDown();
            numDiceAmount = new NumericUpDown();
            txtOutput = new TextBox();
            btnRoll = new Button();
            lblDiceAmount = new Label();
            lblDiceSide = new Label();
            btnHit = new Button();
            btnStand = new Button();
            lblBJDealer = new Label();
            lblBJPlayer = new Label();
            lblBJResults = new Label();
            btnReset = new Button();
            lblHiddenCard = new Label();
            ((System.ComponentModel.ISupportInitialize)numDiceSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiceAmount).BeginInit();
            SuspendLayout();
            // 
            // numDiceSide
            // 
            numDiceSide.Location = new Point(124, 32);
            numDiceSide.Name = "numDiceSide";
            numDiceSide.Size = new Size(150, 27);
            numDiceSide.TabIndex = 0;
            numDiceSide.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // numDiceAmount
            // 
            numDiceAmount.Location = new Point(124, 65);
            numDiceAmount.Name = "numDiceAmount";
            numDiceAmount.Size = new Size(150, 27);
            numDiceAmount.TabIndex = 1;
            numDiceAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.Black;
            txtOutput.ForeColor = Color.White;
            txtOutput.Location = new Point(280, 18);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(481, 420);
            txtOutput.TabIndex = 2;
            // 
            // btnRoll
            // 
            btnRoll.BackColor = Color.DodgerBlue;
            btnRoll.Location = new Point(22, 98);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(252, 29);
            btnRoll.TabIndex = 3;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = false;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblDiceAmount
            // 
            lblDiceAmount.AutoSize = true;
            lblDiceAmount.ForeColor = Color.White;
            lblDiceAmount.Location = new Point(22, 67);
            lblDiceAmount.Name = "lblDiceAmount";
            lblDiceAmount.Size = new Size(96, 20);
            lblDiceAmount.TabIndex = 4;
            lblDiceAmount.Text = "Dice Amount";
            // 
            // lblDiceSide
            // 
            lblDiceSide.AutoSize = true;
            lblDiceSide.ForeColor = Color.White;
            lblDiceSide.Location = new Point(46, 39);
            lblDiceSide.Name = "lblDiceSide";
            lblDiceSide.Size = new Size(72, 20);
            lblDiceSide.TabIndex = 5;
            lblDiceSide.Text = "Dice Side";
            // 
            // btnHit
            // 
            btnHit.BackColor = Color.DodgerBlue;
            btnHit.Location = new Point(22, 356);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(94, 29);
            btnHit.TabIndex = 6;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = false;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.BackColor = Color.DodgerBlue;
            btnStand.Location = new Point(122, 356);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(94, 29);
            btnStand.TabIndex = 7;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = false;
            btnStand.Click += btnStand_Click;
            // 
            // lblBJDealer
            // 
            lblBJDealer.AutoSize = true;
            lblBJDealer.ForeColor = Color.White;
            lblBJDealer.Location = new Point(22, 258);
            lblBJDealer.Name = "lblBJDealer";
            lblBJDealer.Size = new Size(60, 20);
            lblBJDealer.TabIndex = 8;
            lblBJDealer.Text = "Dealer: ";
            // 
            // lblBJPlayer
            // 
            lblBJPlayer.AutoSize = true;
            lblBJPlayer.ForeColor = Color.White;
            lblBJPlayer.Location = new Point(22, 290);
            lblBJPlayer.Name = "lblBJPlayer";
            lblBJPlayer.Size = new Size(56, 20);
            lblBJPlayer.TabIndex = 9;
            lblBJPlayer.Text = "Player: ";
            // 
            // lblBJResults
            // 
            lblBJResults.AutoSize = true;
            lblBJResults.Location = new Point(92, 388);
            lblBJResults.Name = "lblBJResults";
            lblBJResults.Size = new Size(49, 20);
            lblBJResults.TabIndex = 10;
            lblBJResults.Text = "Result";
            lblBJResults.Visible = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DodgerBlue;
            btnReset.Location = new Point(69, 321);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblHiddenCard
            // 
            lblHiddenCard.AutoSize = true;
            lblHiddenCard.Location = new Point(75, 418);
            lblHiddenCard.Name = "lblHiddenCard";
            lblHiddenCard.Size = new Size(100, 20);
            lblHiddenCard.TabIndex = 13;
            lblHiddenCard.Text = "Hidden Card: ";
            lblHiddenCard.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(777, 450);
            Controls.Add(lblHiddenCard);
            Controls.Add(btnReset);
            Controls.Add(lblBJResults);
            Controls.Add(lblBJPlayer);
            Controls.Add(lblBJDealer);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(lblDiceSide);
            Controls.Add(lblDiceAmount);
            Controls.Add(btnRoll);
            Controls.Add(txtOutput);
            Controls.Add(numDiceAmount);
            Controls.Add(numDiceSide);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Blackjack and Dice Roller";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numDiceSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiceAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numDiceSide;
        private NumericUpDown numDiceAmount;
        private TextBox txtOutput;
        private Button btnRoll;
        private Label lblDiceAmount;
        private Label lblDiceSide;
        private Button btnHit;
        private Button btnStand;
        private Label lblBJDealer;
        private Label lblBJPlayer;
        private Label lblBJResults;
        private Button btnReset;
        private Label lblHiddenCard;
    }
}