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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            nis = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            nilai = new DataGridViewTextBoxColumn();
            inputNilai = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 30);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Data Nilai Siswa";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nis, nama, nilai });
            dataGridView1.Location = new Point(19, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(373, 175);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nis
            // 
            nis.HeaderText = "NIS";
            nis.Name = "nis";
            // 
            // nama
            // 
            nama.HeaderText = "Nama Siswa";
            nama.Name = "nama";
            // 
            // nilai
            // 
            nilai.HeaderText = "Nilai";
            nilai.Name = "nilai";
            // 
            // inputNilai
            // 
            inputNilai.BackColor = SystemColors.GradientActiveCaption;
            inputNilai.Location = new Point(296, 267);
            inputNilai.Name = "inputNilai";
            inputNilai.Size = new Size(84, 25);
            inputNilai.TabIndex = 2;
            inputNilai.Text = "Input Nilai";
            inputNilai.UseVisualStyleBackColor = false;
            // 
            // DashboardGuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(414, 303);
            Controls.Add(inputNilai);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DashboardGuru";
            Text = "DashboardGuru";
            Load += DashboardGuru_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn nilai;
        private Button inputNilai;
    }
}