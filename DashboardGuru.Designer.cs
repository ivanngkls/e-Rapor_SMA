namespace E_Raport_SMA
{
    partial class DashboardGuru
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
            dataNilaiSiswa = new DataGridView();
            nis = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            nilai = new DataGridViewTextBoxColumn();
            inputNilai = new Button();
            txtCari = new TextBox();
            btnCari = new Button();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataNilaiSiswa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 45);
            label1.TabIndex = 0;
            label1.Text = "Data Nilai Siswa";
            // 
            // dataNilaiSiswa
            // 
            dataNilaiSiswa.BackgroundColor = Color.White;
            dataNilaiSiswa.BorderStyle = BorderStyle.Fixed3D;
            dataNilaiSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataNilaiSiswa.Columns.AddRange(new DataGridViewColumn[] { nis, nama, nilai });
            dataNilaiSiswa.Location = new Point(99, 159);
            dataNilaiSiswa.Margin = new Padding(4, 5, 4, 5);
            dataNilaiSiswa.Name = "dataNilaiSiswa";
            dataNilaiSiswa.RowHeadersWidth = 62;
            dataNilaiSiswa.Size = new Size(620, 365);
            dataNilaiSiswa.TabIndex = 1;
            dataNilaiSiswa.CellClick += dgvSiswa_CellClick;
            // 
            // nis
            // 
            nis.DataPropertyName = "nis";
            nis.HeaderText = "NIS";
            nis.MinimumWidth = 8;
            nis.Name = "nis";
            nis.Width = 150;
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama Siswa";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            nama.Width = 150;
            // 
            // nilai
            // 
            nilai.DataPropertyName = "nilai";
            nilai.HeaderText = "Nilai";
            nilai.MinimumWidth = 8;
            nilai.Name = "nilai";
            nilai.Width = 150;
            // 
            // inputNilai
            // 
            inputNilai.BackColor = Color.Transparent;
            inputNilai.Location = new Point(452, 538);
            inputNilai.Margin = new Padding(4, 5, 4, 5);
            inputNilai.Name = "inputNilai";
            inputNilai.Size = new Size(120, 42);
            inputNilai.TabIndex = 2;
            inputNilai.Text = "Input Nilai";
            inputNilai.UseVisualStyleBackColor = false;
            inputNilai.Click += inputNilai_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(192, 114);
            txtCari.Margin = new Padding(4, 5, 4, 5);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari Nama Siswa";
            txtCari.Size = new Size(527, 31);
            txtCari.TabIndex = 3;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(99, 110);
            btnCari.Margin = new Padding(4, 5, 4, 5);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(73, 38);
            btnCari.TabIndex = 4;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Location = new Point(589, 534);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 42);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(99, 25);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(620, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // DashboardGuru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(833, 590);
            Controls.Add(groupBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(inputNilai);
            Controls.Add(dataNilaiSiswa);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardGuru";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataNilaiSiswa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataNilaiSiswa;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn nilai;
        private Button inputNilai;
        private TextBox txtCari;
        private Button btnCari;
        private Button btnLogout;
        private Label label1;
        private GroupBox groupBox1;
    }
}