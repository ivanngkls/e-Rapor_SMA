﻿namespace E_Raport_SMA
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label1.Location = new Point(183, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 45);
            label1.TabIndex = 0;
            label1.Text = "Data Nilai Siswa";
            // 
            // dataNilaiSiswa
            // 
            dataNilaiSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataNilaiSiswa.BackgroundColor = Color.White;
            dataNilaiSiswa.BorderStyle = BorderStyle.None;
            dataNilaiSiswa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataNilaiSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataNilaiSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataNilaiSiswa.DefaultCellStyle = dataGridViewCellStyle2;
            dataNilaiSiswa.EnableHeadersVisualStyles = false;
            dataNilaiSiswa.Location = new Point(99, 158);
            dataNilaiSiswa.Margin = new Padding(4, 5, 4, 5);
            dataNilaiSiswa.Name = "dataNilaiSiswa";
            dataNilaiSiswa.ReadOnly = true;
            dataNilaiSiswa.RowHeadersVisible = false;
            dataNilaiSiswa.RowHeadersWidth = 62;
            dataNilaiSiswa.Size = new Size(620, 365);
            dataNilaiSiswa.TabIndex = 1;
            dataNilaiSiswa.CellClick += dataNilaiSiswa_CellClick;
            // 
            // inputNilai
            // 
            inputNilai.BackColor = Color.LightSkyBlue;
            inputNilai.FlatStyle = FlatStyle.Flat;
            inputNilai.Location = new Point(461, 533);
            inputNilai.Margin = new Padding(4, 5, 4, 5);
            inputNilai.Name = "inputNilai";
            inputNilai.Size = new Size(120, 42);
            inputNilai.TabIndex = 2;
            inputNilai.Text = "Input Nilai";
            inputNilai.UseVisualStyleBackColor = false;
            inputNilai.Click += inputNilai_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(191, 117);
            txtCari.Margin = new Padding(4, 5, 4, 5);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari Nama Siswa";
            txtCari.Size = new Size(527, 31);
            txtCari.TabIndex = 3;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.Azure;
            btnCari.FlatStyle = FlatStyle.System;
            btnCari.Location = new Point(99, 110);
            btnCari.Margin = new Padding(4, 5, 4, 5);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(84, 42);
            btnCari.TabIndex = 4;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.LightSlateGray;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(589, 533);
            backBtn.Margin = new Padding(4, 5, 4, 5);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(120, 42);
            backBtn.TabIndex = 5;
            backBtn.Text = "Kembali";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(99, 25);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(620, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // DashboardGuru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(833, 590);
            Controls.Add(groupBox1);
            Controls.Add(backBtn);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(inputNilai);
            Controls.Add(dataNilaiSiswa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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