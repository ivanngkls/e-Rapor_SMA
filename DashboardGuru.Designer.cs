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
            txtCari = new TextBox();
            btnCari = new Button();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 5);
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
            dataGridView1.Location = new Point(19, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(430, 219);
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
            inputNilai.BackColor = Color.Transparent;
            inputNilai.Location = new Point(19, 322);
            inputNilai.Name = "inputNilai";
            inputNilai.Size = new Size(84, 25);
            inputNilai.TabIndex = 2;
            inputNilai.Text = "Input Nilai";
            inputNilai.UseVisualStyleBackColor = false;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(79, 68);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari Nama Siswa";
            txtCari.Size = new Size(370, 23);
            txtCari.TabIndex = 3;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(22, 68);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(51, 23);
            btnCari.TabIndex = 4;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Location = new Point(365, 322);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(84, 25);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 45);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // DashboardGuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(487, 371);
            Controls.Add(groupBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(inputNilai);
            Controls.Add(dataGridView1);
            Name = "DashboardGuru";
            Text = "Dashboard";
            Load += DashboardGuru_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox txtCari;
        private Button btnCari;
        private Button btnLogout;
        private GroupBox groupBox1;
    }
}