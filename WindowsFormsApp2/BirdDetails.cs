using ComponentFactory.Krypton.Toolkit;
using Microsoft.Office.Interop.Excel;
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
    public partial class BirdDetails : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
        public BirdDetails()
        {
            InitializeComponent();

            textBoxforspeciesdetails.Enabled = false;
            textBoxforsubspeciesdetails.Enabled = false;
            textBoxForhanchdatethdetails.Enabled = false;
            textBoxForgenderdetails.Enabled = false;
            textBoxmserialdetails.Enabled = false;
            textBoxfserialdetails.Enabled = false;
            textBoxFordetailsSerial.Enabled = false;
        }
        
        public void SetBirdDetails(ulong serial, string species, string subspecies, string hatchDate, string gender, string cageNumber, string motherSerial, string fatherSerial)
        {
            // Set the bird details in the respective controls
            textBoxFordetailsSerial.Text = serial.ToString();
            textBoxforspeciesdetails.Text = species;
            textBoxforsubspeciesdetails.Text = subspecies;
            textBoxForhanchdatethdetails.Text = hatchDate;
            textBoxForgenderdetails.Text = gender;
            textBoxForcagenumberdetails.Text = cageNumber;
            textBoxmserialdetails.Text = motherSerial;
            textBoxfserialdetails.Text = fatherSerial;
        }



        private void kryptonButton1_page_add_fledgling_Click(object sender, EventArgs e)
        {

            AddFledglings addFledglingForm = new AddFledglings();

            // Get the parent bird's details from the labels in the BirdDetails form
            string species = textBoxforspeciesdetails.Text;
            string subspecies = textBoxforsubspeciesdetails.Text;
            string cageNumber = textBoxForcagenumberdetails.Text;
            string parentgender = textBoxForgenderdetails.Text;
            string serialparent = textBoxFordetailsSerial.Text;


            // Set the parent bird's details in the Add Fledgling form
            addFledglingForm.SetParentBirdDetails(species, subspecies, cageNumber, parentgender, serialparent);
            addFledglingForm.ShowDialog();
            this.Hide();

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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            SearchBird SearchBirdForm = new SearchBird();

            // Show the current form
            SearchBirdForm.Show();

            // Optionally, hide the previous form
            this.Hide();
        }
        private void UpdateBirdDetailsInDatabase(ulong serial, string cageNumber)
        {
            string query = "UPDATE birds " +
                           "SET CageNumber = @CageNumber " +
                           "WHERE Serial = @Serial";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CageNumber", cageNumber);
                    command.Parameters.AddWithValue("@Serial", serial);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        private void kryptonButtonupdate_Click(object sender, EventArgs e)
        {

            ulong serial = Convert.ToUInt64(textBoxFordetailsSerial.Text);
            string cageNumber = textBoxForcagenumberdetails.Text;

            // Call the method to update the database with the new details
            UpdateBirdDetailsInDatabase(serial, cageNumber);

            // Optionally, update the text boxes with the new values
            textBoxFordetailsSerial.Text = serial.ToString();
            textBoxForcagenumberdetails.Text = cageNumber;

            MessageBox.Show("Bird details updated successfully.");
        }
    }

}
