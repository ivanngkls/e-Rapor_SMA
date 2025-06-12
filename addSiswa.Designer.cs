namespace E_Raport_SMA
{
    partial class addSiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSiswa));
            groupBox2 = new GroupBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            jkGroupBox = new GroupBox();
            jkPRadio = new RadioButton();
            jkLRadio = new RadioButton();
            inpNamaSiswa = new TextBox();
            inpNis = new TextBox();
            inpAlamat = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            jkGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Controls.Add(btnBatal);
            groupBox2.Location = new Point(59, 448);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(633, 100);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LightSkyBlue;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(9, 33);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(116, 47);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.LightSlateGray;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Location = new Point(510, 33);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(114, 47);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 45);
            label1.TabIndex = 16;
            label1.Text = "Tambah Siswa Baru";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(jkGroupBox);
            groupBox1.Controls.Add(inpNamaSiswa);
            groupBox1.Controls.Add(inpNis);
            groupBox1.Controls.Add(inpAlamat);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(59, 117);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(633, 315);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Data Siswa";
            // 
            // jkGroupBox
            // 
            jkGroupBox.Controls.Add(jkPRadio);
            jkGroupBox.Controls.Add(jkLRadio);
            jkGroupBox.Location = new Point(187, 200);
            jkGroupBox.Name = "jkGroupBox";
            jkGroupBox.Size = new Size(384, 72);
            jkGroupBox.TabIndex = 14;
            jkGroupBox.TabStop = false;
            // 
            // jkPRadio
            // 
            jkPRadio.AutoSize = true;
            jkPRadio.Location = new Point(194, 22);
            jkPRadio.Name = "jkPRadio";
            jkPRadio.Size = new Size(141, 32);
            jkPRadio.TabIndex = 1;
            jkPRadio.TabStop = true;
            jkPRadio.Text = "Perempuan";
            jkPRadio.UseVisualStyleBackColor = true;
            // 
            // jkLRadio
            // 
            jkLRadio.AutoSize = true;
            jkLRadio.Location = new Point(6, 22);
            jkLRadio.Name = "jkLRadio";
            jkLRadio.Size = new Size(112, 32);
            jkLRadio.TabIndex = 0;
            jkLRadio.TabStop = true;
            jkLRadio.Text = "Laki-laki";
            jkLRadio.UseVisualStyleBackColor = true;
            // 
            // inpNamaSiswa
            // 
            inpNamaSiswa.BackColor = SystemColors.HighlightText;
            inpNamaSiswa.Location = new Point(187, 105);
            inpNamaSiswa.Margin = new Padding(4, 5, 4, 5);
            inpNamaSiswa.Name = "inpNamaSiswa";
            inpNamaSiswa.PlaceholderText = "Masukkan Nama Siswa";
            inpNamaSiswa.Size = new Size(384, 33);
            inpNamaSiswa.TabIndex = 11;
            // 
            // inpNis
            // 
            inpNis.BackColor = SystemColors.HighlightText;
            inpNis.Location = new Point(187, 53);
            inpNis.Margin = new Padding(4, 5, 4, 5);
            inpNis.Name = "inpNis";
            inpNis.PlaceholderText = "Masukkan NIS";
            inpNis.Size = new Size(384, 33);
            inpNis.TabIndex = 10;
            // 
            // inpAlamat
            // 
            inpAlamat.BackColor = SystemColors.HighlightText;
            inpAlamat.Location = new Point(187, 158);
            inpAlamat.Margin = new Padding(4, 5, 4, 5);
            inpAlamat.Name = "inpAlamat";
            inpAlamat.PlaceholderText = "Masukkan Alamat";
            inpAlamat.Size = new Size(384, 33);
            inpAlamat.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 222);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 4;
            label6.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 2;
            label4.Text = "Alamat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 1;
            label3.Text = "Nama Siswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 0;
            label2.Text = "NIS";
            // 
            // addSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(751, 595);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addSiswa";
            Text = "Tambah Siswa";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            jkGroupBox.ResumeLayout(false);
            jkGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox inpNamaSiswa;
        private TextBox inpNis;
        private TextBox inpAlamat;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label4;
        private GroupBox jkGroupBox;
        private RadioButton jkPRadio;
        private RadioButton jkLRadio;
    }
}