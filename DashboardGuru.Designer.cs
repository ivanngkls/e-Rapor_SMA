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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardGuru));
            label1 = new Label();
            dataNilaiSiswa = new DataGridView();
            inputNilai = new Button();
            txtCari = new TextBox();
            btnCari = new Button();
            backBtn = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataNilaiSiswa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 7);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Data Nilai Siswa";
            // 
            // dataNilaiSiswa
            // 
            dataNilaiSiswa.BackgroundColor = Color.White;
            dataNilaiSiswa.BorderStyle = BorderStyle.Fixed3D;
            dataNilaiSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataNilaiSiswa.Location = new Point(69, 95);
            dataNilaiSiswa.Name = "dataNilaiSiswa";
            dataNilaiSiswa.RowHeadersWidth = 62;
            dataNilaiSiswa.Size = new Size(434, 219);
            dataNilaiSiswa.TabIndex = 1;
            dataNilaiSiswa.CellClick += dataNilaiSiswa_CellClick;
            // 
            // inputNilai
            // 
            inputNilai.BackColor = Color.LightSkyBlue;
            inputNilai.FlatStyle = FlatStyle.Flat;
            inputNilai.Location = new Point(323, 320);
            inputNilai.Name = "inputNilai";
            inputNilai.Size = new Size(84, 25);
            inputNilai.TabIndex = 2;
            inputNilai.Text = "Input Nilai";
            inputNilai.UseVisualStyleBackColor = false;
            inputNilai.Click += inputNilai_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(134, 68);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari Nama Siswa";
            txtCari.Size = new Size(370, 23);
            txtCari.TabIndex = 3;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(69, 66);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(51, 23);
            btnCari.TabIndex = 4;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.LightSlateGray;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(412, 320);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(84, 25);
            backBtn.TabIndex = 5;
            backBtn.Text = "Kembali";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(69, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 45);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // DashboardGuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(583, 354);
            Controls.Add(groupBox1);
            Controls.Add(backBtn);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(inputNilai);
            Controls.Add(dataNilaiSiswa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardGuru";
            Text = "Dashboard Guru";
            ((System.ComponentModel.ISupportInitialize)dataNilaiSiswa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataNilaiSiswa;
        private Button inputNilai;
        private TextBox txtCari;
        private Button btnCari;
        private Button backBtn;
        private Label label1;
        private GroupBox groupBox1;
    }
}