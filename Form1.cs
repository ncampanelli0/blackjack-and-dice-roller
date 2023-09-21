namespace DiceRoller
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int playerScore = 0;
        int dealerScore = 0;
        int playerScore2 = 0;
        int dealerScore2 = 0;
        int dealerLimit = 17;
        bool canDeal = true;
        string hiddenCard = "";

        string[] deck = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
        public Form1()
        {
            InitializeComponent();
        }

        private string dealCard()
        {
            Random random = new Random();
            string value = deck[random.Next(deck.Length)];
            hiddenCard = value.ToString();
            return value;

        }

        private string dealCardPlayer()
        {
            string dealtCard = dealCard();
            try
            {
                playerScore += int.Parse(dealtCard);
                playerScore2 += int.Parse(dealtCard);
            }
            catch (Exception)
            {
                if (dealtCard.Equals("J") || dealtCard.Equals("Q") || dealtCard.Equals("K"))
                {
                    playerScore += 10;
                    playerScore2 += 10;

                }

                if (dealtCard.Equals("A"))
                {
                    dealerScore += 1;
                    dealerScore2 += 11;
                }
            }
            return dealtCard;
        }

        private string dealCardDealer()
        {
            string dealtCard = dealCard();
            try
            {
                dealerScore += int.Parse(dealtCard);
                dealerScore2 += int.Parse(dealtCard);
            }
            catch (Exception)
            {
                if (dealtCard.Equals("J") || dealtCard.Equals("Q") || dealtCard.Equals("K"))
                {
                    dealerScore += 10;
                    dealerScore2 += 10;
                }

                if (dealtCard.Equals("A"))
                {
                    dealerScore += 1;
                    dealerScore2 += 11;
                }
            }

            return dealtCard;
        }

        private void checkResult()
        {
            if (canDeal)
            {
                if (playerScore > 21 && playerScore2 > 21)
                {
                    lblBJResults.Text = "PLAYER BUST";
                    lblBJResults.Visible = true;
                    canDeal = false;
                }
                else if (playerScore == dealerScore && playerScore2 == dealerScore2)
                {
                    lblBJResults.Text = "DEALER AND PLAYER SCORES ARE EQUAL, DEALER WINS";
                    lblBJResults.Visible = true;
                    canDeal = false;
                }
                else if (playerScore == 21 || playerScore2 == 21)
                {
                    lblBJResults.Text = "PLAYER IS AT 21";
                    lblBJResults.Visible = true;
                    canDeal = false;
                }
                else if (dealerScore == 21 || dealerScore2 == 21)
                {
                    lblBJResults.Text = "DEALER IS AT 21";
                    lblBJResults.Visible = true;
                    canDeal = false;
                }
                else if (dealerScore >= 22 && dealerScore2 >= 22)
                {
                    lblBJResults.Text = "DEALER BUST";
                    lblBJResults.Visible = true;
                    canDeal = false;
                }


            }
            if (canDeal == false)
            {
                lblHiddenCard.Visible = true;
                lblHiddenCard.Text += hiddenCard;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            string dealer1 = dealCardDealer();
            string dealer2 = dealCardDealer();
            lblBJDealer.Text = $"Dealer: ? {dealer2}";
            lblBJPlayer.Text = $"Player: {dealCardPlayer()} {dealCardPlayer()}";

            string randomCard = deck[random.Next(deck.Length)];
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int diceAmount = Convert.ToInt32(numDiceAmount.Value);
            int diceSide = Convert.ToInt32(numDiceSide.Value);

            for (int i = 0; i < diceAmount; i++)
            {
                counter++;
                txtOutput.AppendText("Dice roll " + counter + ": ");
                txtOutput.AppendText(random.Next(1, diceSide + 1).ToString());
                txtOutput.AppendText(Environment.NewLine);
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (canDeal)
            {
                lblBJPlayer.Text = $"{lblBJPlayer.Text} {dealCardPlayer()}";
                //lblBJDealer.Text = $"{lblBJDealer.Text} {dealCardDealer()}";
                checkResult();
            }


        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (canDeal)
            {
                canDeal = false;
                while (dealerScore < dealerLimit)
                {
                    lblBJDealer.Text = $"{lblBJDealer.Text} {dealCardDealer()}";
                }

                if (playerScore > dealerScore)
                {
                    lblBJResults.Text = "Player wins";
                }
                else
                {
                    lblBJResults.Text = "Dealer wins";
                }

                lblBJResults.Visible = true;

                lblHiddenCard.Text += hiddenCard;
                lblHiddenCard.Visible = true;
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            dealerScore = 0;
            canDeal = true;
            hiddenCard = dealCardDealer();
            lblBJDealer.Text = $"Dealer: ? {dealCardDealer()}";
            lblBJPlayer.Text = $"Player: {dealCardPlayer()} {dealCardPlayer()}";
            lblBJResults.Visible = false;
            lblBJResults.Text = "Result";
            lblHiddenCard.Visible = false;
            lblHiddenCard.Text = "Hidden Card: ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}