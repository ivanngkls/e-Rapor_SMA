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

namespace E_Raport_SMA_Pemvis_Project
{
    public partial class DashboardGuru : Form
    {
        private string nipGuru;
        private int idKelas;
        private string selectedNIS, selectedNama, selectedMapel, selectedIdNilai;
        private double selectedNilai;
        private int currentPage = 1;
        private int pageSize = 5;
        private int totalRecords = 0;
        private int totalPages = 0;

        public DashboardGuru(string nip, int id_kelas)
        {
            InitializeComponent();
            this.idKelas = id_kelas;
            this.nipGuru = nip;
            loadData();
        }

        private void loadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                try
                {
                    conn.Open();

                    string IdGuruQuery = "SELECT id FROM guru WHERE nip = @nip";
                    MySqlCommand IdGuruCmd = new MySqlCommand(IdGuruQuery, conn);
                    IdGuruCmd.Parameters.AddWithValue("@nip", nipGuru);
                    //executeScalar -> untuk ambil satu baris saja
                    int idGuru = Convert.ToInt32(IdGuruCmd.ExecuteScalar());

                    string countQuery = @"SELECT COUNT(*) 
                                  FROM siswa s
                                  JOIN raport r ON s.id = r.id_siswa
                                  JOIN nilai n ON n.id_raport = r.id
                                  JOIN pelajaran p ON p.id = n.id_pelajaran
                                  WHERE s.id_kelas = @idKelas AND p.id_guru = @idGuru";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    countCmd.Parameters.AddWithValue("@idKelas", idKelas);
                    countCmd.Parameters.AddWithValue("@idGuru", idGuru);
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (currentPage > totalPages) currentPage = totalPages;
                    if (currentPage < 1) currentPage = 1;

                    int offset = (currentPage - 1) * pageSize;

                    string query = @"SELECT s.nis AS 'nis', s.nama AS 'nama', 
                                    n.nilai_angka AS 'nilai', 
                                    mp.nama_mata_pelajaran AS 'mapel', 
                                    n.id AS 'id nilai'
                             FROM siswa s
                             JOIN raport r ON s.id = r.id_siswa
                             JOIN nilai n ON n.id_raport = r.id
                             JOIN pelajaran p ON p.id = n.id_pelajaran
                             JOIN mata_pelajaran mp ON mp.id = p.id_mata_pelajaran
                             WHERE s.id_kelas = @idKelas AND p.id_guru = @idGuru
                             ORDER BY mp.nama_mata_pelajaran
                             LIMIT @limit OFFSET @offset";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idGuru", idGuru);
                    cmd.Parameters.AddWithValue("@idKelas", idKelas);
                    cmd.Parameters.AddWithValue("@idGuru", idGuru);
                    cmd.Parameters.AddWithValue("@limit", pageSize);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewNilai.DataSource = dt;
                    dataGridViewNilai.Columns["id nilai"].Visible = false;

                    labelHalaman.Text = $"Halaman {currentPage} dari {totalPages}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error load data" + ex.Message);
                }
            }
        }

        private void buttonInputNilai_Click(object sender, EventArgs e)
        {
            InputNilai formNilai = new InputNilai(selectedNama, selectedNIS, selectedNilai, selectedMapel, selectedIdNilai, this.nipGuru, this.idKelas);
            formNilai.ShowDialog();
            loadData();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Beranda home = new Beranda(this.nipGuru);
            this.Close();
            home.Show();
        }

        private void dataGridViewNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNilai.Rows[e.RowIndex];
                selectedNIS = row.Cells["nis"].Value.ToString();
                selectedNama = row.Cells["nama"].Value.ToString();
                selectedNilai = Convert.ToDouble(row.Cells["nilai"].Value);
                selectedIdNilai = row.Cells["id nilai"].Value.ToString();
                selectedMapel = row.Cells["mapel"].Value.ToString();

            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                loadData();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                loadData();
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            tampilkanDataFiltered();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCari.Clear();
        }

        private void tampilkanDataFiltered()
        {
            string kolom = comboBoxFilter.SelectedItem?.ToString();
            string keyword = textBoxCari.Text.Trim();
            string kolomDb = "s.nama";

            if (kolom == "Mapel") kolomDb = "mp.nama_mata_pelajaran";

            using (MySqlConnection connection = new MySqlConnection(DBConfig.connStr))
            {
                try
                {
                    connection.Open();
                    string idGuruQuery = "SELECT id FROM guru WHERE nip = @nip";
                    MySqlCommand idGuruCmd = new MySqlCommand(idGuruQuery, connection);
                    idGuruCmd.Parameters.AddWithValue("@nip", nipGuru);
                    int idGuru = Convert.ToInt32(idGuruCmd.ExecuteScalar());

                    string query = $@"SELECT s.nis as 'nis',s.nama as 'nama', n.nilai_angka AS 'nilai', mp.nama_mata_pelajaran AS 'mapel',n.id as 'id nilai' FROM siswa s JOIN raport r ON s.id = r.id_siswa JOIN nilai n ON n.id_raport = r.id JOIN pelajaran p ON p.id = n.id_pelajaran JOIN mata_pelajaran mp ON mp.id = p.id_mata_pelajaran WHERE {kolomDb} LIKE @keyword AND s.id_kelas = @idKelas AND p.id_guru = @idGuru ORDER BY mp.nama_mata_pelajaran";
                    ;

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    cmd.Parameters.AddWithValue("@idKelas", idKelas);
                    cmd.Parameters.AddWithValue("@idGuru", idGuru);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewNilai.DataSource = dt;
                    dataGridViewNilai.Columns["id nilai"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat filter data: " + ex.Message);
                }

            }
            }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
        }
    }
}
