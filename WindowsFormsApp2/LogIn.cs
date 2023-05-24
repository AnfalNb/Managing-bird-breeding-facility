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
    public partial class LogIn : KryptonForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
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

            // Check if the username & password already exists in the worksheet
            for (int j = 2; j < i; j++)
            {
                if (excelWS.Cells[j, 2].Value.ToString() == username && excelWS.Cells[j, 3].Value.ToString() == password)
                {   
                    excelWB.Close();
                    excelApp.Quit();
                    new UserProfile().Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("USERNAME OR PASSWORD WRONG.");
            textBox1.Text = "";
            textBox2.Text = "";
           
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '•';
                textBox2.PasswordChar = '•';
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';
        }

        private void LogIn_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
