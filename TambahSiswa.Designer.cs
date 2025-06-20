namespace E_Raport_SMA_Pemvis_Project
{
    partial class TambahSiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahSiswa));
            this.labelJudul = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelJenisKelamin = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonWanita = new System.Windows.Forms.RadioButton();
            this.radioButtonLakilaki = new System.Windows.Forms.RadioButton();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNIS = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNIS = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelJudul.Location = new System.Drawing.Point(235, 38);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(310, 45);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Tambah Siswa Baru";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelJenisKelamin);
            this.groupBox1.Controls.Add(this.groupBoxGender);
            this.groupBox1.Controls.Add(this.textBoxAlamat);
            this.groupBox1.Controls.Add(this.textBoxNama);
            this.groupBox1.Controls.Add(this.textBoxNIS);
            this.groupBox1.Controls.Add(this.labelAlamat);
            this.groupBox1.Controls.Add(this.labelNama);
            this.groupBox1.Controls.Add(this.labelNIS);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(59, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 315);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Tambah Siswa";
            // 
            // labelJenisKelamin
            // 
            this.labelJenisKelamin.AutoSize = true;
            this.labelJenisKelamin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelJenisKelamin.Location = new System.Drawing.Point(21, 246);
            this.labelJenisKelamin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJenisKelamin.Name = "labelJenisKelamin";
            this.labelJenisKelamin.Size = new System.Drawing.Size(136, 28);
            this.labelJenisKelamin.TabIndex = 13;
            this.labelJenisKelamin.Text = "Jenis Kelamin";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonWanita);
            this.groupBoxGender.Controls.Add(this.radioButtonLakilaki);
            this.groupBoxGender.Location = new System.Drawing.Point(169, 218);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(384, 72);
            this.groupBoxGender.TabIndex = 12;
            this.groupBoxGender.TabStop = false;
            // 
            // radioButtonWanita
            // 
            this.radioButtonWanita.AutoSize = true;
            this.radioButtonWanita.Location = new System.Drawing.Point(200, 24);
            this.radioButtonWanita.Name = "radioButtonWanita";
            this.radioButtonWanita.Size = new System.Drawing.Size(141, 32);
            this.radioButtonWanita.TabIndex = 1;
            this.radioButtonWanita.TabStop = true;
            this.radioButtonWanita.Text = "Perempuan";
            this.radioButtonWanita.UseVisualStyleBackColor = true;
            // 
            // radioButtonLakilaki
            // 
            this.radioButtonLakilaki.AutoSize = true;
            this.radioButtonLakilaki.Location = new System.Drawing.Point(15, 26);
            this.radioButtonLakilaki.Name = "radioButtonLakilaki";
            this.radioButtonLakilaki.Size = new System.Drawing.Size(112, 32);
            this.radioButtonLakilaki.TabIndex = 0;
            this.radioButtonLakilaki.TabStop = true;
            this.radioButtonLakilaki.Text = "Laki-laki";
            this.radioButtonLakilaki.UseVisualStyleBackColor = true;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(169, 177);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(384, 33);
            this.textBoxAlamat.TabIndex = 11;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(169, 122);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(384, 33);
            this.textBoxNama.TabIndex = 10;
            // 
            // textBoxNIS
            // 
            this.textBoxNIS.Location = new System.Drawing.Point(169, 68);
            this.textBoxNIS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNIS.Name = "textBoxNIS";
            this.textBoxNIS.Size = new System.Drawing.Size(384, 33);
            this.textBoxNIS.TabIndex = 4;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAlamat.Location = new System.Drawing.Point(21, 177);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(75, 28);
            this.labelAlamat.TabIndex = 8;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNama.Location = new System.Drawing.Point(21, 122);
            this.labelNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(121, 28);
            this.labelNama.TabIndex = 7;
            this.labelNama.Text = "Nama Siswa";
            // 
            // labelNIS
            // 
            this.labelNIS.AutoSize = true;
            this.labelNIS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNIS.Location = new System.Drawing.Point(21, 68);
            this.labelNIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIS.Name = "labelNIS";
            this.labelNIS.Size = new System.Drawing.Size(44, 28);
            this.labelNIS.TabIndex = 6;
            this.labelNIS.Text = "NIS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonKembali);
            this.groupBox3.Controls.Add(this.buttonSimpan);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(59, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKembali.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(517, 34);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(107, 47);
            this.buttonKembali.TabIndex = 6;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(9, 37);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(107, 47);
            this.buttonSimpan.TabIndex = 5;
            this.buttonSimpan.Text = "Tambah";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // TambahSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(751, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TambahSiswa";
            this.Text = "Tambah Siswa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNIS;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNIS;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.Label labelJenisKelamin;
        private System.Windows.Forms.RadioButton radioButtonWanita;
        private System.Windows.Forms.RadioButton radioButtonLakilaki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonSimpan;
    }
}