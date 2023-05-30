using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{
    public partial class SignUp : KryptonForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string id_number = textBox0.Text;
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirm_password = textBox3.Text;
            if (textBox0.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Check ID number requirements
            if (id_number.Length != 9 || !Int32.TryParse(id_number, out int id_num))
            {
                MessageBox.Show("ID number must be 9 digits long and contain only numbers!");
                return;
            }
            // Check username requirements
            if (username.Length < 6 || username.Length > 8)
            {
                MessageBox.Show("Username must be between 6-8 characters long!");
                return;
            }
            int num_count = 0;
            foreach (char c in username)
            {
                if (Char.IsDigit(c))
                {
                    num_count++;
                }
                else if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Username can only contain letters and up to 2 digits!");
                    return;
                }
            }
            if (num_count > 2)
            {
                MessageBox.Show("Username can only contain up to 2 digits!");
                return;
            }

            // Check password requirements
            if (password.Length < 8 || password.Length > 10)
            {
                MessageBox.Show("Password must be between 8-10 characters long!");
                return;
            }
            bool has_letter = false;
            bool has_number = false;
            bool has_special = false;
            foreach (char c in password)
            {
                if (Char.IsLetter(c))
                {
                    has_letter = true;
                }
                else if (Char.IsDigit(c))
                {
                    has_number = true;
                }
                else if (c == '!' || c == '#' || c == '$')
                {
                    has_special = true;
                }
            }
            if (!has_letter || !has_number || !has_special)
            {
                MessageBox.Show("Password must contain at least one letter, one number, and one special character (!,#,$)!");
                return;
            }



            // Create an instance of the Excel Application object
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWB = excelApp.Workbooks.Open(@"C:\Users\enasa\OneDrive\שולחן העבודה\The Project\Managing-bird-breeding-facility\database1.xlsx");
            Excel._Worksheet excelWS = excelWB.ActiveSheet;

            // Find the next empty row in the worksheet
            int i = 2;
            while (excelWS.Cells[i, 1].Value != null)
            {
                i++;
            }

            // Check if the username already exists in the worksheet
            for (int j = 2; j < i; j++)
            {
                if (excelWS.Cells[j, 2].Value.ToString() == username)
                {
                    MessageBox.Show("Username already exists!");
                    excelWB.Close();
                    excelApp.Quit();
                    return;
                }
            }
            // Check if the username already exists in the worksheet
            for (int j = 2; j < i; j++)
            {
                if (excelWS.Cells[j, 1].Value.ToString() == id_number)
                {
                    MessageBox.Show("This ID already exists!");
                    excelWB.Close();
                    excelApp.Quit();
                    return;
                }
            }

            // Check if the password and confirm password match
            if (password != confirm_password)
            {
                MessageBox.Show("Passwords do not match!");
                excelWB.Close();
                excelApp.Quit();
                return;
            }

            if (textBox2.Text.Contains(" "))
            {
                MessageBox.Show("The field contains an empty space.");
                return;
            }
            if (textBox3.Text.Contains(" "))
            {
                MessageBox.Show("The field contains an empty space.");
                return;
            }


            // Add the new user to the worksheet
            excelWS.Cells[i, 1] = id_number;
            excelWS.Cells[i, 2] = username;
            excelWS.Cells[i, 3] = password;



            // Save the workbook and close the Excel application
            excelWB.Save();
            excelWB.Close();
            excelApp.Quit();

            MessageBox.Show("Sign-up successful!");
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '•';
                textBox3.PasswordChar = '•';
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '•';

        }
    }
}
