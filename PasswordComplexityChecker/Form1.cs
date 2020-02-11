using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordComplexityChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
           //converts txtPassword input into a string, checks its length
            string PasswordString = Convert.ToString(txtPassword.Text);
            int passwordLength = PasswordString.Length;

            if (passwordLength <= 8)
            {
                txtStrengthResult.Text = "Password is too weak";
            }
            if (passwordLength > 8 && passwordLength < 15)
            {
                txtStrengthResult.Text = "Password is acceptable";
            }
            if (passwordLength >= 15)
            {
                txtStrengthResult.Text = "Password is good";
            }
            //resets txtPassword to check another password
            txtPassword.Text = "";
        }
    }
}
