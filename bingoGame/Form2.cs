using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bingoLibrary;
using System.Text.RegularExpressions;

namespace bingoGame
{
    public partial class Form2 : Form
    {
        bingoLib account = new bingoLib(); // Used to copy the object sent from Form1
        int row1 = 0, row2 = 0, row3 = 1, row4 = 0, row5 = 0; //Keeps track of the matching values in each row
        int col1 = 0, col2 = 0, col3 = 1, col4 = 0, col5 = 0; //Keeps track of the matching values in each column
        int rowBingo = 0, colBingo = 0; //Gets flag from the library's CheckBingo function
        int betMultiplier = 2; //If the user wins, they get a multiplier to their bet

        // In the end game, if the user decides not to play again and clicks "Exit", close the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //If the user decides to "Play Again", show a new game board form
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2(account);
            frm2.Show();
        }

        // When the user signs in or successfully logs in, it calls Form2
        public Form2(bingoLib acc)
        {
            InitializeComponent();
            account = acc; // Copy the object received, containing all the account information

            nameLabel.Text = account.Fname + " " + account.Lname; //Dsiplay the account's name
            balanceLabel.Text = "$" + account.Balance; // Displays the account's balance
        }

        //If the user clicks on the "How to Play" button on the top right, a message box is displayed
        private void instructionButton_Click(object sender, EventArgs e)
        {
            string message = "1) Input the amount you want to bet *ONLY whole numbers*\n(Ex. 10, 25, 52)";
            message += "\n*DO NOT BET MORE THAN YOUR BALANCE*\n";
            message += "\n\n2)Use the buttons to select the amount of moves you want\n";
            message += "MINIMUM AMOUNT: 5, MAXIMUM AMOUNT: 150\n\n";
            message += "*If you want to EDIT your account, do so before clicking \"Begin\"*\n\n";
            message += "3) Click \"Begin\" to start the game\n\n";
            message += "4) Click \"Next\" to go on to the next play\n\n";
            message += "Enjoy!";
            string title = "How To Play";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult resulttwo = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        // Display Form4, used to edit account information
        private void upAccInfo_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(account);
            frm4.Show();
        }

        // When the user begins the game
        private void startGameButton_Click(object sender, EventArgs e)
        {
            string message = "", title = "";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            var regex = new Regex(@"^[1-9]([0-9]+)$");
            int check = 0, bet = 0;

            //If the user inputs a non-whole number as their bet amount
            if (!regex.IsMatch(betAmountTextBox.Text))
            {
                message = "Bet amount must be a whole number or greather than/equal to 10";
                title = "Attention";
                DialogResult res = MessageBox.Show(message, title, button, icon);
                check = 1;
            }

            //If the bet amount is a whole number, check if it exceeds the account balance
            else if (check == 0)
            {
                bet = Convert.ToInt32(betAmountTextBox.Text); // Convert the bet amount to an int
                //Check that it does not exceed the accounts balance
                if (bet > Convert.ToInt32(account.Balance))
                {
                    //Display error message
                    message = "Invalid Bet Amount!";
                    title = "Attention";
                    DialogResult result = MessageBox.Show(message, title, button, icon);
                    check = 1;
                }
            }

            //If everything is okay, fill the board
            if (check == 0)
            {
                betAmountTextBox.Enabled = false; // Disable the bet amount edit
                moveAmountNumberBox.Enabled = false; //Disable the move amount edit
                startGameButton.Enabled = false; //Disable the "Begin" button
                upAccInfo.Enabled = false; //Disable the "Edit Account" button
                //Display the amount of moves on the right box
                movesLeftTextBox.Text = Convert.ToString(moveAmountNumberBox.Value);
                int size = 24;
                string[] board = new string[size]; // Array that will receive the values of the library's FillBoard function
                board = account.FillBoard(); //Copies the values of the returned array

                //Manually assign the values stored in the array to its respective locations
                B1.Text = board[0]; B2.Text = board[1];B3.Text = board[2];B4.Text = board[3];B5.Text = board[4];
                I1.Text = board[5];I2.Text = board[6];I3.Text = board[7];I4.Text = board[8];I5.Text = board[9];
                N1.Text = board[10];N2.Text = board[11];N4.Text = board[12];N5.Text = board[13];
                G1.Text = board[14];G2.Text = board[15];G3.Text = board[16];G4.Text = board[17];G5.Text = board[18];
                O1.Text = board[19];O2.Text = board[20];O3.Text = board[21];O4.Text = board[22];O5.Text = board[23];
            }
        }

