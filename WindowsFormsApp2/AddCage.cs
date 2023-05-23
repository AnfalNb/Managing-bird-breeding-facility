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
    public partial class AddCage : KryptonForm
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
        public AddCage()
        {
            InitializeComponent();
        }
        private void kryptonButton_ADD_Cage_Click(object sender, EventArgs e)
        {

            string serial = textBoxForCageSerial.Text;
            string length = textBoxForLength.Text;
            string width = textBoxForLength.Text;
            string heigth = textBoxForHeigth.Text;
            string material= kryptonComboBox_Material.SelectedItem.ToString();


            Cage cage = new Cage(serial, length, width, heigth, material);

            string query = "INSERT INTO cage (CageSerial, Length, Width, Height, Material) " +
               "VALUES (@CageSerial, @Length, @Width, @Height,  @Material)";

            List<OleDbParameter> parameters = new List<OleDbParameter>()
            {
                new OleDbParameter("@CageSerial", cage.CageSerial),
                new OleDbParameter("@Length", cage.Length),
                new OleDbParameter("@Width", cage.Width),
                new OleDbParameter("@Height", cage.Height),
                new OleDbParameter("@Material", cage.Material),
               
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
            textBoxForCageSerial.Text = string.Empty;
            kryptonComboBox_Material.SelectedIndex = -1;
            textBoxForLength.Text = string.Empty;
            textBoxForWidth.Text = string.Empty;
            textBoxForHeigth.Text = string.Empty;
        }
    }
}
