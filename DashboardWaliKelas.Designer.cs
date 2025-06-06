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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 28);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nis, nama, alamat, jenis_kelamin, nilaisiswa });
            dataGridView1.Location = new Point(21, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(551, 191);
            dataGridView1.TabIndex = 1;
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
            // DashboardWaliKelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 298);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DashboardWaliKelas";
            Text = "DashboardWaliKelas";
            Load += DashboardWaliKelas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn jenis_kelamin;
        private DataGridViewTextBoxColumn nilaisiswa;
    }
}