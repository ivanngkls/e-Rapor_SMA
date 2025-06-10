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
    public partial class InputNilai : Form
    {
        public InputNilai(string namaSiswa, string NIS, double nilai)
        {
            InitializeComponent();
            loadData(namaSiswa, NIS, nilai);
        }

        private void loadData(string nama, string nis, double nilai)
        {
            inputNama.Text = nama;
            inputNis.Text = nis;
            inpNilai.Text = nilai.ToString();
        }

        private void InputNilai_Load(object sender, EventArgs e)
        {

        }
    }
}
