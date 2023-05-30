using ComponentFactory.Krypton.Toolkit;
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
    public partial class UserProfile : KryptonForm
    {
        public int LoggedInUserID {  get; set; }
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
        public UserProfile()
        {
            InitializeComponent();
            //LoggedInUserID = loggedInUserID;
            LoadUserBirds();

        }
        public string userId = LogIn.getuserId();

        private void LoadUserBirds()
        {
            // Clear existing items in the ListView
            listView1.Items.Clear();

            // Retrieve the user's birds from the database
            string query = "SELECT * FROM birds WHERE UserID = @UserID";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        // Loop through the retrieved rows and add them to the ListView
                        while (reader.Read())
                        {
                            string serial = reader["Serial"].ToString();
                            string species = reader["Species"].ToString();
                            string subspecies = reader["Subspecies"].ToString();
                            string hatchDate = reader["HatchDate"].ToString();
                            string gender = reader["Gender"].ToString();
                            string cageNumber = reader["CageNumber"].ToString();
                            string motherSerial = reader["MotherSerial"].ToString();
                            string fatherSerial = reader["FatherSerial"].ToString();

                            ListViewItem item = new ListViewItem(new[]
                            {
                                serial,
                                species,
                                subspecies,
                                hatchDate,
                                gender,
                                cageNumber,
                                motherSerial,
                                fatherSerial
                            });

                            listView1.Items.Add(item);
                        }
                    }
                }
                connection.Close();
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
            AddBirds otherForm = new AddBirds(this);
            otherForm.Show();
        }

        private void kryptonButton_page_search_cage_Click(object sender, EventArgs e)
        {
            new SearchCage().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = userId;
        }
    }
}
