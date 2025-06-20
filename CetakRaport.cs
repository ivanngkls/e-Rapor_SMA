using CrystalDecisions.Shared;
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
    public partial class CetakRaport : Form
    {
        private int idSiswa;
        private string nip;
        public CetakRaport(int idSiswa, string nip)
        {
            InitializeComponent();
            this.idSiswa = idSiswa;
            this.nip = nip;
            load_Raport();
        }

        private void load_Raport()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                try
                {
                    conn.Open();
                    string queryRaport = "SELECT mp.nama_mata_pelajaran AS 'Mapel', n.nilai_angka AS 'Nilai', n.predikat AS 'Predikat' FROM siswa s JOIN raport r ON r.id_siswa = s.id LEFT JOIN nilai n ON n.id_raport = r.id JOIN pelajaran p ON p.id = n.id_pelajaran JOIN mata_pelajaran mp ON mp.id = p.id_mata_pelajaran WHERE s.id = @id";
                    MySqlCommand cmd = new MySqlCommand(queryRaport, conn);
                    cmd.Parameters.AddWithValue("@id", this.idSiswa);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewRaport.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Mengambil Data: " + ex, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            DashboardWalikelas walikelas = new DashboardWalikelas(this.nip);
            this.Close();
            walikelas.Show();
        }

        private void buttonCetakRapor_Click(object sender, EventArgs e)
        {
            Raport reportForm = new Raport();
            reportForm.ShowDialog();
        }
    }
}
