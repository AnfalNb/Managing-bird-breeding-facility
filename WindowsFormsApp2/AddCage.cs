using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public string userId = LogIn.getuserId();

        private void kryptonButton_ADD_Cage_Click(object sender, EventArgs e)
        {
            bool lengthcontainsOnlyDigits = Regex.IsMatch(textBoxForLength.Text, @"^[0-9]+$");
            bool widthcontainsOnlyDigits = Regex.IsMatch(textBoxForWidth.Text, @"^[0-9]+$");
            bool heigthcontainsOnlyDigits = Regex.IsMatch(textBoxForHeigth.Text, @"^[0-9]+$");
            if (!(textBoxForCageSerial.Text == "" && textBoxForHeigth.Text == "" && textBoxForLength.Text == "" && textBoxForWidth.Text == ""))
            {
                if (ContainsDigitsAndLetters(textBoxForCageSerial.Text))
                {
                    if (lengthcontainsOnlyDigits&& widthcontainsOnlyDigits&& heigthcontainsOnlyDigits) {
                        string serial = textBoxForCageSerial.Text;
                        double length = Convert.ToDouble(textBoxForLength.Text.ToString());
                        double width = Convert.ToDouble(textBoxForWidth.Text.ToString());
                        double heigth = Convert.ToDouble(textBoxForHeigth.Text.ToString());
                        string material = kryptonComboBox_Material.SelectedItem.ToString();
                        string UserID = userId;


                        Cage cage = new Cage(serial, length, width, heigth, material);

                        string query = "INSERT INTO cage (CageSerial, Length, Width, Height, Material,UserID) " +
                           "VALUES (@CageSerial, @Length, @Width, @Height,@Material,@UserID)";
                        if (userId != null)
                        {

                            List<OleDbParameter> parameters = new List<OleDbParameter>()
                            {
                            new OleDbParameter("@CageSerial", cage.CageSerial.ToString()),
                            new OleDbParameter("@Length", cage.Length.ToString()),
                            new OleDbParameter("@Width", cage.Width.ToString()),
                            new OleDbParameter("@Height", cage.Height.ToString()),
                            new OleDbParameter("@Material", cage.Material.ToString()),
                            new OleDbParameter("@UserID", UserID.ToString()),

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
                        }
                       MessageBox.Show("The CAGE has been successfully added.");
                        textBoxForCageSerial.Text = string.Empty;
                        kryptonComboBox_Material.SelectedIndex = -1;
                        textBoxForLength.Text = string.Empty;
                        textBoxForWidth.Text = string.Empty;
                        textBoxForHeigth.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Invalid length,width,heigth. It should contain both numbers .");
                        textBoxForLength.Focus();
                        textBoxForWidth.Focus();
                        textBoxForHeigth.Focus();
                    }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            UserProfile UserProfileForm = new UserProfile();

            // Show the current form
            UserProfileForm.Show();

            // Optionally, hide the previous form
            this.Hide();
        }
    }
}
