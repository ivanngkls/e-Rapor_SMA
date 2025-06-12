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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardWaliKelas));
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
            BackBtn.BackColor = Color.LightSlateGray;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Location = new Point(556, 323);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(72, 23);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Kembali";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // btnLihatRapor
            // 
            btnLihatRapor.BackColor = Color.LightSkyBlue;
            btnLihatRapor.FlatStyle = FlatStyle.Flat;
            btnLihatRapor.Location = new Point(453, 323);
            btnLihatRapor.Name = "btnLihatRapor";
            btnLihatRapor.Size = new Size(98, 23);
            btnLihatRapor.TabIndex = 4;
            btnLihatRapor.Text = "Lihat Rapor";
            btnLihatRapor.UseVisualStyleBackColor = false;
            // 
            // addSiswa
            // 
            addSiswa.BackColor = Color.LightSkyBlue;
            addSiswa.FlatStyle = FlatStyle.Flat;
            addSiswa.Location = new Point(48, 323);
            addSiswa.Name = "addSiswa";
            addSiswa.Size = new Size(98, 23);
            addSiswa.TabIndex = 5;
            addSiswa.Text = "Tambah Siswa";
            addSiswa.UseVisualStyleBackColor = true;
            addSiswa.Click += addSiswa_Click;
            // 
            // updateSiswa
            // 
            updateSiswa.BackColor = Color.MediumPurple;
            updateSiswa.FlatStyle = FlatStyle.Flat;
            updateSiswa.Location = new Point(152, 323);
            updateSiswa.Name = "updateSiswa";
            updateSiswa.Size = new Size(98, 23);
            updateSiswa.TabIndex = 6;
            updateSiswa.Text = "Update Siswa";
            updateSiswa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            // 
            // btnCariSiswa
            // 
            btnCariSiswa.Location = new Point(11, 37);
            btnCariSiswa.Name = "btnCariSiswa";
            btnCariSiswa.Size = new Size(50, 25);
            btnCariSiswa.TabIndex = 2;
            btnCariSiswa.Text = "Cari";
            btnCariSiswa.UseVisualStyleBackColor = true;
            // 
            // cariTxt
            // 
            cariTxt.Location = new Point(70, 39);
            cariTxt.Name = "cariTxt";
            cariTxt.PlaceholderText = "Cari Nama Siswa";
            cariTxt.Size = new Size(506, 23);
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
            groupBox1.Location = new Point(48, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pageInfoLabel
            // 
            pageInfoLabel.AutoSize = true;
            pageInfoLabel.Location = new Point(489, 260);
            pageInfoLabel.Margin = new Padding(2, 0, 2, 0);
            pageInfoLabel.Name = "pageInfoLabel";
            pageInfoLabel.Size = new Size(87, 15);
            pageInfoLabel.TabIndex = 9;
            pageInfoLabel.Text = "Halaman 1 dari";
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(79, 256);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(62, 23);
            nextBtn.TabIndex = 8;
            nextBtn.Text = "Next >";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(11, 256);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(62, 23);
            prevBtn.TabIndex = 7;
            prevBtn.Text = "< Prev";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // dataSiswa
            // 
            dataSiswa.BackgroundColor = Color.White;
            dataSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSiswa.Location = new Point(11, 77);
            dataSiswa.Name = "dataSiswa";
            dataSiswa.RowHeadersWidth = 62;
            dataSiswa.Size = new Size(570, 172);
            dataSiswa.TabIndex = 4;
            // 
            // DashboardWaliKelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(683, 377);
            Controls.Add(updateSiswa);
            Controls.Add(addSiswa);
            Controls.Add(btnLihatRapor);
            Controls.Add(BackBtn);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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