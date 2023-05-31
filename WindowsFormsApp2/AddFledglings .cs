using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Controls;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Windows;


namespace WindowsFormsApp2
{
    public partial class AddFledglings : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";

        public string userId = LogIn.getuserId();
        public AddFledglings()
        {
            InitializeComponent();
            textBoxspeciesfledgling.Enabled = false;
            textBoxsubspeciesfledgling.Enabled = false;
            textBoxForCageNumberfledgling.Enabled = false;
          

        }
        public void SetParentBirdDetails(string species, string subspecies, string cageNumber, string parentgender, string serialparent)
        {
            // Set the parent bird's details in the respective controls of the AddFledglingForm
            textBoxspeciesfledgling.Text = species;
            textBoxsubspeciesfledgling.Text = subspecies;
            textBoxForCageNumberfledgling.Text = cageNumber;
            if (parentgender == "Male") { 
                textBoxForMotherSerial.Text = serialparent;
                textBoxForMotherSerial.Enabled = false;
            }
            if (parentgender == "Female") { 
                textBoxForFatherSerial.Text = serialparent;
                textBoxForFatherSerial.Enabled = false;
            }
            //labelMotherSerial.Text = motherSerial;
            //labelFatherSerial.Text = fatherSerial;
            //if (labelGender.Text == "Female") { string fatherSerial = labelFatherSerial.Text; }
            //if (labelGender.Text == "Male") { string motherSerial = labelMotherSerial.Text; }
        }

        private void kryptonButton_ADD_fledgling_Click(object sender, EventArgs e)
        {
 
            bool SerialcontainsOnlyDigits = Regex.IsMatch(textBoxForSerialfledgling.Text, @"^[0-9]+$");
            if (!(textBoxForSerialfledgling.Text == ""))
            {
                if (SerialcontainsOnlyDigits)
                {

                    ulong serial = Convert.ToUInt64(textBoxForSerialfledgling.Text.ToString());
                    string hatchdate = kryptonDateTimePicker_hatch_datefledgling.Value.Date.ToString("dd-MM-yyyy");
                    string gender = kryptonComboBox_genderfledgling.SelectedItem.ToString();
                    string motherserial = textBoxForMotherSerial.Text;
                    string fatherserial = textBoxForFatherSerial.Text;
                    string UserID = userId;

                    Bird bird = new Bird(serial, textBoxspeciesfledgling.Text, textBoxsubspeciesfledgling.Text, hatchdate, gender, textBoxForCageNumberfledgling.Text, motherserial, fatherserial);

                    string query = "INSERT INTO birds (Serial, Species, Subspecies, HatchDate, Gender, CageNumber, MotherSerial, FatherSerial,UserID) " +
                       "VALUES (@Serial, @Species, @Subspecies, @HatchDate, @Gender, @CageNumber, @MotherSerial, @FatherSerial,@UserID)";
                    if (userId != null)
                    {
                        List<OleDbParameter> parameters = new List<OleDbParameter>()
                    {
                        new OleDbParameter("@Serial", bird.Serial.ToString()),
                        new OleDbParameter("@Species", bird.species.ToString()),
                        new OleDbParameter("@Subspecies", bird.subspecies.ToString()),
                        new OleDbParameter("@HatchDate", bird.hatch_date),
                        new OleDbParameter("@Gender", bird.gender),
                        new OleDbParameter("@CageNumber", bird.cage_number),
                        new OleDbParameter("@MotherSerial", bird.Mother_serial),
                        new OleDbParameter("@FatherSerial", bird.Father_serial),
                        new OleDbParameter("@UserID", UserID)
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
                    System.Windows.Forms.MessageBox.Show("The Fledglings has been successfully added.");
                    textBoxForSerialfledgling.Text = string.Empty;
                    textBoxsubspeciesfledgling.Text = string.Empty;
                    textBoxsubspeciesfledgling.Text = string.Empty;
                    kryptonDateTimePicker_hatch_datefledgling.Value = DateTime.Now;
                    kryptonComboBox_genderfledgling.SelectedIndex = -1;
                    textBoxForCageNumberfledgling.Text = string.Empty;
                    textBoxForMotherSerial.Text = string.Empty;
                    textBoxForFatherSerial.Text = string.Empty;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Invalid serial bird number, It should contain both numbers and letters.");
                    textBoxForSerialfledgling.Focus();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Some fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
