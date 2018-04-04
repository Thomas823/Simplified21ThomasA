/*
 * Created by: Thomas Aubin
 * Created on: April 2, 2018
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This prorgram is a simplified version of 21 that does not use cards but numbers from 1 - 10
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Add Sound Library
using System.Media;

namespace Simplified21ThomasA
{
    public partial class frmSimplified21 : Form
    {
        // Declare global variables, constants, and random number generator
        int[] computerCards = { 0, 0, 0 };
        int[] playerCards = { 0, 0, 0 };
        int playerSum;
        int computerSum;
        int cardLoop;

        Random randomNumberGenerator = new Random();
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;

        // Load Sounds
        SoundPlayer cheering = new SoundPlayer(Simplified21ThomasA.Properties.Resources.Cheering);
        SoundPlayer whaWha = new SoundPlayer(Simplified21ThomasA.Properties.Resources.Wha_Wha);
        SoundPlayer ooh = new SoundPlayer(Simplified21ThomasA.Properties.Resources.Ooh);

        public frmSimplified21()
        {
            InitializeComponent();

            // Call the Initializer function when the program is first started
            Initializer();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // Close the program when exit menu item is pressed
            this.Close();
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            // Call Initializer to restart game when new game pressed
            Initializer();
        }

        // One location to start game at beginning and allow for a reset any time
        public void Initializer()
        {
            // Show all start items
            lblGreeting.Show();
            btnStart.Show();

            // Hide all other items
            picPlayerCardOne.Hide();
            picPlayerCardTwo.Hide();
            picPlayerCardThree.Hide();
            picComputerCardOne.Hide();
            picComputerCardTwo.Hide();
            picComputerCardThree.Hide();
            lblStay.Hide();
            lblComputerSum.Hide();
            lblPlayerSum.Hide();
            lblComputerSum.Hide();
            lblResults.Hide();

            // Reset loop
            cardLoop = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Hide starting items and start the game!
            lblGreeting.Hide();
            btnStart.Hide();

            // Generate random cards for start
            playerCards[0] = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE);
            playerCards[1] = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            computerCards[0] = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            computerCards[1] = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            computerCards[2] = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // Set computer question mark cards
            picComputerCardOne.Image = Properties.Resources.Question_Mark;
            picComputerCardTwo.Image = Properties.Resources.Question_Mark;
            picComputerCardThree.Image = Properties.Resources.Question_Mark;
            // Set player's first card
            switch (playerCards[0])
            {
                case 1:
                    picPlayerCardOne.Image = Properties.Resources.One;
                    break;
                case 2:
                    picPlayerCardOne.Image = Properties.Resources.Two;
                    break;
                case 3:
                    picPlayerCardOne.Image = Properties.Resources.Three;
                    break;
                case 4:
                    picPlayerCardOne.Image = Properties.Resources.Four;
                    break;
                case 5:
                    picPlayerCardOne.Image = Properties.Resources.Five;
                    break;
                case 6:
                    picPlayerCardOne.Image = Properties.Resources.Six;
                    break;
                case 7:
                    picPlayerCardOne.Image = Properties.Resources.Seven;
                    break;
                case 8:
                    picPlayerCardOne.Image = Properties.Resources.Eight;
                    break;
                case 9:
                    picPlayerCardOne.Image = Properties.Resources.Nine;
                    break;
                case 10:
                    picPlayerCardOne.Image = Properties.Resources.Ten;
                    break;
            }
            // Set player's second card
            switch (playerCards[1])
            {
                case 1:
                    picPlayerCardTwo.Image = Properties.Resources.One;
                    break;
                case 2:
                    picPlayerCardTwo.Image = Properties.Resources.Two;
                    break;
                case 3:
                    picPlayerCardTwo.Image = Properties.Resources.Three;
                    break;
                case 4:
                    picPlayerCardTwo.Image = Properties.Resources.Four;
                    break;
                case 5:
                    picPlayerCardTwo.Image = Properties.Resources.Five;
                    break;
                case 6:
                    picPlayerCardTwo.Image = Properties.Resources.Six;
                    break;
                case 7:
                    picPlayerCardTwo.Image = Properties.Resources.Seven;
                    break;
                case 8:
                    picPlayerCardTwo.Image = Properties.Resources.Eight;
                    break;
                case 9:
                    picPlayerCardTwo.Image = Properties.Resources.Nine;
                    break;
                case 10:
                    picPlayerCardTwo.Image = Properties.Resources.Ten;
                    break;
            }
            // Set player's third card
            picPlayerCardThree.Image = Properties.Resources.Hit;

            // Display Cards and Stay Button
            picPlayerCardOne.Show();
            picPlayerCardTwo.Show();
            picPlayerCardThree.Show();
            picComputerCardOne.Show();
            picComputerCardTwo.Show();
            picComputerCardThree.Show();
            lblStay.Show();
        }

        private void picPlayerCardThree_Click(object sender, EventArgs e)
        {
            if (cardLoop == 0)
            {
                // Generate third card
                playerCards[2] = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

                // Set card
                switch (playerCards[2])
                {
                    case 1:
                        picPlayerCardThree.Image = Properties.Resources.One;
                        break;
                    case 2:
                        picPlayerCardThree.Image = Properties.Resources.Two;
                        break;
                    case 3:
                        picPlayerCardThree.Image = Properties.Resources.Three;
                        break;
                    case 4:
                        picPlayerCardThree.Image = Properties.Resources.Four;
                        break;
                    case 5:
                        picPlayerCardThree.Image = Properties.Resources.Five;
                        break;
                    case 6:
                        picPlayerCardThree.Image = Properties.Resources.Six;
                        break;
                    case 7:
                        picPlayerCardThree.Image = Properties.Resources.Seven;
                        break;
                    case 8:
                        picPlayerCardThree.Image = Properties.Resources.Eight;
                        break;
                    case 9:
                        picPlayerCardThree.Image = Properties.Resources.Nine;
                        break;
                    case 10:
                        picPlayerCardThree.Image = Properties.Resources.Ten;
                        break;
                }

                // Hide stay button
                lblStay.Hide();

                // Exit this loop option
                cardLoop++;

                // Continue the game
                Continue();
            }
        }

        private void lblStay_Click(object sender, EventArgs e)
        {
            // Hide stay button and player's third card
            lblStay.Hide();
            picPlayerCardThree.Hide();

            // Continue the game
            Continue();
        }

        public void Continue()
        {
            // Calculate players and computer sum
            if (playerCards[2] == 0)
            {
                playerSum = playerCards[0] + playerCards[1];
            }
            else
            {
                playerSum = playerCards[0] + playerCards[1] + playerCards[2];
            }

            computerSum = computerCards[0] + computerCards[1] + computerCards[2];

            // Display computer's cards
            switch (computerCards[0])
            {
                case 1:
                    picComputerCardOne.Image = Properties.Resources.One;
                    break;
                case 2:
                    picComputerCardOne.Image = Properties.Resources.Two;
                    break;
                case 3:
                    picComputerCardOne.Image = Properties.Resources.Three;
                    break;
                case 4:
                    picComputerCardOne.Image = Properties.Resources.Four;
                    break;
                case 5:
                    picComputerCardOne.Image = Properties.Resources.Five;
                    break;
                case 6:
                    picComputerCardOne.Image = Properties.Resources.Six;
                    break;
                case 7:
                    picComputerCardOne.Image = Properties.Resources.Seven;
                    break;
                case 8:
                    picComputerCardOne.Image = Properties.Resources.Eight;
                    break;
                case 9:
                    picComputerCardOne.Image = Properties.Resources.Nine;
                    break;
                case 10:
                    picComputerCardOne.Image = Properties.Resources.Ten;
                    break;
            }
            switch (computerCards[1])
            {
                case 1:
                    picComputerCardTwo.Image = Properties.Resources.One;
                    break;
                case 2:
                    picComputerCardTwo.Image = Properties.Resources.Two;
                    break;
                case 3:
                    picComputerCardTwo.Image = Properties.Resources.Three;
                    break;
                case 4:
                    picComputerCardTwo.Image = Properties.Resources.Four;
                    break;
                case 5:
                    picComputerCardTwo.Image = Properties.Resources.Five;
                    break;
                case 6:
                    picComputerCardTwo.Image = Properties.Resources.Six;
                    break;
                case 7:
                    picComputerCardTwo.Image = Properties.Resources.Seven;
                    break;
                case 8:
                    picComputerCardTwo.Image = Properties.Resources.Eight;
                    break;
                case 9:
                    picComputerCardTwo.Image = Properties.Resources.Nine;
                    break;
                case 10:
                    picComputerCardTwo.Image = Properties.Resources.Ten;
                    break;
            }
            switch (computerCards[2])
            {
                case 1:
                    picComputerCardThree.Image = Properties.Resources.One;
                    break;
                case 2:
                    picComputerCardThree.Image = Properties.Resources.Two;
                    break;
                case 3:
                    picComputerCardThree.Image = Properties.Resources.Three;
                    break;
                case 4:
                    picComputerCardThree.Image = Properties.Resources.Four;
                    break;
                case 5:
                    picComputerCardThree.Image = Properties.Resources.Five;
                    break;
                case 6:
                    picComputerCardThree.Image = Properties.Resources.Six;
                    break;
                case 7:
                    picComputerCardThree.Image = Properties.Resources.Seven;
                    break;
                case 8:
                    picComputerCardThree.Image = Properties.Resources.Eight;
                    break;
                case 9:
                    picComputerCardThree.Image = Properties.Resources.Nine;
                    break;
                case 10:
                    picComputerCardThree.Image = Properties.Resources.Ten;
                    break;
            }

            // Display Computer's and Person's Sum
            lblComputerSum.Text = "Computer's Score: " + computerSum;
            lblPlayerSum.Text = "Player's Score: " + playerSum;
            lblComputerSum.Show();
            lblPlayerSum.Show();

            // Find Bust, Tie, Blackjack, or who has greater
            if (playerSum > 21 && computerSum > 21)
            {
                // Both Bust and Dealer wins
                lblResults.Text = "You Both Busted! The Computer Wins!";
                ooh.Play();
            }
            else if (playerSum > 21)
            {
                // Set player to bust and computer to winner
                lblResults.Text = "The Player Busted! The Computer Wins!";
                whaWha.Play();
            }
            else if (computerSum > 21)
            {
                // Set computer to bust and player to winner
                lblResults.Text = "The Computer Busted! The Player Wins!";
                cheering.Play();
            }
            else if (playerSum == computerSum)
            {
                // Set a tie
                lblResults.Text = "It's a Tie! No One Wins!";
                ooh.Play();
            }
            else if (playerSum == 21)
            {
                // Player has blackjack!
                lblResults.Text = "The Player Got BlackJack! The Player Wins!";
                cheering.Play();
            }
            else if (computerSum == 21)
            {
                // Computer has blackjack!
                lblResults.Text = "The Computer Got BlackJack! The Computer Wins!";
                whaWha.Play();
            }
            else if (playerSum > computerSum)
            {
                // Player won!
                lblResults.Text = "The Player Got A Higher Number. The Player Wins!";
                cheering.Play();
            }
            else
            {
                // Computer won!
                lblResults.Text = "The Computer Got A Higher Number. The Computer Wins!";
                whaWha.Play();
            }

            // Display Results
            lblResults.Show();
        }
    }
}