        //When the user clicks "Next Play"
        private void nextPlayButton_Click(object sender, EventArgs e)
        {
            string ballPlayed; //Used to store value returned from the library's GetPlay function

            if (movesLeftTextBox.Text != "0") //If the amount of moves left is not 0
            {
                ballPlayed = account.GetPlay(); //Get the play from the library
                currentPlayShow.Text = ballPlayed; //Show that play in the "Current Play" section
                //Stores the value of only the numbers returned from GetPlay
                string value = Convert.ToString(ballPlayed[1]) + Convert.ToString(ballPlayed[2]);

                //Subtract the amount of moves left by 1
                movesLeftTextBox.Text = Convert.ToString(Convert.ToInt32(movesLeftTextBox.Text) - 1);

                //If the first char of the returned string is B
                if (ballPlayed[0] == 'B')
                {
                    // Check each box of the B column for a match
                    // If there is a match, change its font and background color if it has not been matched before
                    if (B1.Text == value && B1.ForeColor != Color.White)
                    {
                        B1.BackColor = Color.LimeGreen;
                        B1.ForeColor = Color.White;
                        row1++; col1++; //Add on to the row and column counters
                    }

                    if (B2.Text == value && B2.ForeColor != Color.White)
                    {
                        B2.BackColor = Color.LimeGreen;
                        B2.ForeColor = Color.White;
                        row2++; col1++;
                    }

                    if (B3.Text == value && B3.ForeColor != Color.White)
                    {
                        B3.BackColor = Color.LimeGreen;
                        B3.ForeColor = Color.White;
                        row3++; col1++;
                    }

                    if (B4.Text == value && B4.ForeColor != Color.White)
                    {
                        B4.BackColor = Color.LimeGreen;
                        B4.ForeColor = Color.White;
                        row4++; col1++;
                    }

                    if (B5.Text == value && B5.ForeColor != Color.White)
                    {
                        B5.BackColor = Color.LimeGreen;
                        B5.ForeColor = Color.White;
                        row5++; col1++;
                    }

                }

                //If the first char of the returned string is C
                if (ballPlayed[0] == 'I')
                {
                    if (I1.Text == value && I1.ForeColor != Color.White)
                    {
                        I1.BackColor = Color.LimeGreen;
                        I1.ForeColor = Color.White;
                        row1++; col2++;
                    }

                    if (I2.Text == value && I2.ForeColor != Color.White)
                    {
                        I2.BackColor = Color.LimeGreen;
                        I2.ForeColor = Color.White;
                        row2++; col2++;
                    }

                    if (I3.Text == value && I3.ForeColor != Color.White)
                    {
                        I3.BackColor = Color.LimeGreen;
                        I3.ForeColor = Color.White;
                        row3++; col2++;
                    }

                    if (I4.Text == value && I4.ForeColor != Color.White)
                    {
                        I4.BackColor = Color.LimeGreen;
                        I4.ForeColor = Color.White;
                        row4++; col2++;
                    }

                    if (I5.Text == value && I5.ForeColor != Color.White)
                    {
                        I5.BackColor = Color.LimeGreen;
                        I5.ForeColor = Color.White;
                        row5++; col2++;
                    }
                }

                //If the first char of the returned string is N
                if (ballPlayed[0] == 'N')
                {
                    if (N1.Text == value && N1.ForeColor != Color.White)
                    {
                        N1.BackColor = Color.LimeGreen;
                        N1.ForeColor = Color.White;
                        row1++; col3++;
                    }

                    if (N2.Text == value && N2.ForeColor != Color.White)
                    {
                        N2.BackColor = Color.LimeGreen;
                        N2.ForeColor = Color.White;
                        row2++; col3++;
                    }

                    if (N4.Text == value && N4.ForeColor != Color.White)
                    {
                        N4.BackColor = Color.LimeGreen;
                        N4.ForeColor = Color.White;
                        row4++; col3++;
                    }

                    if (N5.Text == value && N5.ForeColor != Color.White)
                    {
                        N5.BackColor = Color.LimeGreen;
                        N5.ForeColor = Color.White;
                        row5++; col3++;
                    }
                }

                //If the first char of the returned string is G
                if (ballPlayed[0] == 'G')
                {
                    if (G1.Text == value && G1.ForeColor != Color.White)
                    {
                        G1.BackColor = Color.LimeGreen;
                        G1.ForeColor = Color.White;
                        row1++; col4++;
                    }

                    if (G2.Text == value && G2.ForeColor != Color.White)
                    {
                        G2.BackColor = Color.LimeGreen;
                        G2.ForeColor = Color.White;
                        row2++; col4++;
                    }

                    if (G3.Text == value && G3.ForeColor != Color.White)
                    {
                        G3.BackColor = Color.LimeGreen;
                        G3.ForeColor = Color.White;
                        row3++; col4++;
                    }

                    if (G4.Text == value && G4.ForeColor != Color.White)
                    {
                        G4.BackColor = Color.LimeGreen;
                        G4.ForeColor = Color.White;
                        row4++; col4++;
                    }

                    if (G5.Text == value && G5.ForeColor != Color.White)
                    {
                        G5.BackColor = Color.LimeGreen;
                        G5.ForeColor = Color.White;
                        row5++; col4++;
                    }
                }

                //If the first char of the returned string is O
                if (ballPlayed[0] == 'O')
                {
                    if (O1.Text == value && O1.ForeColor != Color.White)
                    {
                        O1.BackColor = Color.LimeGreen;
                        O1.ForeColor = Color.White;
                        row1++; col5++;
                    }

                    if (O2.Text == value && O2.ForeColor != Color.White)
                    {
                        O2.BackColor = Color.LimeGreen;
                        O2.ForeColor = Color.White;
                        row2++; col5++;
                    }

                    if (O3.Text == value && O3.ForeColor != Color.White)
                    {
                        O3.BackColor = Color.LimeGreen;
                        O3.ForeColor = Color.White;
                        row3++; col5++;
                    }

                    if (O4.Text == value && O4.ForeColor != Color.White)
                    {
                        O4.BackColor = Color.LimeGreen;
                        O4.ForeColor = Color.White;
                        row4++; col5++;
                    }

                    if (O5.Text == value && O5.ForeColor != Color.White)
                    {
                        O5.BackColor = Color.LimeGreen;
                        O5.ForeColor = Color.White;
                        row5++; col5++;
                    }
                }

                rowBingo = account.CheckBingo(row1, row2, row3, row4, row5); //Check bingo for all the rows
                colBingo = account.CheckBingo(col1, col2, col3, col4, col5); //Check bingo for all the columns

                //If the library's CheckBingo function returns a 1, end the game
                if(rowBingo == 1 || colBingo == 1)
                {
                    //Message box
                    string message = "BINGO! Congratulations!";
                    string title = "Winner Winner";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                    //Used to edit the users balance
                    int newBal = 0, betAmount = Convert.ToInt32(betAmountTextBox.Text);
                    //Used for the multiplier calculation
                    int moveAmount = Convert.ToInt32(moveAmountNumberBox.Value);

                    //Edits the multiplier value depending on the move amount the user chose
                    if (moveAmount >= 5 && moveAmount <= 20)
                        betMultiplier = 5;
                    else if (moveAmount >= 21 && moveAmount <= 60)
                        betMultiplier = 4;
                    else if (moveAmount >= 61 && moveAmount <= 100)
                        betMultiplier = 3;

                    //New account balance is equal to its current value + the multiplied bet amount
                    newBal = Convert.ToInt32(account.Balance) + (betAmount * betMultiplier);
                    account.Balance = Convert.ToString(newBal); //Assign that value to the accounts balance
                    account.UpdateBalance(account); //Update the accounts balance in the database
                    balanceLabel.Text = "$" + account.Balance; //Display the new balance on the board

                    DialogResult result = MessageBox.Show(message, title, button, icon); //Display the messago box
                    nextPlayButton.Enabled = false; //Disable the "Next Play" button
                    playAgainButton.Visible = true; //Display the "Play Again" button
                    exitButton.Visible = true; //Display the "Exit" button
                }
            }

            //If the user runs out of moves
            else if (movesLeftTextBox.Text == "0")
            {
                //Message box
                DialogResult result = MessageBox.Show("Out of Moves!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                int newBal;

                //Subtract the amount the user bet from their balance
                newBal = Convert.ToInt32(account.Balance) - Convert.ToInt32(betAmountTextBox.Text);
                account.Balance = Convert.ToString(newBal); //That value becomes their new balance
                account.UpdateBalance(account); //Update their balance in the database
                balanceLabel.Text = "$" + account.Balance; //Display their new balance
                nextPlayButton.Enabled = false; //Disable the "Next Play" button
                playAgainButton.Visible = true; //Display the "Play Again" button
                exitButton.Visible = true; //Display the "Exit" button
            }
        }
    }
}
