using SamsSimpleSupportRequest.Utilties;
using System;
using System.Windows.Forms;

namespace SamsSimpleSupportRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameChrCountLbl.Text = StringUtilities.CountChars(nameTextBox.Text) + " / " + nameTextBox.MaxLength + " characters";
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailChrCountLbl.Text = StringUtilities.CountChars(emailTextBox.Text) + " / " + emailTextBox.MaxLength + " characters";
        }

        private void problemTextBox_TextChanged(object sender, EventArgs e)
        {
            problemChrCountLbl.Text = StringUtilities.CountChars(problemTextBox.Text) + " / " + problemTextBox.MaxLength + " characters";
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(problemTextBox.Text) || !RegexUtilities.IsValidEmail(emailTextBox.Text))
            {
                int errorIndex = 1;
                string errorString = string.Empty;
                if (string.IsNullOrEmpty(nameTextBox.Text)) { errorString += errorIndex + ". Please enter your first and last name in the box next to \"Your Name\".\n"; errorIndex++; }
                if (string.IsNullOrEmpty(emailTextBox.Text)) { errorString += errorIndex + ". Please enter your preferred email address in the box next to \"Your Email\".\n"; errorIndex++; }
                if (string.IsNullOrEmpty(problemTextBox.Text)) { errorString += errorIndex + ". Please describe your problem in the box next to \"Your Problem\".\n"; errorIndex++; }
                if (!RegexUtilities.IsValidEmail(problemTextBox.Text)) { errorString += errorIndex + ". The provided email address is invalid.\n"; errorIndex++; }
                MessageBox.Show("One or more form section has not been filled out correctly, see below.\n\n" + errorString, "Form Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EmailUtility.SendRequest(emailTextBox.Text, nameTextBox.Text, problemTextBox.Text);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
