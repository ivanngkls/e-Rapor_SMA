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
            inpNilai.Focus();
            inputNama.Text = nama;
            inputNis.Text = nis;
            inpNilai.Text = nilai.ToString();
            inpMapel.Text = mapel.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!validasiNilai()) return;
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

        private bool validasiNilai()
        {
            if (string.IsNullOrWhiteSpace(inpNilai.Text))
            {
                MessageBox.Show("Nilai wajib diisi", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpNilai.Focus();
                return false;
            }
            if(!int.TryParse(inpNilai.Text, out int nilai) || nilai > 100)
            {
                MessageBox.Show("Nilai harus kurang dari 100", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpNilai.Focus();
                return false;
            }
            return true;
        }
    }
}
