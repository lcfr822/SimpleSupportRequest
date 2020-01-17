using SamsSimpleSupportRequest.Utilties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
