namespace E_Raport_SMA
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            inputNis = new TextBox();
            inputNama = new TextBox();
            inpNilai = new TextBox();
            comboBoxMapel = new ComboBox();
            comboBoxSemester = new ComboBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxSemester);
            groupBox1.Controls.Add(comboBoxMapel);
            groupBox1.Controls.Add(inpNilai);
            groupBox1.Controls.Add(inputNama);
            groupBox1.Controls.Add(inputNis);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(34, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Input Nilai";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 26);
            label1.Name = "label1";
            label1.Size = new Size(179, 24);
            label1.TabIndex = 1;
            label1.Text = "Input Nilai Siswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 30);
            label2.Name = "label2";
            label2.Size = new Size(29, 17);
            label2.TabIndex = 0;
            label2.Text = "NIS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 61);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 1;
            label3.Text = "Nama Siswa";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 92);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 2;
            label4.Text = "Mapel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 123);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 3;
            label5.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 154);
            label6.Name = "label6";
            label6.Size = new Size(31, 17);
            label6.TabIndex = 4;
            label6.Text = "Niai";
            // 
            // inputNis
            // 
            inputNis.Location = new Point(135, 22);
            inputNis.Name = "inputNis";
            inputNis.Size = new Size(177, 25);
            inputNis.TabIndex = 5;
            // 
            // inputNama
            // 
            inputNama.Location = new Point(135, 53);
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(177, 25);
            inputNama.TabIndex = 6;
            // 
            // inpNilai
            // 
            inpNilai.Location = new Point(135, 146);
            inpNilai.Name = "inpNilai";
            inpNilai.Size = new Size(177, 25);
            inpNilai.TabIndex = 9;
            // 
            // comboBoxMapel
            // 
            comboBoxMapel.FormattingEnabled = true;
            comboBoxMapel.Location = new Point(135, 84);
            comboBoxMapel.Name = "comboBoxMapel";
            comboBoxMapel.Size = new Size(177, 25);
            comboBoxMapel.TabIndex = 10;
            // 
            // comboBoxSemester
            // 
            comboBoxSemester.FormattingEnabled = true;
            comboBoxSemester.Location = new Point(135, 115);
            comboBoxSemester.Name = "comboBoxSemester";
            comboBoxSemester.Size = new Size(177, 25);
            comboBoxSemester.TabIndex = 11;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(6, 22);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 28);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(87, 22);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 28);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Controls.Add(btnBatal);
            groupBox2.Location = new Point(34, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 60);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // InputNilai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 357);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox inpNilai;
        private TextBox inputNama;
        private TextBox inputNis;
        private Button btnBatal;
        private Button btnSimpan;
        private ComboBox comboBoxSemester;
        private ComboBox comboBoxMapel;
        private GroupBox groupBox2;
    }
}