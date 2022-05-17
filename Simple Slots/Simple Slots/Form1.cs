namespace Simple_Slots
{
    public partial class Form1 : Form
    {
        public slotsGame slotMachine; //The slot machine object. Only needs to be created oncec per program startup as it can be re-used
        public Form1()
        {
            InitializeComponent();
            slotMachine = new slotsGame();
            slotMachine.addSlotValue(new slotsValue("Apple", "A", 0.4, 0.45));
            slotMachine.addSlotValue(new slotsValue("Banana", "B", 0.6, 0.35));
            slotMachine.addSlotValue(new slotsValue("Pineapple", "P", 0.4, 0.15));
            slotMachine.addSlotValue(new slotsValue("Wildcard", "*", 0, 0.05));
            slotMachine.setSlotProbabilities(); //will create the distribution used for rng calls based on the probabilities passed in slotValues
        }
        /// <summary>
        /// Sets the moneyCount value for slotMachine to the value in the Depost Number Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depositButton_Click(object sender, EventArgs e)
        {
            slotMachine.setDeposit(Convert.ToDouble(despositNumberBox.Text));
            depositButton.Enabled = false;
            spinSlotsButton.Enabled = true;
            updateMoneyCount();
        }
        /// <summary>
        /// Updates the moneyLabel with the current money count and adds validity to ensure no negative balance
        /// </summary>
        private void updateMoneyCount()
        {
            double money = slotMachine.money;
            if (money < 1)
            {
                depositButton.Enabled = true;
                spinSlotsButton.Enabled = false;
                spinTextLabel.Text = "Please deposit more money to continue!";
            }
            moneyLabel.Text = "£" + String.Format("{0:.00}", money);
        }
        /// <summary>
        /// Spins the slot machine. Creates a slotSpin object to collect slot readouts and winnings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spinSlotsButton_Click(object sender, EventArgs e)
        {
            //validate wager, make sure you have enough money
            double wager = Convert.ToDouble(wagerNumberBox.Text);
            if (wager == 0)
            {
                spinTextLabel.Text = "You need to wager money to Spin!";
                return;
            }
            if (wager > slotMachine.money)
            {
                spinTextLabel.Text = "You don't have enough money to wager that much!";
                return;
            }
            //Spin the machine. Create a Spin, spin it and read the symbols and winnings then spin again for each row
            double winnings = 0;
            slotView.Items.Clear();
            slotSpin newSpin = new slotSpin(slotMachine.slotValues, slotMachine.SlotThresholds,slotMachine.SlotWidth);
            for (int i = 0; i<slotMachine.SlotHeight; i++)
            {
                newSpin.spin(wager);
                slotView.Items.Add(newSpin.SpinLine);
                winnings += newSpin.SpinWinnings;
            }
            //update money with wager and winnings
            slotMachine.wagerMoney(wager);
            slotMachine.addWinnings(winnings);
            if (winnings > 0)
            {
                spinTextLabel.Text = "You've won £" + String.Format("{0:.00}", winnings) + "!";
            }
            else
            {
                spinTextLabel.Text = "No matches this time.";
            }
            //update the label with money count
            updateMoneyCount();
        }
    }
}