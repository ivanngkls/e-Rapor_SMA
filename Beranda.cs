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

namespace E_Raport_SMA_Pemvis_Project
{
    public partial class Beranda : Form
    {
        private string nip;
        public Beranda(string nip)
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
                    string query = "SELECT g.nama, g.is_walikelas, k.nama_kelas FROM guru g LEFT JOIN walikelas wk ON wk.id_guru = g.id LEFT JOIN kelas k ON k.id_walikelas = wk.id WHERE nip = @nip";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nip", this.nip);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string namaGuru = reader["nama"].ToString();
                        bool isWalikelas = reader.GetBoolean("is_walikelas");
                        string namaKelas = reader["nama_kelas"].ToString();
                        if (!isWalikelas)
                        {
                            buttonKelas.Hide();
                            labelKelas.Hide();
                        }
                        else
                        {
                            labelKelas.Text = $"Kelas {namaKelas}";
                        }
                        labelSelamatDatang.Text = $"Selamat Datang\n{namaGuru}";
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

        private void buttonKelas_Click(object sender, EventArgs e)
        {
            DashboardWalikelas dashboardWaliKelas = new DashboardWalikelas(this.nip);
            this.Hide();
            dashboardWaliKelas.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void buttonNilai_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                conn.Open();

                string query = " SELECT id, nama_kelas FROM kelas";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string namaKelas = reader.GetString("nama_kelas");
                    int idKelas = reader.GetInt32("id");

                    Button btn = new Button();
                    btn.Text = namaKelas;
                    btn.Width = 90;
                    btn.Height = 30;
                    btn.Margin = new Padding(5);
                    btn.Click += (s, args) =>
                    {
                        DashboardGuru dashboardGuru = new DashboardGuru(this.nip, idKelas);
                        this.Hide();
                        dashboardGuru.Show();
                    };

                    flowLayoutPanelKelas.Controls.Add(btn);
                }

                reader.Close();
            }
        }
    }
}
