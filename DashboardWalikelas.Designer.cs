namespace E_Raport_SMA_Pemvis_Project
{
    partial class DashboardWalikelas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardWalikelas));
            this.groupBoxSiswa = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.dataGridViewSiswa = new System.Windows.Forms.DataGridView();
            this.labelHalaman = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelSiswa = new System.Windows.Forms.Label();
            this.buttonTambahSiswa = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonLihatRapor = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.groupBoxSiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSiswa
            // 
            this.groupBoxSiswa.Controls.Add(this.buttonClear);
            this.groupBoxSiswa.Controls.Add(this.comboBoxFilter);
            this.groupBoxSiswa.Controls.Add(this.textBoxCari);
            this.groupBoxSiswa.Controls.Add(this.buttonCari);
            this.groupBoxSiswa.Controls.Add(this.dataGridViewSiswa);
            this.groupBoxSiswa.Controls.Add(this.labelHalaman);
            this.groupBoxSiswa.Controls.Add(this.buttonNext);
            this.groupBoxSiswa.Controls.Add(this.buttonPrev);
            this.groupBoxSiswa.Controls.Add(this.labelSiswa);
            this.groupBoxSiswa.Location = new System.Drawing.Point(69, 52);
            this.groupBoxSiswa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSiswa.Name = "groupBoxSiswa";
            this.groupBoxSiswa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSiswa.Size = new System.Drawing.Size(839, 478);
            this.groupBoxSiswa.TabIndex = 1;
            this.groupBoxSiswa.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Azure;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(732, 66);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 48);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Nama",
            "Alamat"});
            this.comboBoxFilter.Location = new System.Drawing.Point(8, 78);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(114, 28);
            this.comboBoxFilter.TabIndex = 19;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(130, 78);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(488, 26);
            this.textBoxCari.TabIndex = 18;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCari.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.Location = new System.Drawing.Point(626, 66);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(90, 48);
            this.buttonCari.TabIndex = 17;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // dataGridViewSiswa
            // 
            this.dataGridViewSiswa.AllowUserToOrderColumns = true;
            this.dataGridViewSiswa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiswa.Location = new System.Drawing.Point(8, 124);
            this.dataGridViewSiswa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSiswa.Name = "dataGridViewSiswa";
            this.dataGridViewSiswa.ReadOnly = true;
            this.dataGridViewSiswa.RowHeadersWidth = 62;
            this.dataGridViewSiswa.Size = new System.Drawing.Size(814, 287);
            this.dataGridViewSiswa.TabIndex = 15;
            this.dataGridViewSiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiswa_CellClick);
            // 
            // labelHalaman
            // 
            this.labelHalaman.AutoSize = true;
            this.labelHalaman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelHalaman.Location = new System.Drawing.Point(699, 433);
            this.labelHalaman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHalaman.Name = "labelHalaman";
            this.labelHalaman.Size = new System.Drawing.Size(82, 25);
            this.labelHalaman.TabIndex = 9;
            this.labelHalaman.Text = "Halaman";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Azure;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(113, 427);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(89, 38);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Next>";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.Azure;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(16, 427);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(89, 38);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "<Prev";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // labelSiswa
            // 
            this.labelSiswa.AutoSize = true;
            this.labelSiswa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSiswa.Location = new System.Drawing.Point(331, 0);
            this.labelSiswa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiswa.Name = "labelSiswa";
            this.labelSiswa.Size = new System.Drawing.Size(183, 45);
            this.labelSiswa.TabIndex = 2;
            this.labelSiswa.Text = "Data Siswa";
            // 
            // buttonTambahSiswa
            // 
            this.buttonTambahSiswa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonTambahSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahSiswa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahSiswa.Location = new System.Drawing.Point(69, 538);
            this.buttonTambahSiswa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTambahSiswa.Name = "buttonTambahSiswa";
            this.buttonTambahSiswa.Size = new System.Drawing.Size(140, 52);
            this.buttonTambahSiswa.TabIndex = 10;
            this.buttonTambahSiswa.Text = "Tambah Siswa";
            this.buttonTambahSiswa.UseVisualStyleBackColor = false;
            this.buttonTambahSiswa.Click += new System.EventHandler(this.buttonTambahSiswa_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(217, 540);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 52);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update Siswa";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHapus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(365, 540);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(140, 52);
            this.buttonHapus.TabIndex = 12;
            this.buttonHapus.Text = "Hapus Siswa";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonLihatRapor
            // 
            this.buttonLihatRapor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLihatRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLihatRapor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatRapor.Location = new System.Drawing.Point(647, 538);
            this.buttonLihatRapor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLihatRapor.Name = "buttonLihatRapor";
            this.buttonLihatRapor.Size = new System.Drawing.Size(140, 52);
            this.buttonLihatRapor.TabIndex = 13;
            this.buttonLihatRapor.Text = "Lihat Rapor";
            this.buttonLihatRapor.UseVisualStyleBackColor = false;
            this.buttonLihatRapor.Click += new System.EventHandler(this.buttonLihatRapor_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKembali.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(795, 538);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(113, 52);
            this.buttonKembali.TabIndex = 14;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // DashboardWalikelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(976, 663);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonLihatRapor);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTambahSiswa);
            this.Controls.Add(this.groupBoxSiswa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardWalikelas";
            this.Text = "Dashboard Walikelas";
            this.groupBoxSiswa.ResumeLayout(false);
            this.groupBoxSiswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSiswa;
        private System.Windows.Forms.Label labelSiswa;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonTambahSiswa;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonLihatRapor;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Label labelHalaman;
        private System.Windows.Forms.DataGridView dataGridViewSiswa;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button buttonCari;
    }
}