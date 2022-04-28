using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentalCar_GUI
{
    public partial class Form1 : Form
    {
        List<Auto> auto = new List<Auto>();
        MySqlCommand sql = null;
        MySqlConnection connection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beolvasas();
        }

        private void beolvasas()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Database = "rentalcar";
            sb.UserID = "root";
            sb.Password = "";
            sb.CharacterSet = "utf8";

            connection = new MySqlConnection(sb.ConnectionString);
            sql = connection.CreateCommand();
            try
            {
                connection.Open();
                sql.CommandText = "SELECT `id`, `rendszam`, `marka`, `model`, `ar` FROM `auto` WHERE 1";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Auto uj = new Auto(dr.GetInt32("ar"), dr.GetInt32("id"), dr.GetString("marka"), dr.GetString("model"), dr.GetString("rendszam"));
                        int id = dr.GetInt32("id");
                        comboBox_Auto.Items.Add(uj);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void comboBox_Auto_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
