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

        public SearchCage()
        {
            InitializeComponent();
            // Populate the ComboBox with search criteria options
            comboBox1.Items.AddRange(new string[] { "CageSerial", "Material" });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();
            string searchCriteria = comboBox1.SelectedItem as string;

            if (!string.IsNullOrWhiteSpace(searchTerm) && !string.IsNullOrEmpty(searchCriteria))
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    string commandText = $"SELECT * FROM Cage WHERE {searchCriteria} LIKE @searchTerm;";
                    using (OleDbCommand cmd = new OleDbCommand(commandText, con))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        using (OleDbDataAdapter adapt = new OleDbDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();

                            con.Open();
                            adapt.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = null; // Clear the data source
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


