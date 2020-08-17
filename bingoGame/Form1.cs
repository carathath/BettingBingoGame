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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bingoLib account = new bingoLib(); // Creates an object of the class to be used
            // Checks that there is an account with the user credentials
            account = account.GetAccount(usernameTextBox.Text, passwordTextBox.Text);

            //If the returned object has an empty username, then there was no match
            if (string.IsNullOrEmpty(account.Username))
            {
                //Display an error message
                string message = "Invalid Username or Password";
                string title = "Failed Login";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult resultone = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
            }

            // If there is a match, go on to the game board
            else if (account.Username == usernameTextBox.Text && account.Password == passwordTextBox.Text)
            {
                this.Hide();
                Form2 frm2 = new Form2(account);
                frm2.Show();
            }
        }

        // If the user desides to sign up for an account
        private void signUpButton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
