using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Raport_SMA
{
    public partial class DashboardWaliKelas : Form
    {
        private string nip;

        int pageSize = 5;
        int currentPage = 1;
        int totalPages = 1;
        int totalRecords = 0;
        public DashboardWaliKelas(String nip)
        {
            InitializeComponent();
            this.nip = nip;
            Load_DataSiswa();
        }

        private void Load_DataSiswa()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
                {
                    conn.Open();
                    string getIdQuery = @"
                                        SELECT wk.id 
                                        FROM walikelas wk
                                        JOIN guru g ON g.id = wk.id_guru
                                        WHERE g.nip = @nip";
                    MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);
                    getIdCmd.Parameters.AddWithValue("@nip", this.nip);
                    object result = getIdCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Guru ini tidak ditemukan", "Akses Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idWaliKelas = Convert.ToInt32(result);

                    string countQuery = "SELECT COUNT(*) FROM siswa WHERE id_walikelas = @id";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    countCmd.Parameters.AddWithValue("@id", idWaliKelas);
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (currentPage > totalPages) currentPage = totalPages;
                    if (currentPage < 1) currentPage = 1;

                    int offset = (currentPage - 1) * pageSize;


                    string query = @"SELECT s.nis, s.nama, s.alamat, ROUND(AVG(n.nilai_angka), 2) as 'nilai' FROM siswa s LEFT JOIN raport r ON s.id = r.id_siswa LEFT JOIN nilai n ON n.id_raport = r.id WHERE s.id_walikelas = @id GROUP BY s.id ORDER BY s.id DESC LIMIT @limit OFFSET @offset";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@limit", pageSize);
                    cmd.Parameters.AddWithValue("@id", idWaliKelas);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataSiswa.DataSource = dt;
                    pageInfoLabel.Text = $"Halaman {currentPage} dari {totalPages}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data siswa: " + ex, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                Load_DataSiswa();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                Load_DataSiswa();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home(this.nip);
            this.Hide();
            home.Show();
        }

        private void addSiswa_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
                {
                    conn.Open();
                    string getIdQuery = @"SELECT wk.id FROM walikelas wk JOIN guru g ON g.id = wk.id_guru WHERE g.nip = @nip";
                    MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);
                    getIdCmd.Parameters.AddWithValue("@nip", this.nip);
                    object result = getIdCmd.ExecuteScalar();
                    int idWaliKelas = Convert.ToInt32(result);
                    addSiswa siswa = new addSiswa(idWaliKelas, this.nip);
                    siswa.Show();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data siswa: " + ex, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
