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
            dgvSiswa = new DataGridView();
            inputNilai = new Button();
            txtCari = new TextBox();
            btnCari = new Button();
            nis = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 45);
            label1.TabIndex = 0;
            label1.Text = "Data Nilai Siswa";
            // 
            // dgvSiswa
            // 
            dgvSiswa.BackgroundColor = Color.White;
            dgvSiswa.BorderStyle = BorderStyle.Fixed3D;
            dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiswa.Columns.AddRange(new DataGridViewColumn[] { nis, nama });
            dgvSiswa.Location = new Point(27, 162);
            dgvSiswa.Margin = new Padding(4, 5, 4, 5);
            dgvSiswa.Name = "dgvSiswa";
            dgvSiswa.RowHeadersWidth = 62;
            dgvSiswa.Size = new Size(614, 365);
            dgvSiswa.TabIndex = 1;
            // 
            // inputNilai
            // 
            inputNilai.BackColor = SystemColors.GradientActiveCaption;
            inputNilai.Location = new Point(521, 537);
            inputNilai.Margin = new Padding(4, 5, 4, 5);
            inputNilai.Name = "inputNilai";
            inputNilai.Size = new Size(120, 42);
            inputNilai.TabIndex = 2;
            inputNilai.Text = "Input Nilai";
            inputNilai.UseVisualStyleBackColor = false;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(113, 113);
            txtCari.Margin = new Padding(4, 5, 4, 5);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari Nama Siswa";
            txtCari.Size = new Size(527, 31);
            txtCari.TabIndex = 3;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(31, 113);
            btnCari.Margin = new Padding(4, 5, 4, 5);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(73, 38);
            btnCari.TabIndex = 4;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
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
            // DashboardGuru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(696, 618);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(inputNilai);
            Controls.Add(dgvSiswa);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardGuru";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSiswa;
        private Button inputNilai;
        private TextBox txtCari;
        private Button btnCari;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
    }
}