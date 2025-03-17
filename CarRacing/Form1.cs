using System;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int finish;
        int car1Start, car2Start, car3Start;

        int credit = 100;  // User's starting credit
        int betAmount = 0; // The amount of credit the user bets
        string chosenCar = ""; // The car the user chooses to bet on

        public Form1()
        {
            InitializeComponent();

            // Store the starting positions of the cars
            car1Start = car1.Left;
            car2Start = car2.Left;
            car3Start = car3.Left;

            // Bind events for the button and timer
            btnStart.Click += btnStart_Click;
            timerRace.Tick += timerRace_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Get the user's car selection and bet amount
            chosenCar = cmbCarSelection.SelectedItem?.ToString();
            bool validBet = int.TryParse(txtBetAmount.Text, out betAmount);

            if (string.IsNullOrEmpty(chosenCar) || !validBet || betAmount <= 0)
            {
                MessageBox.Show("Please select a valid car and enter a valid bet amount!");
                return;
            }

            if (betAmount > credit)
            {
                MessageBox.Show("You don't have enough credit! Please enter a lower bet.");
                return;
            }

            finish = finishLine.Left - 80; // Set the finish line position

            // Reset the cars to their starting positions
            car1.Left = car1Start;
            car2.Left = car2Start;
            car3.Left = car3Start;
            lblResult.Text = "";

            // Disable the start button (to prevent multiple races at the same time)
            btnStart.Enabled = false;

            // Start the timer
            timerRace.Start();
        }

        private void timerRace_Tick(object sender, EventArgs e)
        {
            // Move the cars forward with random speeds
            car1.Left += rnd.Next(5, 15);
            car2.Left += rnd.Next(5, 15);
            car3.Left += rnd.Next(5, 15);

            // Determine the winner and stop the race
            string winningCar = "";

            if (car1.Left >= finish)
            {
                winningCar = "CAR 1";
            }
            else if (car2.Left >= finish)
            {
                winningCar = "CAR 2";
            }
            else if (car3.Left >= finish)
            {
                winningCar = "CAR 3";
            }

            if (!string.IsNullOrEmpty(winningCar))
            {
                timerRace.Stop();
                lblResult.Text = $"🏁 {winningCar} WINS! 🏁";

                // Bet result
                if (winningCar == chosenCar)
                {
                    credit += betAmount; // User wins
                    MessageBox.Show($"Congratulations! You won {betAmount} credits. New credit balance: {credit}");
                }
                else
                {
                    credit -= betAmount; // User loses
                    MessageBox.Show($"Sorry, you lost! {betAmount} credits deducted. Remaining credit: {credit}");
                }

                // Check if the user wins or loses the game
                if (credit >= 1000)
                {
                    MessageBox.Show("Congratulations! You reached 1000 credits and won the game! 🎉");
                    Application.Exit();
                }
                else if (credit <= 0)
                {
                    MessageBox.Show("You ran out of credits! You lost the game. 😢");
                    Application.Exit();
                }

                lblCredit.Text = $"Credit: {credit}"; // Update credit display
                btnStart.Enabled = true;
            }
        }

        private void txtBetAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
