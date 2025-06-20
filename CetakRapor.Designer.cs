namespace E_Raport_SMA
{
    partial class CetakRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CetakRapor));
            label1 = new Label();
            semester = new ComboBox();
            label2 = new Label();
            raporSiswa = new DataGridView();
            btnCetak = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)raporSiswa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 0;
            label1.Text = "Rapor Siswa";
            // 
            // semester
            // 
            semester.FormattingEnabled = true;
            semester.Location = new Point(130, 82);
            semester.Margin = new Padding(4, 5, 4, 5);
            semester.Name = "semester";
            semester.Size = new Size(203, 33);
            semester.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Semester";
            // 
            // raporSiswa
            // 
            raporSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            raporSiswa.BackgroundColor = Color.White;
            raporSiswa.BorderStyle = BorderStyle.None;
            raporSiswa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            raporSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            raporSiswa.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            raporSiswa.DefaultCellStyle = dataGridViewCellStyle2;
            raporSiswa.EnableHeadersVisualStyles = false;
            raporSiswa.GridColor = SystemColors.MenuText;
            raporSiswa.Location = new Point(29, 153);
            raporSiswa.Margin = new Padding(4, 5, 4, 5);
            raporSiswa.Name = "raporSiswa";
            raporSiswa.ReadOnly = true;
            raporSiswa.RowHeadersVisible = false;
            raporSiswa.RowHeadersWidth = 62;
            raporSiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            raporSiswa.Size = new Size(923, 388);
            raporSiswa.TabIndex = 3;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.LightSkyBlue;
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Location = new Point(29, 552);
            btnCetak.Margin = new Padding(4, 5, 4, 5);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(136, 38);
            btnCetak.TabIndex = 4;
            btnCetak.Text = "Cetak Rapor";
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Click += btnCetak_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSlateGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(173, 552);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 38);
            btnBack.TabIndex = 5;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(semester);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 13);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(923, 130);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // CetakRapor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(976, 628);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnCetak);
            Controls.Add(raporSiswa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "CetakRapor";
            Text = "CetakRapor";
            ((System.ComponentModel.ISupportInitialize)raporSiswa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox semester;
        private Label label2;
        private DataGridView raporSiswa;
        private Button btnCetak;
        private Button btnBack;
        private GroupBox groupBox1;
    }
}