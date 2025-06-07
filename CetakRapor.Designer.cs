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
            dataGridView1 = new DataGridView();
            nis = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            kelas = new DataGridViewTextBoxColumn();
            cetak = new DataGridViewTextBoxColumn();
            btnCetak = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 24);
            label1.TabIndex = 0;
            label1.Text = "Rapor Siswa";
            // 
            // semester
            // 
            semester.FormattingEnabled = true;
            semester.Location = new Point(106, 60);
            semester.Name = "semester";
            semester.Size = new Size(143, 23);
            semester.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 63);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Semester";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nis, nama, kelas, cetak });
            dataGridView1.Location = new Point(20, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(446, 138);
            dataGridView1.TabIndex = 3;
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
            // kelas
            // 
            kelas.HeaderText = "Kelas";
            kelas.Name = "kelas";
            // 
            // cetak
            // 
            cetak.HeaderText = "Cetak";
            cetak.Name = "cetak";
            // 
            // btnCetak
            // 
            btnCetak.Location = new Point(371, 236);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(95, 23);
            btnCetak.TabIndex = 4;
            btnCetak.Text = "Cetak Rapor";
            btnCetak.UseVisualStyleBackColor = true;
            // 
            // CetakRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 308);
            Controls.Add(btnCetak);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(semester);
            Controls.Add(label1);
            Name = "CetakRapor";
            Text = "CetakRapor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox semester;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn kelas;
        private DataGridViewTextBoxColumn cetak;
        private Button btnCetak;
    }
}