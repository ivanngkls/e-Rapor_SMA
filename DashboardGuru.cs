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
        private string selectedNIS, selectedNama;
        private double selectedNilai;
        public DashboardGuru(string nip)
        {
            InitializeComponent();
            nipGuru = nip;
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
                    //executScalar -> untuk ambil satu baris saja
                    int idGuru = Convert.ToInt32(IdGuruCmd.ExecuteScalar());

                    string query = @"SELECT siswa.nis, siswa.nama, nilai.nilai_angka 
                                    FROM siswa 
                                    JOIN raport ON siswa.id = raport.id_siswa 
                                    JOIN nilai ON raport.id = nilai.id_raport 
                                    JOIN pelajaran ON nilai.id_pelajaran = pelajaran.id 
                                    JOIN mata_pelajaran ON pelajaran.id_mata_pelajaran = mata_pelajaran.id 
                                    WHERE pelajaran.id_guru = @idGuru";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idGuru", idGuru);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSiswa.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error load data" + ex.Message);
                }
            }
        }

        private void dgvSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                //DataGridViewRow row = dgvSiswa.Rows[e.RowIndex];
                //selectedNIS = row.Cells["nis"].Value.ToString();
                //selectedNama = row.Cells["nama"].Value.ToString();
                //selectedNilai = Convert.ToDouble(row.Cells["nilai_angka"].Value);
            }
        }


        private void inputNilai_Click(object sender, EventArgs e)
        {

            this.Hide();
            InputNilai formNilai = new InputNilai(selectedNama, selectedNIS, selectedNilai);
            formNilai.Show();
        }
    }
}
