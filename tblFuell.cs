using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationTemplate2
{
    public partial class tblFuell : Form
    {
        public tblFuell()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private string connectionString = "Server=localhost;Database=gstation;Integrated Security=True;";

        private void tblFuelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDescription = kryptonComboBox1.SelectedItem.ToString();
        }
        private void LoadFuelDescriptions()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT descriptionFuel FROM tblFuel";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            kryptonComboBox1.Items.Add(reader["descriptionFuel"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void tblFuell_Load(object sender, EventArgs e)
        {
            LoadFuelDescriptions();
        }
    }
}
