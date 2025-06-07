using MySql.Data.MySqlClient;

namespace E_Raport_SMA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DashboardGuru dashboardGuru = new DashboardGuru();
            string nip = txtNIP.Text.Trim();
            string password = txtPassword.Text.Trim();
               
            if(string.IsNullOrEmpty(nip) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("NIP dan Password harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.connStr))
            {
                try { 
                    conn.Open();
                    string query = "SELECT password FROM guru WHERE nip = @nip";
                    MySqlCommand cmd  = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("nip", @nip);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashFromDb = reader.GetString("password");
                        bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);
                        if (isValid)
                        {
                            MessageBox.Show("Login Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Home home = new Home(nip);
                            this.Hide();
                            home.Show();
                        }
                        else
                        {

                        }
                    }
                }
                catch {
                    MessageBox.Show("Terjadi kesalahan koneksi", "Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
