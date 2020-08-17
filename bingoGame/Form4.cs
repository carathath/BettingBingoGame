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
    public partial class Form4 : Form
    {
        bingoLib account = new bingoLib(); //Used to copy the object sent from Form2
        public Form4(bingoLib acc)
        {
            InitializeComponent();
            account = acc; //Copies the account information

            //Fill the fields displayed with the account's information to be edited
            updtFirstTextBox.Text = acc.Fname;
            updtLastTextBox.Text = acc.Lname;
            updtUsernameTextBox.Text = acc.Username;
            updtPasswordTextBox.Text = acc.Password;
            updtCardInfoTextBox.Text = acc.CardInfo;
            updtCvvTextBox.Text = acc.Cvv;
            updtBalanceTextBox.Text = acc.Balance;
        }

        //When the user clicks on "Update Account"
        private void updateAccountButton_Click(object sender, EventArgs e)
        {
            int option;
            string message = "", title = "";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;

            //Assign all the values to the object
            account.Fname = updtFirstTextBox.Text;
            account.Lname = updtLastTextBox.Text;
            account.Username = updtUsernameTextBox.Text;
            account.Password = updtPasswordTextBox.Text;
            account.CardInfo = updtCardInfoTextBox.Text;
            account.Cvv = updtCvvTextBox.Text;
            account.Balance = updtBalanceTextBox.Text;

            //Gets flag to update account
            option = account.UpdateAccountInfo(account);

            //Returned flag for invalid name format
            if (option == 0)
            {
                message = "Names must only include letters! (Optional after name: ONE hyphen/space, followed by another name) *Check for extra whitespaces*";
                title = "Attention";
            }

            //Returned flag for invalid username/password format
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

            //Returned flag for username already found in the database
            else if (option == 4)
            {
                message = "Username already taken.";
                title = "Attention";
            }

            //Return flag for successful edit
            else if (option == 5)
            {
                message = "Account Update Successfully";
                title = "Attention";
            }

            DialogResult result = MessageBox.Show(message, title, button, icon);

            //If successful account edit, display the game board
            if (option == 5)
            {
                this.Hide();
                Form2 frm2 = new Form2(account);
                frm2.Show();
            }
        }
    }
}
