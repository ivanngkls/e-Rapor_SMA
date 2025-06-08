using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Raport_SMA
{
    public partial class InputNilai : Form
    {
        public InputNilai()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM siswa";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                    }
                }
                catch
                {

                }
            }
        }
    }
}
