﻿namespace E_Raport_SMA
{
    partial class InputNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputNilai));
            groupBox1 = new GroupBox();
            inpMapel = new TextBox();
            inpNilai = new TextBox();
            inputNama = new TextBox();
            inputNis = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSimpan = new Button();
            groupBox2 = new GroupBox();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inpMapel);
            groupBox1.Controls.Add(inpNilai);
            groupBox1.Controls.Add(inputNama);
            groupBox1.Controls.Add(inputNis);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(49, 113);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(633, 315);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Input Nilai";
            // 
            // inpMapel
            // 
            inpMapel.Location = new Point(190, 168);
            inpMapel.Margin = new Padding(4, 5, 4, 5);
            inpMapel.Name = "inpMapel";
            inpMapel.PlaceholderText = "Masukkan Mata Pelajaran";
            inpMapel.ReadOnly = true;
            inpMapel.Size = new Size(251, 33);
            inpMapel.TabIndex = 12;
            // 
            // inpNilai
            // 
            inpNilai.Location = new Point(190, 223);
            inpNilai.Margin = new Padding(4, 5, 4, 5);
            inpNilai.Name = "inpNilai";
            inpNilai.PlaceholderText = "Masukkan Nilai";
            inpNilai.Size = new Size(251, 33);
            inpNilai.TabIndex = 9;
            // 
            // inputNama
            // 
            inputNama.Location = new Point(191, 115);
            inputNama.Margin = new Padding(4, 5, 4, 5);
            inputNama.Name = "inputNama";
            inputNama.PlaceholderText = "Masukkan Nama Siswa";
            inputNama.ReadOnly = true;
            inputNama.Size = new Size(251, 33);
            inputNama.TabIndex = 6;
            // 
            // inputNis
            // 
            inputNis.Location = new Point(191, 63);
            inputNis.Margin = new Padding(4, 5, 4, 5);
            inputNis.Name = "inputNis";
            inputNis.PlaceholderText = "Masukkan NIS";
            inputNis.ReadOnly = true;
            inputNis.Size = new Size(251, 33);
            inputNis.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 226);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 28);
            label6.TabIndex = 4;
            label6.Text = "Nilai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 171);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 2;
            label4.Text = "Mapel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 1;
            label3.Text = "Nama Siswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 0;
            label2.Text = "NIS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(241, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 45);
            label1.TabIndex = 1;
            label1.Text = "Input Nilai Siswa";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LightSkyBlue;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(9, 37);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(107, 47);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Location = new Point(49, 445);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(633, 100);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SlateGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(519, 37);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 47);
            btnBack.TabIndex = 14;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // InputNilai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(751, 595);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "InputNilai";
            Text = "InputNilai";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox inpNilai;
        private TextBox inputNama;
        private TextBox inputNis;
        private Button btnSimpan;
        private GroupBox groupBox2;
        private Button btnBack;
        private TextBox inpMapel;
    }
}