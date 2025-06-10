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
            btnBack2 = new Button();
            btnLihatRapor = new Button();
            addSiswa = new Button();
            updateSiswa = new Button();
            label1 = new Label();
            btnCariSiswa = new Button();
            cariTxt = new TextBox();
            groupBox1 = new GroupBox();
            dataSiswa = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSiswa).BeginInit();
            SuspendLayout();
            // 
            // btnBack2
            // 
            btnBack2.Location = new Point(795, 539);
            btnBack2.Margin = new Padding(4, 5, 4, 5);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(103, 38);
            btnBack2.TabIndex = 3;
            btnBack2.Text = "Kembali";
            btnBack2.UseVisualStyleBackColor = true;
            // 
            // btnLihatRapor
            // 
            btnLihatRapor.Location = new Point(647, 539);
            btnLihatRapor.Margin = new Padding(4, 5, 4, 5);
            btnLihatRapor.Name = "btnLihatRapor";
            btnLihatRapor.Size = new Size(140, 38);
            btnLihatRapor.TabIndex = 4;
            btnLihatRapor.Text = "Lihat Rapor";
            btnLihatRapor.UseVisualStyleBackColor = true;
            // 
            // addSiswa
            // 
            addSiswa.Location = new Point(68, 539);
            addSiswa.Margin = new Padding(4, 5, 4, 5);
            addSiswa.Name = "addSiswa";
            addSiswa.Size = new Size(140, 38);
            addSiswa.TabIndex = 5;
            addSiswa.Text = "Tambah Siswa";
            addSiswa.UseVisualStyleBackColor = true;
            // 
            // updateSiswa
            // 
            updateSiswa.Location = new Point(217, 539);
            updateSiswa.Margin = new Padding(4, 5, 4, 5);
            updateSiswa.Name = "updateSiswa";
            updateSiswa.Size = new Size(140, 38);
            updateSiswa.TabIndex = 6;
            updateSiswa.Text = "Update Siswa";
            updateSiswa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, -12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 45);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            // 
            // btnCariSiswa
            // 
            btnCariSiswa.Location = new Point(16, 58);
            btnCariSiswa.Margin = new Padding(4, 5, 4, 5);
            btnCariSiswa.Name = "btnCariSiswa";
            btnCariSiswa.Size = new Size(71, 38);
            btnCariSiswa.TabIndex = 2;
            btnCariSiswa.Text = "Cari";
            btnCariSiswa.UseVisualStyleBackColor = true;
            // 
            // cariTxt
            // 
            cariTxt.Location = new Point(109, 62);
            cariTxt.Margin = new Padding(4, 5, 4, 5);
            cariTxt.Name = "cariTxt";
            cariTxt.PlaceholderText = "Cari Nama Siswa";
            cariTxt.Size = new Size(721, 31);
            cariTxt.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataSiswa);
            groupBox1.Controls.Add(cariTxt);
            groupBox1.Controls.Add(btnCariSiswa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(68, 51);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(838, 478);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataSiswa
            // 
            dataSiswa.BackgroundColor = Color.White;
            dataSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSiswa.Location = new Point(16, 129);
            dataSiswa.Margin = new Padding(4, 5, 4, 5);
            dataSiswa.Name = "dataSiswa";
            dataSiswa.RowHeadersWidth = 62;
            dataSiswa.Size = new Size(814, 318);
            dataSiswa.TabIndex = 4;
            // 
            // DashboardWaliKelas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(976, 628);
            Controls.Add(updateSiswa);
            Controls.Add(addSiswa);
            Controls.Add(btnLihatRapor);
            Controls.Add(btnBack2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardWaliKelas";
            Text = "Dashboard Wali Kelas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSiswa).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack2;
        private Button btnLihatRapor;
        private TextBox textBox1;
        private Button addSiswa;
        private Button updateSiswa;
        private Label label1;
        private Button btnCariSiswa;
        private TextBox cariTxt;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridView dataSiswa;
    }
}