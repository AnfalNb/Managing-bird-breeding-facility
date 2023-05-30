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
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp2
{
    public partial class LogIn : KryptonForm
    {
        private string usersExcelFilePath = @"C:\Users\אדם אלנבארי\Documents\GitHub\Managing-bird-breeding-facility\database1.xlsx";



        public static string userId;
        public LogIn()
        {
            InitializeComponent();
            userId = "None";
        }
        public static string getuserId (){ return userId; }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Authenticate user from Excel file
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWB = excelApp.Workbooks.Open(usersExcelFilePath);
            Excel._Worksheet excelWS = excelWB.ActiveSheet;

            int lastRow = excelWS.Cells[excelWS.Rows.Count, 2].End(Excel.XlDirection.xlUp).Row;



            for (int i = 2; i <= lastRow; i++)
            {
                if (excelWS.Cells[i, 2].Value.ToString() == username && excelWS.Cells[i, 3].Value.ToString() == password)
                {
                    userId = excelWS.Cells[i, 1].Value.ToString();
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



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';
        }

     
    }
}
