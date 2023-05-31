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
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class SearchCage : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
        public string userId = LogIn.getuserId();
        public SearchCage()
        {
            InitializeComponent();
            // Populate the ComboBox with search criteria options
            comboBox1.Items.AddRange(new string[] { "CageSerial", "Material" });
            dataGridView1.CellContentClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Check if the click occurred on the first column
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the bird information from the selected row
                string CageSerial = selectedRow.Cells["CageSerial"].Value.ToString();
                string Length = selectedRow.Cells["Length"].Value.ToString();
                string Width = selectedRow.Cells["Width"].Value.ToString();
                string Height = selectedRow.Cells["Height"].Value.ToString();
                string Material = selectedRow.Cells["Material"].Value.ToString();


                // Create a new instance of the BirdDetailsForm and set the bird details
                CageDetails cageDetailsForm = new CageDetails();
                cageDetailsForm.SetCageDetails(CageSerial, Length, Width, Height, Material);
                cageDetailsForm.ShowDialog();
                this.Hide();
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
                    string commandText = $"SELECT * FROM Cage WHERE UserID = @UserID AND {searchCriteria} LIKE @searchTerm;";
                    using (OleDbCommand cmd = new OleDbCommand(commandText, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        using (OleDbDataAdapter adapt = new OleDbDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();

                            con.Open();
                            adapt.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];

                            if (ds.Tables.Count > 0)
                            {
                                if (ds.Tables[0].Columns.Count > 0)
                                    ds.Tables[0].Columns.RemoveAt(0);
                                dataGridView1.DataSource = ds.Tables[0];

                            }
                            if (ds.Tables.Count > 0)
                            {
                                if (ds.Tables[0].Columns.Count > 0)
                                    ds.Tables[0].Columns.RemoveAt(5);
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


