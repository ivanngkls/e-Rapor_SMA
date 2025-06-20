using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_Raport_SMA_Pemvis_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            string nip = textBoxNIP.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(nip) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("NIP dan Password harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password FROM guru WHERE nip = @nip";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nip", nip);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashFromDb = reader.GetString("password");
                        bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);
                        if (isValid)
                        {
                            MessageBox.Show("Login Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Beranda home = new Beranda(nip);
                            this.Hide();
                            home.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password Salah", "Invalid", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Terjadi kesalahan koneksi", "Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
