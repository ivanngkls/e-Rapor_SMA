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

                    int idWaliKelas = Convert.ToInt32(result);
                    string query = @"SELECT s.nis, s.nama, s.alamat, ROUND(AVG(n.nilai_angka), 2) as 'nilai' FROM siswa s LEFT JOIN raport r ON s.id = r.id_siswa LEFT JOIN nilai n ON n.id_raport = r.id WHERE s.id_walikelas = @id GROUP BY s.id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idWaliKelas);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataSiswa.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data siswa: " + ex, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
