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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CetakRapor));
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
            label1.Location = new Point(267, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 0;
            label1.Text = "Rapor Siswa";
            // 
            // semester
            // 
            semester.FormattingEnabled = true;
            semester.Location = new Point(91, 49);
            semester.Name = "semester";
            semester.Size = new Size(143, 23);
            semester.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Semester";
            // 
            // raporSiswa
            // 
            raporSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            raporSiswa.BackgroundColor = Color.White;
            raporSiswa.BorderStyle = BorderStyle.None;
            raporSiswa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            raporSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            raporSiswa.Columns.AddRange(new DataGridViewColumn[] { nis, nama, kelas, mapel, nilai, predikat });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            raporSiswa.DefaultCellStyle = dataGridViewCellStyle2;
            raporSiswa.EnableHeadersVisualStyles = false;
            raporSiswa.GridColor = SystemColors.MenuText;
            raporSiswa.Location = new Point(20, 92);
            raporSiswa.Name = "raporSiswa";
            raporSiswa.RowHeadersVisible = false;
            raporSiswa.RowHeadersWidth = 62;
            raporSiswa.Size = new Size(646, 233);
            raporSiswa.TabIndex = 3;
            raporSiswa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nis
            // 
            nis.HeaderText = "NIS";
            nis.MinimumWidth = 8;
            nis.Name = "nis";
            // 
            // nama
            // 
            nama.HeaderText = "Nama Siswa";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            // 
            // kelas
            // 
            kelas.HeaderText = "Kelas";
            kelas.MinimumWidth = 8;
            kelas.Name = "kelas";
            // 
            // mapel
            // 
            mapel.HeaderText = "Mata Pelajaran";
            mapel.MinimumWidth = 8;
            mapel.Name = "mapel";
            // 
            // nilai
            // 
            nilai.HeaderText = "Nilai";
            nilai.MinimumWidth = 8;
            nilai.Name = "nilai";
            // 
            // predikat
            // 
            predikat.HeaderText = "Predikat";
            predikat.MinimumWidth = 8;
            predikat.Name = "predikat";
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.LightSkyBlue;
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Location = new Point(20, 331);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(95, 23);
            btnCetak.TabIndex = 4;
            btnCetak.Text = "Cetak Rapor";
            btnCetak.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSlateGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(121, 331);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(semester);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 78);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // CetakRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(683, 377);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnCetak);
            Controls.Add(raporSiswa);
            Icon = (Icon)resources.GetObject("$this.Icon");
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