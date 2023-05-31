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
using System.Windows.Media.Media3D;

namespace WindowsFormsApp2
{
    public partial class CageDetails : KryptonForm
    {
        public CageDetails()
        {
            InitializeComponent();
            textBoxFordetailsCageSerial.Enabled = false;
            textBoxForLengthdetails.Enabled = false;
            textBoxForWidthdetails.Enabled = false;
            textBoxForHeigthdetails.Enabled = false;
            textBoxmaterialdetails.Enabled = false;
        }
        public void SetCageDetails(string CageSerial, string Length, string Width, string Height, string Material)
        {
            // Set the bird details in the respective controls
            textBoxFordetailsCageSerial.Text = CageSerial.ToString();
            textBoxForLengthdetails.Text = Length;
            textBoxForWidthdetails.Text = Width;
            textBoxForHeigthdetails.Text = Height;
            textBoxmaterialdetails.Text = Material;
           
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

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchCage SearchCageForm = new SearchCage();

            // Show the current form
            SearchCageForm.Show();

            // Optionally, hide the previous form
            this.Hide();
        }
    }
}
//