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

namespace WindowsFormsApp2
{
    public partial class BirdDetails : KryptonForm
    {
        public BirdDetails()
        {
            InitializeComponent();
        }
        public void SetBirdDetails(ulong serial, string species, string subspecies, string hatchDate, string gender, string cageNumber, string motherSerial, string fatherSerial)
        {
            // Set the bird details in the respective controls
            labelSerial.Text = serial.ToString();
            labelSpecies.Text = species;
            labelSubspecies.Text = subspecies;
            labelHatchDate.Text = hatchDate;
            labelGender.Text = gender;
            labelCageNumber.Text = cageNumber;
            labelMotherSerial.Text = motherSerial;
            labelFatherSerial.Text = fatherSerial;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
