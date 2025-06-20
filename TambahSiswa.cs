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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace E_Raport_SMA_Pemvis_Project
{
    public partial class TambahSiswa : Form
    {
        private int idWaliKelas;
        private string nipGuru;
        public TambahSiswa(int idWalikelas, string nip)
        {
            InitializeComponent();
            textBoxNIS.Focus();
            this.idWaliKelas = idWalikelas;
            this.nipGuru = nip;
        }

        private string GetSelectedGender()
        {
            foreach (Control ctrl in groupBoxGender.Controls)
            {
                if (ctrl is System.Windows.Forms.RadioButton rb && rb.Checked)
                {
                    return rb.Text == "Laki-laki" ? "L" : "P";
                }
            }
            return "L";
        }

        private bool validasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxNIS.Text))
            {
                MessageBox.Show("NIS wajib diisi", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNIS.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                MessageBox.Show("Nama wajib diisi", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNama.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                MessageBox.Show("Alamat wajib diisi", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAlamat.Focus();
                return false;
            }
            return true;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (!validasiInput()) return;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
                {
                    conn.Open();

                    // Ambil id_kelas
                    MySqlCommand cmdIdKelas = new MySqlCommand("SELECT id FROM kelas WHERE kelas.id_walikelas = @id_walikelas", conn);
                    cmdIdKelas.Parameters.AddWithValue("@id_walikelas", this.idWaliKelas);
                    object result = cmdIdKelas.ExecuteScalar();

                    int idKelas = Convert.ToInt32(result);

                    //add Siswa
                    string getIdQuery = @"INSERT INTO siswa(nis, nama, id_walikelas, id_kelas, alamat, jenis_kelamin) VALUES (@nis, @nama, @id_walikelas, @id_kelas, @alamat, @jenis_kelamin)";
                    MySqlCommand cmd = new MySqlCommand(getIdQuery, conn);
                    cmd.Parameters.AddWithValue("@nis", textBoxNIS.Text);
                    cmd.Parameters.AddWithValue("@id_walikelas", this.idWaliKelas);
                    cmd.Parameters.AddWithValue("@id_kelas", idKelas);
                    cmd.Parameters.AddWithValue("@nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("@alamat", textBoxAlamat.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", GetSelectedGender());

                    cmd.ExecuteNonQuery();
                    long idSiswaBaru = cmd.LastInsertedId;

                    //add Raport
                    string raportQuery = @"INSERT INTO raport(id_siswa, id_walikelas, semester) VALUES (@id_siswa, @id_walikelas, '1')";
                    MySqlCommand raportCmd = new MySqlCommand(raportQuery, conn);
                    raportCmd.Parameters.AddWithValue("@id_walikelas", this.idWaliKelas);
                    raportCmd.Parameters.AddWithValue("@id_siswa", idSiswaBaru);
                    raportCmd.ExecuteNonQuery();

                    long idRaportBaru = raportCmd.LastInsertedId;
                    string getPelajaranQuery = "SELECT MIN(id) as id FROM pelajaran GROUP BY id_mata_pelajaran ";
                    MySqlCommand getPelajaranCmd = new MySqlCommand(getPelajaranQuery, conn);

                    using (var reader = getPelajaranCmd.ExecuteReader())
                    {
                        List<int> idPelajarans = new List<int>();
                        while (reader.Read())
                        {
                            idPelajarans.Add(reader.GetInt32("id"));
                        }

                        reader.Close();

                        foreach (int idPel in idPelajarans)
                        {
                            string insertNilaiQuery = "INSERT INTO nilai(id_pelajaran, id_raport) VALUES(@id_pelajaran, @id_raport)";
                            using (MySqlCommand insertNilaiCmd = new MySqlCommand(insertNilaiQuery, conn))
                            {
                                insertNilaiCmd.Parameters.AddWithValue("@id_pelajaran", idPel);
                                insertNilaiCmd.Parameters.AddWithValue("@id_raport", idRaportBaru);
                                insertNilaiCmd.ExecuteNonQuery();
                            }

                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data siswa: " + ex, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
