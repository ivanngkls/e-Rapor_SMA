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
        private string nipGuru;
        private int idKelas;
        private string selectedNIS, selectedNama, selectedMapel, selectedIdNilai;
        private double selectedNilai;
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

                    string query = "SELECT  s.nis,  s.nama, n.nilai_angka AS 'nilai', mp.nama_mata_pelajaran AS 'mapel', n.id as 'id nilai' FROM  siswa s JOIN raport r ON s.id = r.id_siswa JOIN nilai n ON n.id_raport = r.id JOIN pelajaran p ON p.id = n.id_pelajaran JOIN mata_pelajaran mp ON mp.id = p.id_mata_pelajaran JOIN guru g ON g.id = p.id_guru WHERE s.id_kelas = @idKelas AND p.id_guru = @idGuru";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idGuru", idGuru);
                    cmd.Parameters.AddWithValue("@idKelas", idKelas);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataNilaiSiswa.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error load data" + ex.Message);
                }
            }
        }

        private void dataNilaiSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataNilaiSiswa.Rows[e.RowIndex];
                selectedNIS = row.Cells["nis"].Value.ToString();
                selectedNama = row.Cells["nama"].Value.ToString();
                selectedNilai = Convert.ToDouble(row.Cells["nilai"].Value);
                selectedIdNilai = row.Cells["id nilai"].Value.ToString();
                selectedMapel = row.Cells["mapel"].Value.ToString();

            }
        }

        private void inputNilai_Click(object sender, EventArgs e)
        {
            InputNilai formNilai = new InputNilai(selectedNama, selectedNIS, selectedNilai, selectedMapel, selectedIdNilai, this.nipGuru, this.idKelas);
            formNilai.Show();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Home home = new Home(this.nipGuru);
            this.Hide();
            home.Show();
        }
    }
}
