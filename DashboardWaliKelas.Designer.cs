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

            label1.Location = new Point(344, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 45);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            // 
            // dataSiswa
            // 

            dataSiswa.BackgroundColor = Color.White;
            dataSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSiswa.Columns.AddRange(new DataGridViewColumn[] { nis, nama, alamat, jenis_kelamin, nilaisiswa });
            dataSiswa.Location = new Point(30, 147);
            dataSiswa.Margin = new Padding(4, 5, 4, 5);
            dataSiswa.Name = "dataSiswa";
            dataSiswa.RowHeadersWidth = 62;
            dataSiswa.Size = new Size(781, 318);
            dataSiswa.TabIndex = 1;
            // 
            // nis
            // 
            nis.HeaderText = "NIS";
            nis.MinimumWidth = 8;
            nis.Name = "nis";
            nis.Width = 150;
            // 
            // nama
            // 
            nama.HeaderText = "Nama Siswa";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            nama.Width = 150;
            // 
            // alamat
            // 
            alamat.HeaderText = "Alamat";
            alamat.MinimumWidth = 8;
            alamat.Name = "alamat";
            alamat.Width = 150;
            // 
            // jenis_kelamin
            // 
            jenis_kelamin.HeaderText = "Jenis Kelamin";
            jenis_kelamin.MinimumWidth = 8;
            jenis_kelamin.Name = "jenis_kelamin";
            jenis_kelamin.Width = 150;
            // 
            // nilaisiswa
            // 
            nilaisiswa.HeaderText = "Nilai Siswa";
            nilaisiswa.MinimumWidth = 8;
            nilaisiswa.Name = "nilaisiswa";
            nilaisiswa.Width = 150;

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cariTxt);
            groupBox1.Controls.Add(btnCariSiswa);
            groupBox1.Controls.Add(dataSiswa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 52);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(821, 478);
            groupBox1.TabIndex = 0;
            //groupBox1.TabStop = false;
            //groupBox1.Enter += groupBox1_Enter;
            // 
            // cariTxt
            // 
            cariTxt.Location = new Point(107, 65);
            cariTxt.Margin = new Padding(4, 5, 4, 5);
            cariTxt.Name = "cariTxt";
            cariTxt.PlaceholderText = "Cari Nama Siswa";
            cariTxt.Size = new Size(691, 31);
            cariTxt.TabIndex = 3;
            // 
            // btnCariSiswa
            // 
            btnCariSiswa.Location = new Point(27, 65);
            btnCariSiswa.Margin = new Padding(4, 5, 4, 5);
            btnCariSiswa.Name = "btnCariSiswa";
            btnCariSiswa.Size = new Size(71, 38);
            btnCariSiswa.TabIndex = 2;
            btnCariSiswa.Text = "Cari";
            btnCariSiswa.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            btnBack2.Location = new Point(699, 540);
            btnBack2.Margin = new Padding(4, 5, 4, 5);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(103, 38);
            btnBack2.TabIndex = 3;
            btnBack2.Text = "Kembali";
            btnBack2.UseVisualStyleBackColor = true;
            // 
            // btnLihatRapor
            // 
            btnLihatRapor.Location = new Point(550, 540);
            btnLihatRapor.Margin = new Padding(4, 5, 4, 5);
            btnLihatRapor.Name = "btnLihatRapor";
            btnLihatRapor.Size = new Size(140, 38);
            btnLihatRapor.TabIndex = 4;
            btnLihatRapor.Text = "Lihat Rapor";
            btnLihatRapor.UseVisualStyleBackColor = true;
            // 
            // addSiswa
            // 
            addSiswa.Location = new Point(24, 540);
            addSiswa.Margin = new Padding(4, 5, 4, 5);
            addSiswa.Name = "addSiswa";
            addSiswa.Size = new Size(140, 38);
            addSiswa.TabIndex = 5;
            addSiswa.Text = "Tambah Siswa";
            addSiswa.UseVisualStyleBackColor = true;
            // 
            // updateSiswa
            // 
            updateSiswa.Location = new Point(173, 540);
            updateSiswa.Margin = new Padding(4, 5, 4, 5);
            updateSiswa.Name = "updateSiswa";
            updateSiswa.Size = new Size(140, 38);
            updateSiswa.TabIndex = 6;
            updateSiswa.Text = "Update Siswa";
            updateSiswa.UseVisualStyleBackColor = true;

            // 
            // DashboardWaliKelas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(833, 590);
            Controls.Add(updateSiswa);
            Controls.Add(addSiswa);
            Controls.Add(btnLihatRapor);
            Controls.Add(btnBack2);
            Controls.Add(groupBox1);

            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardWaliKelas";
            Text = "Dashboard Wali Kelas";
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