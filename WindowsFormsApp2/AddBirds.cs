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
    public partial class AddBirds : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
        public string userId = LogIn.getuserId();
        public AddBirds()
        {
            InitializeComponent();

           
        }
  

        private void kryptonButton_ADD_BIRD_Click(object sender, EventArgs e)
        {
    
            bool SerialcontainsOnlyDigits = Regex.IsMatch(textBoxForSerial.Text, @"^[0-9]+$");
            if (!(textBoxForSerial.Text == "" && kryptonComboBox_gender.SelectedIndex != -1 && textBoxForCageNumber.Text == "" && textBoxForMotherSerial.Text == "" && textBoxForFatherSerial.Text == ""))
            {
                if (SerialcontainsOnlyDigits)
                {


                    if (IsCageNumberExists(textBoxForCageNumber.Text))
                    {
                        if (!IsCageInUse(textBoxForCageNumber.Text))
                        {
                            ulong serial = Convert.ToUInt64(textBoxForSerial.Text.ToString());
                            string species = kryptonComboBox_species.SelectedItem.ToString();
                            string subspecies = kryptonComboBox_sup_species.SelectedItem.ToString();
                            string hatchdate = kryptonDateTimePicker_hatch_date.Value.Date.ToString("dd-MM-yyyy");
                            string gender = kryptonComboBox_gender.SelectedItem.ToString();
                            string cagenumber = textBoxForCageNumber.Text;
                            string motherserial = textBoxForMotherSerial.Text;
                            string fatherserial = textBoxForFatherSerial.Text;
                            string UserID = userId;

                            Bird bird = new Bird(serial, species, subspecies, hatchdate, gender, cagenumber, motherserial, fatherserial);

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

                            textBoxForSerial.Text = string.Empty;
                            kryptonComboBox_species.SelectedIndex = -1;
                            kryptonComboBox_sup_species.SelectedIndex = -1;
                            kryptonDateTimePicker_hatch_date.Value = DateTime.Now;
                            kryptonComboBox_gender.SelectedIndex = -1;
                            textBoxForCageNumber.Text = string.Empty;
                            textBoxForMotherSerial.Text = string.Empty;
                            textBoxForFatherSerial.Text = string.Empty;

                            System.Windows.Forms.MessageBox.Show("The BIRD has been successfully added.");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("The cage is already in use by another bird. Please go to the 'Add Cage' page to add a new cage.");
                            textBoxForCageNumber.Focus();
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("The cage number not exists in the cage table.Please go to the 'Add Cage' page to add a new cage.");
                        textBoxForCageNumber.Focus();
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Invalid serial bird number, It should contain both numbers and letters.");
                    textBoxForSerial.Focus();
                }
            }
            else
            {
              System.Windows.Forms.MessageBox.Show("Some fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void kryptonComboBox_species_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Clear the items in the second combobox
            kryptonComboBox_sup_species.Items.Clear();
            if (kryptonComboBox_species.SelectedItem != null)
            {
                // Get the selected species from the first combobox
                string selectedSpecies = kryptonComboBox_species.SelectedItem.ToString();
                // Set the items in the second combobox based on the selected species
                switch (selectedSpecies)
                {
                    case "European Gouldian":
                        kryptonComboBox_sup_species.Items.Add("East Europe");
                        kryptonComboBox_sup_species.Items.Add("Western Europe");
                        kryptonComboBox_sup_species.Items.Add("Central Europe");
                        break;
                    case "American Gouldian":
                        kryptonComboBox_sup_species.Items.Add("North America");
                        kryptonComboBox_sup_species.Items.Add("Central America");
                        kryptonComboBox_sup_species.Items.Add("South America");
                        break;
                    case "Australian Gouldian":
                        kryptonComboBox_sup_species.Items.Add("Central Australia");
                        kryptonComboBox_sup_species.Items.Add("Coastal Cities");
                        break;
                    default:
                        break;
                }
            }
        }
        private bool IsCageInUse(string cageNumber)
        {
            string query = "SELECT COUNT(*) FROM birds WHERE CageNumber = @CageNumber";
            int count = 0;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CageNumber", cageNumber);
                    count = (int)command.ExecuteScalar();
                }

                connection.Close();
            }

            return count > 0;
        }

        private bool IsCageNumberExists(string cageNumber)
        {
            string query = "SELECT COUNT(*) FROM cage WHERE CageSerial = @CageSerial";
            int count = 0;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CageSerial", cageNumber);
                    count = (int)command.ExecuteScalar();
                }

                connection.Close();
            }

            return count > 0;
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
