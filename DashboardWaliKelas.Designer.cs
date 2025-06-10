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
            dataSiswa = new DataGridView();
            nis = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            jenis_kelamin = new DataGridViewTextBoxColumn();
            nilaisiswa = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cariTxt = new TextBox();
            btnCariSiswa = new Button();
            btnBack2 = new Button();
            btnLihatRapor = new Button();
            addSiswa = new Button();
            updateSiswa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSiswa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            // 
            // dataSiswa
            // 
            dataSiswa.BackgroundColor = Color.White;
            dataSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSiswa.Columns.AddRange(new DataGridViewColumn[] { nis, nama, alamat, jenis_kelamin, nilaisiswa });
            dataSiswa.Location = new Point(16, 68);
            dataSiswa.Name = "dataSiswa";
            dataSiswa.Size = new Size(547, 194);
            dataSiswa.TabIndex = 1;
            dataSiswa.CellContentClick += dataGridView1_CellContentClick;
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
            groupBox1.Controls.Add(dataSiswa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cariTxt
            // 
            cariTxt.Location = new Point(75, 39);
            cariTxt.Name = "cariTxt";
            cariTxt.PlaceholderText = "Cari Nama Siswa";
            cariTxt.Size = new Size(485, 23);
            cariTxt.TabIndex = 3;
            cariTxt.TextChanged += this.cariTxt_TextChanged;
            // 
            // btnCariSiswa
            // 
            btnCariSiswa.Location = new Point(19, 39);
            btnCariSiswa.Name = "btnCariSiswa";
            btnCariSiswa.Size = new Size(50, 23);
            btnCariSiswa.TabIndex = 2;
            btnCariSiswa.Text = "Cari";
            btnCariSiswa.UseVisualStyleBackColor = true;
            btnCariSiswa.Click += btnCariSiswa_Click;
            // 
            // btnBack2
            // 
            btnBack2.Location = new Point(489, 324);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(72, 23);
            btnBack2.TabIndex = 3;
            btnBack2.Text = "Kembali";
            btnBack2.UseVisualStyleBackColor = true;
            // 
            // btnLihatRapor
            // 
            btnLihatRapor.Location = new Point(385, 324);
            btnLihatRapor.Name = "btnLihatRapor";
            btnLihatRapor.Size = new Size(98, 23);
            btnLihatRapor.TabIndex = 4;
            btnLihatRapor.Text = "Lihat Rapor";
            btnLihatRapor.UseVisualStyleBackColor = true;
            // 
            // addSiswa
            // 
            addSiswa.Location = new Point(17, 324);
            addSiswa.Name = "addSiswa";
            addSiswa.Size = new Size(98, 23);
            addSiswa.TabIndex = 5;
            addSiswa.Text = "Tambah Siswa";
            addSiswa.UseVisualStyleBackColor = true;
            // 
            // updateSiswa
            // 
            updateSiswa.Location = new Point(121, 324);
            updateSiswa.Name = "updateSiswa";
            updateSiswa.Size = new Size(98, 23);
            updateSiswa.TabIndex = 6;
            updateSiswa.Text = "Update Siswa";
            updateSiswa.UseVisualStyleBackColor = true;
            // 
            // DashboardWaliKelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(583, 354);
            Controls.Add(updateSiswa);
            Controls.Add(addSiswa);
            Controls.Add(btnLihatRapor);
            Controls.Add(btnBack2);
            Controls.Add(groupBox1);
            Name = "DashboardWaliKelas";
            Text = "Dashboard Wali Kelas";
            Load += DashboardWaliKelas_Load;
            ((System.ComponentModel.ISupportInitialize)dataSiswa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataSiswa;
        private GroupBox groupBox1;
        private TextBox cariTxt;
        private Button btnBack2;
        private Button btnLihatRapor;
        private TextBox textBox1;
        private Button btnCariSiswa;
        private Button addSiswa;
        private Button updateSiswa;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn jenis_kelamin;
        private DataGridViewTextBoxColumn nilaisiswa;
    }
}