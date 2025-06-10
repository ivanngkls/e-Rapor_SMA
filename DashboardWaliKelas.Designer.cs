namespace E_Raport_SMA
{
    partial class DashboardWaliKelas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            nis = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            jenis_kelamin = new DataGridViewTextBoxColumn();
            nilaisiswa = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cariTxt = new TextBox();
            btnCariSiswa = new Button();
            btnLogout2 = new Button();
            btnCetakRapor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nis, nama, alamat, jenis_kelamin, nilaisiswa });
            dataGridView1.Location = new Point(16, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 194);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nis
            // 
            nis.HeaderText = "NIS";
            nis.Name = "nis";
            // 
            // nama
            // 
            nama.HeaderText = "Nama Siswa";
            nama.Name = "nama";
            // 
            // alamat
            // 
            alamat.HeaderText = "Alamat";
            alamat.Name = "alamat";
            // 
            // jenis_kelamin
            // 
            jenis_kelamin.HeaderText = "Jenis Kelamin";
            jenis_kelamin.Name = "jenis_kelamin";
            // 
            // nilaisiswa
            // 
            nilaisiswa.HeaderText = "Nilai Siswa";
            nilaisiswa.Name = "nilaisiswa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cariTxt);
            groupBox1.Controls.Add(btnCariSiswa);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cariTxt
            // 
            cariTxt.Location = new Point(72, 62);
            cariTxt.Name = "cariTxt";
            cariTxt.PlaceholderText = "Cari Nama Siswa";
            cariTxt.Size = new Size(485, 23);
            cariTxt.TabIndex = 3;
            // 
            // btnCariSiswa
            // 
            btnCariSiswa.Location = new Point(16, 62);
            btnCariSiswa.Name = "btnCariSiswa";
            btnCariSiswa.Size = new Size(50, 23);
            btnCariSiswa.TabIndex = 2;
            btnCariSiswa.Text = "Cari";
            btnCariSiswa.UseVisualStyleBackColor = true;
            // 
            // btnLogout2
            // 
            btnLogout2.Location = new Point(489, 324);
            btnLogout2.Name = "btnLogout2";
            btnLogout2.Size = new Size(72, 23);
            btnLogout2.TabIndex = 3;
            btnLogout2.Text = "Logout";
            btnLogout2.UseVisualStyleBackColor = true;
            // 
            // btnCetakRapor
            // 
            btnCetakRapor.Location = new Point(385, 324);
            btnCetakRapor.Name = "btnCetakRapor";
            btnCetakRapor.Size = new Size(98, 23);
            btnCetakRapor.TabIndex = 4;
            btnCetakRapor.Text = "Cetak Rapor";
            btnCetakRapor.UseVisualStyleBackColor = true;
            // 
            // DashboardWaliKelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(583, 354);
            Controls.Add(btnCetakRapor);
            Controls.Add(btnLogout2);
            Controls.Add(groupBox1);
            Name = "DashboardWaliKelas";
            Text = "Dashboard";
            Load += DashboardWaliKelas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn jenis_kelamin;
        private DataGridViewTextBoxColumn nilaisiswa;
        private GroupBox groupBox1;
        private TextBox cariTxt;
        private Button btnLogout2;
        private Button btnCetakRapor;
        private TextBox textBox1;
        private Button btnCariSiswa;
    }
}