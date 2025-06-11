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
            BackBtn = new Button();
            btnLihatRapor = new Button();
            addSiswa = new Button();
            updateSiswa = new Button();
            label1 = new Label();
            btnCariSiswa = new Button();
            cariTxt = new TextBox();
            groupBox1 = new GroupBox();
            pageInfoLabel = new Label();
            nextBtn = new Button();
            prevBtn = new Button();
            dataSiswa = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSiswa).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(795, 539);
            BackBtn.Margin = new Padding(4, 5, 4, 5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(103, 38);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Kembali";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
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
            groupBox1.Controls.Add(pageInfoLabel);
            groupBox1.Controls.Add(nextBtn);
            groupBox1.Controls.Add(prevBtn);
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
            // pageInfoLabel
            // 
            pageInfoLabel.AutoSize = true;
            pageInfoLabel.Location = new Point(698, 433);
            pageInfoLabel.Name = "pageInfoLabel";
            pageInfoLabel.Size = new Size(132, 25);
            pageInfoLabel.TabIndex = 9;
            pageInfoLabel.Text = "Halaman 1 dari";
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(113, 426);
            nextBtn.Margin = new Padding(4, 5, 4, 5);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(89, 38);
            nextBtn.TabIndex = 8;
            nextBtn.Text = "Next >";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(16, 426);
            prevBtn.Margin = new Padding(4, 5, 4, 5);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(89, 38);
            prevBtn.TabIndex = 7;
            prevBtn.Text = "< Prev";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // dataSiswa
            // 
            dataSiswa.BackgroundColor = Color.White;
            dataSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSiswa.Location = new Point(16, 129);
            dataSiswa.Margin = new Padding(4, 5, 4, 5);
            dataSiswa.Name = "dataSiswa";
            dataSiswa.RowHeadersWidth = 62;
            dataSiswa.Size = new Size(814, 287);
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
            Controls.Add(BackBtn);
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
        private Button BackBtn;
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
        private Button nextBtn;
        private Button prevBtn;
        private Label pageInfoLabel;
    }
}