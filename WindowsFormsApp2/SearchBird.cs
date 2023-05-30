using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ComponentFactory.Krypton.Toolkit;

namespace WindowsFormsApp2
{

    public partial class SearchBird : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";

        public SearchBird()
        {
            InitializeComponent();
            dataGridView1.BackgroundColor = Color.White;
            
            // Populate the ComboBox with search criteria options
            comboBox1.Items.AddRange(new string[] { "HatchDate", "Gender", "Serial" , "Species" });
            dataGridView1.CellContentClick += dataGridView1_CellClick;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Check if the click occurred on the first column
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the bird information from the selected row
                ulong serial = Convert.ToUInt64(selectedRow.Cells["Serial"].Value);
                string species = selectedRow.Cells["Species"].Value.ToString();
                string subspecies = selectedRow.Cells["Subspecies"].Value.ToString();
                string hatchDate = selectedRow.Cells["HatchDate"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string cageNumber = selectedRow.Cells["CageNumber"].Value.ToString();
                string motherSerial = selectedRow.Cells["MotherSerial"].Value.ToString();
                string fatherSerial = selectedRow.Cells["FatherSerial"].Value.ToString();

                // Create a new instance of the BirdDetailsForm and set the bird details
                BirdDetails birdDetailsForm = new BirdDetails();
                birdDetailsForm.SetBirdDetails(serial, species, subspecies, hatchDate, gender, cageNumber, motherSerial, fatherSerial);
                birdDetailsForm.ShowDialog();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            string searchTerm = textBox1.Text.Trim();
            string searchCriteria = comboBox1.SelectedItem as string;

            if (!string.IsNullOrWhiteSpace(searchTerm) && !string.IsNullOrEmpty(searchCriteria))
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    string commandText = $"SELECT * FROM birds WHERE {searchCriteria} LIKE @searchTerm;";
                    using (OleDbCommand cmd = new OleDbCommand(commandText, con))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        using (OleDbDataAdapter adapt = new OleDbDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();

                            con.Open();
                            adapt.Fill(ds);
                            
                            if (ds.Tables.Count > 0)
                            {
                                if (ds.Tables[0].Columns.Count > 0)
                                    ds.Tables[0].Columns.RemoveAt(0);
                                dataGridView1.DataSource = ds.Tables[0];

                            }
                        }
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = null; // Clear the data source
            }
        }

       





       
    }
}
