using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Raport_SMA
{
    public partial class InputNilai : Form
    {
        private string idNilai;
        private string nipGuru;
        private int idKelas;
        public InputNilai(string namaSiswa, string NIS, double nilai, string mapel, string idNilai, string nip, int idKelas)
        {
            InitializeComponent();
            this.idKelas = idKelas;
            this.idNilai = idNilai;
            this.nipGuru = nip;
            loadData(namaSiswa, NIS, nilai, mapel);
        }

        private void loadData(string nama, string nis, double nilai, string mapel)
        {
            inputNama.Text = nama;
            inputNis.Text = nis;
            inpNilai.Text = nilai.ToString();
            inpMapel.Text = mapel.ToString();

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                conn.Open();
                string query = "UPDATE nilai SET nilai_angka = @nilai WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", this.idNilai);
                cmd.Parameters.AddWithValue("nilai", inpNilai.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data berhasil di update", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
