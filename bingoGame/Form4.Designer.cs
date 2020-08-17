namespace bingoGame
{
    partial class Form4
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
            this.updateAccountButton = new System.Windows.Forms.Button();
            this.updtBalanceTextBox = new System.Windows.Forms.TextBox();
            this.newBalanceLabel = new System.Windows.Forms.Label();
            this.updtCvvTextBox = new System.Windows.Forms.TextBox();
            this.newCvv = new System.Windows.Forms.Label();
            this.updtCardInfoTextBox = new System.Windows.Forms.TextBox();
            this.newCardInfo = new System.Windows.Forms.Label();
            this.updtLastTextBox = new System.Windows.Forms.TextBox();
            this.newLastLabel = new System.Windows.Forms.Label();
            this.updtFirstTextBox = new System.Windows.Forms.TextBox();
            this.newFirstLabel = new System.Windows.Forms.Label();
            this.updtPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.updtUsernameTextBox = new System.Windows.Forms.TextBox();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateAccountButton
            // 
            this.updateAccountButton.BackColor = System.Drawing.Color.Green;
            this.updateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateAccountButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAccountButton.ForeColor = System.Drawing.SystemColors.Window;
            this.updateAccountButton.Location = new System.Drawing.Point(164, 209);
            this.updateAccountButton.Name = "updateAccountButton";
            this.updateAccountButton.Size = new System.Drawing.Size(124, 35);
            this.updateAccountButton.TabIndex = 0;
            this.updateAccountButton.Text = "Update Account";
            this.updateAccountButton.UseVisualStyleBackColor = false;
            this.updateAccountButton.Click += new System.EventHandler(this.updateAccountButton_Click);
            // 
            // updtBalanceTextBox
            // 
            this.updtBalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtBalanceTextBox.Location = new System.Drawing.Point(283, 163);
            this.updtBalanceTextBox.Name = "updtBalanceTextBox";
            this.updtBalanceTextBox.Size = new System.Drawing.Size(57, 24);
            this.updtBalanceTextBox.TabIndex = 28;
            this.updtBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newBalanceLabel
            // 
            this.newBalanceLabel.AutoSize = true;
            this.newBalanceLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBalanceLabel.Location = new System.Drawing.Point(280, 142);
            this.newBalanceLabel.Name = "newBalanceLabel";
            this.newBalanceLabel.Size = new System.Drawing.Size(135, 17);
            this.newBalanceLabel.TabIndex = 27;
            this.newBalanceLabel.Text = "Starting Balance:";
            // 
            // updtCvvTextBox
            // 
            this.updtCvvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtCvvTextBox.Location = new System.Drawing.Point(283, 115);
            this.updtCvvTextBox.Name = "updtCvvTextBox";
            this.updtCvvTextBox.Size = new System.Drawing.Size(57, 24);
            this.updtCvvTextBox.TabIndex = 26;
            this.updtCvvTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newCvv
            // 
            this.newCvv.AutoSize = true;
            this.newCvv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCvv.Location = new System.Drawing.Point(282, 94);
            this.newCvv.Name = "newCvv";
            this.newCvv.Size = new System.Drawing.Size(44, 17);
            this.newCvv.TabIndex = 25;
            this.newCvv.Text = "CVV:";
            // 
            // updtCardInfoTextBox
            // 
            this.updtCardInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtCardInfoTextBox.Location = new System.Drawing.Point(285, 67);
            this.updtCardInfoTextBox.Name = "updtCardInfoTextBox";
            this.updtCardInfoTextBox.Size = new System.Drawing.Size(139, 24);
            this.updtCardInfoTextBox.TabIndex = 24;
            this.updtCardInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newCardInfo
            // 
            this.newCardInfo.AutoSize = true;
            this.newCardInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCardInfo.Location = new System.Drawing.Point(282, 46);
            this.newCardInfo.Name = "newCardInfo";
            this.newCardInfo.Size = new System.Drawing.Size(111, 17);
            this.newCardInfo.TabIndex = 23;
            this.newCardInfo.Text = "Card Number:";
            // 
            // updtLastTextBox
            // 
            this.updtLastTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtLastTextBox.Location = new System.Drawing.Point(110, 152);
            this.updtLastTextBox.Name = "updtLastTextBox";
            this.updtLastTextBox.Size = new System.Drawing.Size(117, 24);
            this.updtLastTextBox.TabIndex = 22;
            this.updtLastTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newLastLabel
            // 
            this.newLastLabel.AutoSize = true;
            this.newLastLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLastLabel.Location = new System.Drawing.Point(20, 152);
            this.newLastLabel.Name = "newLastLabel";
            this.newLastLabel.Size = new System.Drawing.Size(90, 17);
            this.newLastLabel.TabIndex = 21;
            this.newLastLabel.Text = "Last Name:";
            // 
            // updtFirstTextBox
            // 
            this.updtFirstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtFirstTextBox.Location = new System.Drawing.Point(110, 115);
            this.updtFirstTextBox.Name = "updtFirstTextBox";
            this.updtFirstTextBox.Size = new System.Drawing.Size(117, 24);
            this.updtFirstTextBox.TabIndex = 20;
            this.updtFirstTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newFirstLabel
            // 
            this.newFirstLabel.AutoSize = true;
            this.newFirstLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFirstLabel.Location = new System.Drawing.Point(21, 117);
            this.newFirstLabel.Name = "newFirstLabel";
            this.newFirstLabel.Size = new System.Drawing.Size(92, 17);
            this.newFirstLabel.TabIndex = 19;
            this.newFirstLabel.Text = "First Name:";
            // 
            // updtPasswordTextBox
            // 
            this.updtPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtPasswordTextBox.Location = new System.Drawing.Point(110, 78);
            this.updtPasswordTextBox.Name = "updtPasswordTextBox";
            this.updtPasswordTextBox.Size = new System.Drawing.Size(117, 24);
            this.updtPasswordTextBox.TabIndex = 18;
            this.updtPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(25, 78);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(85, 17);
            this.newPasswordLabel.TabIndex = 17;
            this.newPasswordLabel.Text = "Password:";
            // 
            // updtUsernameTextBox
            // 
            this.updtUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtUsernameTextBox.Location = new System.Drawing.Point(110, 46);
            this.updtUsernameTextBox.Name = "updtUsernameTextBox";
            this.updtUsernameTextBox.Size = new System.Drawing.Size(117, 24);
            this.updtUsernameTextBox.TabIndex = 16;
            this.updtUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsernameLabel.Location = new System.Drawing.Point(23, 46);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(88, 17);
            this.newUsernameLabel.TabIndex = 15;
            this.newUsernameLabel.Text = "Username:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 256);
            this.Controls.Add(this.updtBalanceTextBox);
            this.Controls.Add(this.newBalanceLabel);
            this.Controls.Add(this.updtCvvTextBox);
            this.Controls.Add(this.newCvv);
            this.Controls.Add(this.updtCardInfoTextBox);
            this.Controls.Add(this.newCardInfo);
            this.Controls.Add(this.updtLastTextBox);
            this.Controls.Add(this.newLastLabel);
            this.Controls.Add(this.updtFirstTextBox);
            this.Controls.Add(this.newFirstLabel);
            this.Controls.Add(this.updtPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.updtUsernameTextBox);
            this.Controls.Add(this.newUsernameLabel);
            this.Controls.Add(this.updateAccountButton);
            this.Name = "Form4";
            this.Text = "Edit Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateAccountButton;
        private System.Windows.Forms.TextBox updtBalanceTextBox;
        private System.Windows.Forms.Label newBalanceLabel;
        private System.Windows.Forms.TextBox updtCvvTextBox;
        private System.Windows.Forms.Label newCvv;
        private System.Windows.Forms.TextBox updtCardInfoTextBox;
        private System.Windows.Forms.Label newCardInfo;
        private System.Windows.Forms.TextBox updtLastTextBox;
        private System.Windows.Forms.Label newLastLabel;
        private System.Windows.Forms.TextBox updtFirstTextBox;
        private System.Windows.Forms.Label newFirstLabel;
        private System.Windows.Forms.TextBox updtPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox updtUsernameTextBox;
        private System.Windows.Forms.Label newUsernameLabel;
    }
}