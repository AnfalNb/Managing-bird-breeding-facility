using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserProfile : KryptonForm
    {
       
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
        public string username = LogIn.getusername();
        public string userId = LogIn.getuserId();
        public UserProfile()
        {
            InitializeComponent();

            labelusername.Text = username;
            
        }
        private void listView_birds_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView listView = (ListView)sender;
           
            // Check if the click occurred on the desired column
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                ulong serial = Convert.ToUInt64( selectedItem.SubItems[e.Column].Text);
                string species = selectedItem.SubItems[1].Text.ToString();
                string subspecies = selectedItem.SubItems[2].Text.ToString();
                string hatchDate = selectedItem.SubItems[3].Text.ToString();
                string gender = selectedItem.SubItems[4].Text.ToString();
                string cageNumber = selectedItem.SubItems[5].Text.ToString();
                string motherSerial = selectedItem.SubItems[6].Text.ToString();
                string fatherSerial = selectedItem.SubItems[7].Text.ToString();
                // Create a new instance of the destination form/page
                 BirdDetails birdDetailsForm = new BirdDetails();
                birdDetailsForm.SetBirdDetails(serial, species, subspecies, hatchDate, gender, cageNumber, motherSerial, fatherSerial);
                birdDetailsForm.ShowDialog();
            }
        }

        
        private void kryptonButton_search_bird_Click(object sender, EventArgs e)
        {
            new SearchBird().Show();
            this.Hide();
        }
        private void kryptonButton2_page_addcage_Click(object sender, EventArgs e)
        {
            new AddCage().Show();
            this.Hide();
        }

        private void kryptonButton1_page_add_bird_Click(object sender, EventArgs e)
        {
            new AddBirds().Show();
            this.Hide();
        }

        private void kryptonButton_page_search_cage_Click(object sender, EventArgs e)
        {
            new SearchCage().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();

            // Close the current form
            this.Close();
        }
    }
}
