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

namespace bingoGame
{
    public partial class Form3 : Form
    {
        bingoLib newAccount = new bingoLib(); //Used to store the values from the user sign up
        public Form3()
        {
            InitializeComponent();
        }

        //When the user clicks "Create Account"
        private void newAccountButton_Click(object sender, EventArgs e)
        {
            //Store all the fields information to the object
            newAccount.Username = newUsernameTextBox.Text;
            newAccount.Password = newPasswordTextBox.Text;
            newAccount.Fname = newFirstTextBox.Text;
            newAccount.Lname = newLastTextBox.Text;
            newAccount.CardInfo = newCardInfoTextBox.Text;
            newAccount.Cvv = newCvvTextBox.Text;
            newAccount.Balance = newBalanceTextBox.Text;

            //Check that the information is in correct format
            int option = newAccount.AddAccount(newAccount);
            string message="", title = "";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            //Returned flag for incorrect name format
            if (option == 0)
            {
                message = "Names must only include letters! (Optional after name: ONE hyphen/space, followed by another name) *Check for extra whitespaces*";
                title = "Attention";
            }

            //Returned flag for incorrect username/password format
            else if (option == 1)
            {
                message = "Username and Password can not contain spaces!";
                title = "Attention";
            }

            //Returned flag for invalid card information length
            else if (option == 2)
            {
                message = "Card Number should be 16-digits long";
                title = "Attention";
            }

            //Returned flag for invalid CVV length
            else if (option == 3)
            {
                message = "CVV number should be 3-digits long";
                title = "Attention";
            }

            //Returned flag for username found in the database
            else if(option == 4)
            {
                message = "Username already taken";
                title = "Attention";
            }

            //Returned flag if the starting balance is higher than 1200
            else if(option == 5)
            {
                message = "Starting Balance can not exceed $1000";
                title = "Attention";
            }

            //Returned success flag
            else if (option == 6)
            {
                message = "Account Created Successfully";
                title = "Attention";
            }

            //Display the messgage
            DialogResult result = MessageBox.Show(message, title, button, icon);

            //If successful addition to the database, display the game board
            if (option == 6)
            {
                this.Hide();
                Form2 frm2 = new Form2(newAccount);
                frm2.Show();
            }

        }
    }
}
