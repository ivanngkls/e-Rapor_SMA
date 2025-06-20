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
    public partial class EditSiswa : Form
    {
        private int idSiswa;
        private string nipGuru;

        public EditSiswa(int idSiswa, string nip)
        {
            InitializeComponent();
            this.idSiswa = idSiswa;
            this.nipGuru = nip;
            LoadDataSiswa();
        }

        private void LoadDataSiswa()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
                {
                    conn.Open();
                    string query = "SELECT * FROM siswa WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idSiswa);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxNIS.Text = reader["nis"].ToString();
                            textBoxNama.Text = reader["nama"].ToString();
                            textBoxAlamat.Text = reader["alamat"].ToString();
                            string gender = reader["jenis_kelamin"].ToString();
                            if (gender == "L")
                                radioButtonLakilaki.Checked = true;
                            else
                                radioButtonWanita.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data siswa: " + ex.Message);
            }
        }

        private string GetSelectedGender()
        {
            if (radioButtonLakilaki.Checked) return "L";
            if (radioButtonWanita.Checked) return "P";
            return "L";
        }

        private bool validasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxNIS.Text))
            {
                MessageBox.Show("NIS wajib diisi");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                MessageBox.Show("Nama wajib diisi");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                MessageBox.Show("Alamat wajib diisi");
                return false;
            }
            return true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!validasiInput()) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE siswa 
                                       SET nis = @nis, nama = @nama, alamat = @alamat, jenis_kelamin = @jenis_kelamin 
                                       WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@nis", textBoxNIS.Text);
                    cmd.Parameters.AddWithValue("@nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("@alamat", textBoxAlamat.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", GetSelectedGender());
                    cmd.Parameters.AddWithValue("@id", idSiswa);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data siswa berhasil diperbarui!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message);
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
