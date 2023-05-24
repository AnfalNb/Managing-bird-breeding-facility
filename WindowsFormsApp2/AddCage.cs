using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddCage : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
        public AddCage()
        {
            InitializeComponent();
        }
        private void kryptonButton_ADD_Cage_Click(object sender, EventArgs e)
        {

            if (!(textBoxForCageSerial.Text == "" && textBoxForHeigth.Text == "" && textBoxForLength.Text == "" && textBoxForWidth.Text == ""))
            {
                if (ContainsDigitsAndLetters(textBoxForCageSerial.Text))
                {
                    string serial = textBoxForCageSerial.Text;
                    double length = Convert.ToDouble(textBoxForLength.Text.ToString());
                    double width = Convert.ToDouble(textBoxForLength.Text.ToString());
                    double heigth = Convert.ToDouble(textBoxForHeigth.Text.ToString());
                    string material = kryptonComboBox_Material.SelectedItem.ToString();


                    Cage cage = new Cage(serial, length, width, heigth, material);

                    string query = "INSERT INTO cage (CageSerial, Length, Width, Height, Material) " +
                       "VALUES (@CageSerial, @Length, @Width, @Height,@Material)";

                    List<OleDbParameter> parameters = new List<OleDbParameter>()
                    {
                            new OleDbParameter("@CageSerial", cage.CageSerial.ToString()),
                            new OleDbParameter("@Length", cage.Length.ToString()),
                            new OleDbParameter("@Width", cage.Width.ToString()),
                            new OleDbParameter("@Height", cage.Height.ToString()),
                            new OleDbParameter("@Material", cage.Material.ToString()),
                    };

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddRange(parameters.ToArray());
                            command.ExecuteNonQuery();

                        }
                        connection.Close();

                    }
                    textBoxForCageSerial.Text = string.Empty;
                    kryptonComboBox_Material.SelectedIndex = -1;
                    textBoxForLength.Text = string.Empty;
                    textBoxForWidth.Text = string.Empty;
                    textBoxForHeigth.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Invalid serial number. It should contain both numbers and letters.");
                    textBoxForCageSerial.Focus();
                }
            }
            else
            {
                MessageBox.Show("Some fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ContainsDigitsAndLetters(string text)
        {
            bool containsDigits = text.Any(char.IsDigit);
            bool containsLetters = text.Any(char.IsLetter);

            return containsDigits && containsLetters;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
