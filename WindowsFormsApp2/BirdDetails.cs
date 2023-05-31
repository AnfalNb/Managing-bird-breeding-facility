using ComponentFactory.Krypton.Toolkit;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BirdDetails : KryptonForm
    {
        public BirdDetails()
        {
            InitializeComponent();
            textBoxFordetailsSerial.Enabled = false;
            textBoxforspeciesdetails.Enabled = false;
            textBoxforsubspeciesdetails.Enabled = false;
            textBoxForhanchdatethdetails.Enabled = false;
            textBoxForgenderdetails.Enabled = false;
            textBoxForcagenumberdetails.Enabled = false;
            textBoxmserialdetails.Enabled = false;
            textBoxfserialdetails.Enabled = false;
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

        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
