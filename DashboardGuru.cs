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
    public partial class DashboardGuru : Form
    {
        public DashboardGuru()
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
                    string query = "SELECT nis, nama FROM siswa";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSiswa.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error load data" + ex.Message);
                }
            }
        }
    }
}
