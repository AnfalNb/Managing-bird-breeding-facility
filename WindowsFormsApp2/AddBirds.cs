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

namespace WindowsFormsApp2
{
    public partial class AddBirds : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";

        public AddBirds()
        {
            InitializeComponent();
        }

        private void kryptonButton_ADD_BIRD_Click(object sender, EventArgs e)
        {
            string serial = textBoxForSerial.Text;
            string species = kryptonComboBox_species.SelectedItem.ToString();
            string subspecies = kryptonComboBox_sup_species.SelectedItem.ToString();
            DateTime hatchdate = kryptonDateTimePicker_hatch_date.Value.Date;
            string gender = kryptonComboBox_gender.SelectedItem.ToString();
            string cagenumber = textBoxForCageNumber.Text;
            string motherserial = textBoxForMotherSerial.Text;
            string fatherserial = textBoxForFatherSerial.Text;

            Bird bird = new Bird(serial, species, subspecies, hatchdate, gender, cagenumber, motherserial, fatherserial);

            string query = "INSERT INTO birds (Serial, Species, Subspecies, HatchDate, Gender, CageNumber, MotherSerial, FatherSerial) " +
               "VALUES (@Serial, @Species, @Subspecies, @HatchDate, @Gender, @CageNumber, @MotherSerial, @FatherSerial)";

            List<OleDbParameter> parameters = new List<OleDbParameter>()
            {
                new OleDbParameter("@Serial", bird.Serial),
                new OleDbParameter("@Species", bird.species),
                new OleDbParameter("@Subspecies", bird.subspecies),
                new OleDbParameter("@HatchDate", bird.hatch_date),
                new OleDbParameter("@Gender", bird.gender),
                new OleDbParameter("@CageNumber", bird.cage_number),
                new OleDbParameter("@MotherSerial", bird.Mother_serial),
                new OleDbParameter("@FatherSerial", bird.Father_serial)
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
            textBoxForSerial.Text = string.Empty;
            kryptonComboBox_species.SelectedIndex = -1;
            kryptonComboBox_sup_species.SelectedIndex = -1;
            kryptonDateTimePicker_hatch_date.Value = DateTime.Now;
            kryptonComboBox_gender.SelectedIndex = -1;
            textBoxForCageNumber.Text = string.Empty;
            textBoxForMotherSerial.Text = string.Empty;
            textBoxForFatherSerial.Text = string.Empty;
        }
   
    }
      
}
