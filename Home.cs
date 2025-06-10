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

namespace E_Raport_SMA
{
    public partial class Home : Form
    {
        private string nip;
        public Home(string nip)
        {
            InitializeComponent();
            this.nip = nip;
            LoadData();

        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nama, is_walikelas FROM guru WHERE nip = @nip";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nip", this.nip);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string namaGuru = reader["nama"].ToString();
                        bool isWalikelas = reader.GetBoolean("is_walikelas");
                        if (!isWalikelas)
                        {
                            kelasButton.Hide();
                        }
                        welcomeLabel.Text += $"\n {namaGuru}";
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show("Gagal mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void inputNilaiButton_Click(object sender, EventArgs e)
        {
            DashboardGuru dashboardGuru = new DashboardGuru(this.nip);
            this.Hide();
            dashboardGuru.Show();
        }

        private void kelasButton_Click(object sender, EventArgs e)
        {
            DashboardWaliKelas dashboardWaliKelas = new DashboardWaliKelas(this.nip);
            this.Hide();
            dashboardWaliKelas.Show();
        }
    }
}
