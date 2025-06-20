
﻿namespace E_Raport_SMA_Pemvis_Project
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

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardGuru));
            this.groupBoxJudul = new System.Windows.Forms.GroupBox();
            this.labelNilai = new System.Windows.Forms.Label();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewNilai = new System.Windows.Forms.DataGridView();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonInputNilai = new System.Windows.Forms.Button();
            this.labelHalaman = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.groupBoxJudul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxJudul
            // 
            this.groupBoxJudul.Controls.Add(this.labelNilai);
            this.groupBoxJudul.Location = new System.Drawing.Point(104, 23);
            this.groupBoxJudul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxJudul.Name = "groupBoxJudul";
            this.groupBoxJudul.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxJudul.Size = new System.Drawing.Size(651, 69);
            this.groupBoxJudul.TabIndex = 0;
            this.groupBoxJudul.TabStop = false;
            // 
            // labelNilai
            // 
            this.labelNilai.AutoSize = true;
            this.labelNilai.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelNilai.Location = new System.Drawing.Point(192, 11);
            this.labelNilai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNilai.Name = "labelNilai";
            this.labelNilai.Size = new System.Drawing.Size(261, 45);
            this.labelNilai.TabIndex = 1;
            this.labelNilai.Text = "Data Nilai Siswa";
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCari.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.Location = new System.Drawing.Point(558, 102);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(90, 48);
            this.buttonCari.TabIndex = 2;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(201, 114);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(346, 26);
            this.textBoxCari.TabIndex = 3;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Nama",
            "Mapel"});
            this.comboBoxFilter.Location = new System.Drawing.Point(105, 112);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(88, 28);
            this.comboBoxFilter.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Azure;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(664, 102);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 48);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewNilai
            // 
            this.dataGridViewNilai.AllowUserToOrderColumns = true;
            this.dataGridViewNilai.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNilai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNilai.Location = new System.Drawing.Point(105, 158);
            this.dataGridViewNilai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewNilai.Name = "dataGridViewNilai";
            this.dataGridViewNilai.ReadOnly = true;
            this.dataGridViewNilai.RowHeadersWidth = 62;
            this.dataGridViewNilai.Size = new System.Drawing.Size(650, 279);
            this.dataGridViewNilai.TabIndex = 5;
            this.dataGridViewNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNilai_CellClick);
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKembali.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(633, 480);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(122, 46);
            this.buttonKembali.TabIndex = 6;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonInputNilai
            // 
            this.buttonInputNilai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInputNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInputNilai.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInputNilai.Location = new System.Drawing.Point(507, 480);
            this.buttonInputNilai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInputNilai.Name = "buttonInputNilai";
            this.buttonInputNilai.Size = new System.Drawing.Size(117, 46);
            this.buttonInputNilai.TabIndex = 7;
            this.buttonInputNilai.Text = "Input Nilai";
            this.buttonInputNilai.UseVisualStyleBackColor = false;
            this.buttonInputNilai.Click += new System.EventHandler(this.buttonInputNilai_Click);
            // 
            // labelHalaman
            // 
            this.labelHalaman.AutoSize = true;
            this.labelHalaman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelHalaman.Location = new System.Drawing.Point(598, 442);
            this.labelHalaman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHalaman.Name = "labelHalaman";
            this.labelHalaman.Size = new System.Drawing.Size(82, 25);
            this.labelHalaman.TabIndex = 10;
            this.labelHalaman.Text = "Halaman";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Azure;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(202, 447);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(89, 38);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Next>";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.Azure;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(105, 447);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(89, 38);
            this.buttonPrev.TabIndex = 11;
            this.buttonPrev.Text = "<Prev";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // DashboardGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(874, 545);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelHalaman);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonInputNilai);
            this.Controls.Add(this.dataGridViewNilai);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.groupBoxJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardGuru";
            this.Text = "Dashboard Guru";
            this.groupBoxJudul.ResumeLayout(false);
            this.groupBoxJudul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxJudul;
        private System.Windows.Forms.Label labelNilai;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridViewNilai;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonInputNilai;
        private System.Windows.Forms.Label labelHalaman;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
    }
}