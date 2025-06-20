namespace E_Raport_SMA_Pemvis_Project
{
    partial class CetakRaport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CetakRaport));
            this.groupBoxRaport = new System.Windows.Forms.GroupBox();
            this.labelRaport = new System.Windows.Forms.Label();
            this.dataGridViewRaport = new System.Windows.Forms.DataGridView();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonCetakRapor = new System.Windows.Forms.Button();
            this.groupBoxRaport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRaport
            // 
            this.groupBoxRaport.Controls.Add(this.labelRaport);
            this.groupBoxRaport.Location = new System.Drawing.Point(29, 13);
            this.groupBoxRaport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRaport.Name = "groupBoxRaport";
            this.groupBoxRaport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRaport.Size = new System.Drawing.Size(923, 130);
            this.groupBoxRaport.TabIndex = 2;
            this.groupBoxRaport.TabStop = false;
            // 
            // labelRaport
            // 
            this.labelRaport.AutoSize = true;
            this.labelRaport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelRaport.Location = new System.Drawing.Point(381, 0);
            this.labelRaport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRaport.Name = "labelRaport";
            this.labelRaport.Size = new System.Drawing.Size(204, 45);
            this.labelRaport.TabIndex = 2;
            this.labelRaport.Text = "Rapor Siswa";
            // 
            // dataGridViewRaport
            // 
            this.dataGridViewRaport.AllowUserToOrderColumns = true;
            this.dataGridViewRaport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRaport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRaport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaport.Location = new System.Drawing.Point(29, 153);
            this.dataGridViewRaport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRaport.Name = "dataGridViewRaport";
            this.dataGridViewRaport.RowHeadersWidth = 62;
            this.dataGridViewRaport.Size = new System.Drawing.Size(923, 388);
            this.dataGridViewRaport.TabIndex = 16;
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKembali.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(836, 551);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(113, 52);
            this.buttonKembali.TabIndex = 18;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonCetakRapor
            // 
            this.buttonCetakRapor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCetakRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCetakRapor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetakRapor.Location = new System.Drawing.Point(29, 551);
            this.buttonCetakRapor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCetakRapor.Name = "buttonCetakRapor";
            this.buttonCetakRapor.Size = new System.Drawing.Size(140, 52);
            this.buttonCetakRapor.TabIndex = 17;
            this.buttonCetakRapor.Text = "Cetak Rapor";
            this.buttonCetakRapor.UseVisualStyleBackColor = false;
            this.buttonCetakRapor.Click += new System.EventHandler(this.buttonCetakRapor_Click);
            // 
            // CetakRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(976, 628);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonCetakRapor);
            this.Controls.Add(this.dataGridViewRaport);
            this.Controls.Add(this.groupBoxRaport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CetakRaport";
            this.Text = "Cetak Raport";
            this.groupBoxRaport.ResumeLayout(false);
            this.groupBoxRaport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRaport;
        private System.Windows.Forms.Label labelRaport;
        private System.Windows.Forms.DataGridView dataGridViewRaport;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonCetakRapor;
    }
}