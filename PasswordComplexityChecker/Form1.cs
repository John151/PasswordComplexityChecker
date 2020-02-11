using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            bool passwordLengthCheck = false;
            int complexity = 0;
            int passwordLength = PasswordString.Length;

            passwordLengthCheck = lengthMethod(passwordLengthCheck, passwordLength);
            complexity = complexityMethod(PasswordString, complexity);


            if (passwordLengthCheck && complexity > 2)
            {
                txtStrengthResult.Text = "Password is good";
            }
            if (passwordLengthCheck && complexity <= 2)
            {
                txtStrengthResult.Text = "Password is not complex enough";
            }
            else
            {
                txtStrengthResult.Text = "Password is not long enough";
            }
            /*used to check if this part was working
             * if (passwordLengthCheck == true) {
                txtStrengthResult.Text = "Password is long enough";
            }*/

            //resets txtPassword to check another password
            //txtPassword.Text = "";
        }

        private static int complexityMethod(string PasswordString, int complexity)
        {
            // tried regex as found here https://stackoverflow.com/questions/12899876/checking-strings-for-a-strong-enough-password
            //I couldn't get this part working :(
            
            if (Regex.Match(PasswordString, @"/[a-z]/.aspx").Success == true)
            {
                complexity++;
            }
            if (Regex.Match(PasswordString, @"/[A-Z]/.aspx").Success == true)
            {
                complexity++;
            }
            if (Regex.Match(PasswordString, @"/[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/.aspx").Success == true)
            {
                complexity++;
            }
            if (Regex.Match(PasswordString, @"/[0-9]/.aspx").Success == true)
            {
                complexity++;
            }
            return complexity;
        }

        private static bool lengthMethod(bool passwordLengthCheck, int passwordLength)
        {
            if (passwordLength >= 15)
            {
                passwordLengthCheck = true;
            }

            return passwordLengthCheck;
        }
    }
}
/* artifact 
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
*/
