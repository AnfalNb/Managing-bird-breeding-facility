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

    public partial class Form2 : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";

        public Form2()
        {
            InitializeComponent();
            // Populate the ComboBox with search criteria options
            comboBox1.Items.AddRange(new string[] { "HatchDate", "Gender", "Serial" , "Species" });
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string searchTerm = textBox1.Text.Trim();

            //if (!string.IsNullOrWhiteSpace(searchTerm))
            //{
            //    using (OleDbConnection con = new OleDbConnection(connectionString))
            //    {
            //        string commandText = "SELECT * FROM birds WHERE Gender LIKE @searchTerm;";
            //        using (OleDbCommand cmd = new OleDbCommand(commandText, con))
            //        {
            //            cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

            //            using (OleDbDataAdapter adapt = new OleDbDataAdapter(cmd))
            //            {
            //                DataSet ds = new DataSet();

            //                con.Open();
            //                adapt.Fill(ds);
            //                dataGridView1.DataSource = ds.Tables[0];
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView1.DataSource = null; // Clear the data source
            //}


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

       





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
