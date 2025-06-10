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

        int pageSize = 10;
        int currentPage = 1;
        int totalPages = 1;
        int totalRecords = 0;
        public DashboardWaliKelas(String nip)
        {
            InitializeComponent();
            this.nip = nip;
            Load_DataSiswa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                    string countQuery = "SELECT (*) FROM siswa WHERE id_walikelas = @id";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                    totalPages =(int)Math.Ceiling((double)totalRecords/pageSize);
                    if(currentPage > totalPages) currentPage = totalPages;
                    if(currentPage < 1) currentPage = 1;

                    int offset = (currentPage - 1) * pageSize;

                    int idWaliKelas = Convert.ToInt32(result);
                    string query = @"SELECT s.nis, s.nama, s.alamat, ROUND(AVG(n.nilai_angka), 2) as 'nilai' FROM siswa s LEFT JOIN raport r ON s.id = r.id_siswa LEFT JOIN nilai n ON n.id_raport = r.id WHERE s.id_walikelas = @id GROUP BY s.id DESC LIMIT @limit OFFSET @offset";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@limit", pageSize);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataSiswa.DataSource = dt;
                    pageInfoLabel.Text = $"Halaman {currentPage} dari {totalPages}";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data siswa: " + ex, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
