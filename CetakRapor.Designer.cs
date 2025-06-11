namespace E_Raport_SMA
{
    partial class CetakRapor
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
            semester = new ComboBox();
            label2 = new Label();
            raporSiswa = new DataGridView();
            nis = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            kelas = new DataGridViewTextBoxColumn();
            mapel = new DataGridViewTextBoxColumn();
            nilai = new DataGridViewTextBoxColumn();
            predikat = new DataGridViewTextBoxColumn();
            btnCetak = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)raporSiswa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 0;
            label1.Text = "Rapor Siswa";
            // 
            // semester
            // 
            semester.FormattingEnabled = true;
            semester.Location = new Point(130, 82);
            semester.Margin = new Padding(4, 5, 4, 5);
            semester.Name = "semester";
            semester.Size = new Size(203, 33);
            semester.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Semester";
            // 
            // raporSiswa
            // 
            raporSiswa.BackgroundColor = Color.White;
            raporSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            raporSiswa.Columns.AddRange(new DataGridViewColumn[] { nis, nama, kelas, mapel, nilai, predikat });
            raporSiswa.Location = new Point(29, 153);
            raporSiswa.Margin = new Padding(4, 5, 4, 5);
            raporSiswa.Name = "raporSiswa";
            raporSiswa.RowHeadersWidth = 62;
            raporSiswa.Size = new Size(923, 388);
            raporSiswa.TabIndex = 3;
            raporSiswa.CellContentClick += dataGridView1_CellContentClick;
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
            // kelas
            // 
            kelas.HeaderText = "Kelas";
            kelas.MinimumWidth = 8;
            kelas.Name = "kelas";
            kelas.Width = 150;
            // 
            // mapel
            // 
            mapel.HeaderText = "Mata Pelajaran";
            mapel.MinimumWidth = 8;
            mapel.Name = "mapel";
            mapel.Width = 150;
            // 
            // nilai
            // 
            nilai.HeaderText = "Nilai";
            nilai.MinimumWidth = 8;
            nilai.Name = "nilai";
            nilai.Width = 150;
            // 
            // predikat
            // 
            predikat.HeaderText = "Predikat";
            predikat.MinimumWidth = 8;
            predikat.Name = "predikat";
            predikat.Width = 150;
            // 
            // btnCetak
            // 
            btnCetak.Location = new Point(29, 552);
            btnCetak.Margin = new Padding(4, 5, 4, 5);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(136, 38);
            btnCetak.TabIndex = 4;
            btnCetak.Text = "Cetak Rapor";
            btnCetak.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(173, 552);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 38);
            btnBack.TabIndex = 5;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(semester);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 13);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(923, 130);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // CetakRapor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(976, 628);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnCetak);
            Controls.Add(raporSiswa);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CetakRapor";
            Text = "CetakRapor";
            ((System.ComponentModel.ISupportInitialize)raporSiswa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox semester;
        private Label label2;
        private DataGridView raporSiswa;
        private Button btnCetak;
        private Button btnBack;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn kelas;
        private DataGridViewTextBoxColumn mapel;
        private DataGridViewTextBoxColumn nilai;
        private DataGridViewTextBoxColumn predikat;
    }
}