namespace E_Raport_SMA_Pemvis_Project
{
    partial class Beranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonNilai = new System.Windows.Forms.Button();
            this.buttonKelas = new System.Windows.Forms.Button();
            this.labelSelamatDatang = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelKelas = new System.Windows.Forms.Label();
            this.flowLayoutPanelKelas = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Azure;
            this.panelMenu.Controls.Add(this.buttonKeluar);
            this.panelMenu.Controls.Add(this.buttonNilai);
            this.panelMenu.Controls.Add(this.buttonKelas);
            this.panelMenu.Controls.Add(this.labelSelamatDatang);
            this.panelMenu.Location = new System.Drawing.Point(-10, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(502, 638);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.Location = new System.Drawing.Point(86, 402);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(324, 49);
            this.buttonKeluar.TabIndex = 3;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonNilai
            // 
            this.buttonNilai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNilai.Location = new System.Drawing.Point(86, 328);
            this.buttonNilai.Name = "buttonNilai";
            this.buttonNilai.Size = new System.Drawing.Size(324, 49);
            this.buttonNilai.TabIndex = 2;
            this.buttonNilai.Text = "Input Nilai";
            this.buttonNilai.UseVisualStyleBackColor = false;
            this.buttonNilai.Click += new System.EventHandler(this.buttonNilai_Click);
            // 
            // buttonKelas
            // 
            this.buttonKelas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKelas.Location = new System.Drawing.Point(86, 251);
            this.buttonKelas.Name = "buttonKelas";
            this.buttonKelas.Size = new System.Drawing.Size(324, 49);
            this.buttonKelas.TabIndex = 1;
            this.buttonKelas.Text = "Lihat Kelas";
            this.buttonKelas.UseVisualStyleBackColor = false;
            this.buttonKelas.Click += new System.EventHandler(this.buttonKelas_Click);
            // 
            // labelSelamatDatang
            // 
            this.labelSelamatDatang.AutoSize = true;
            this.labelSelamatDatang.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.labelSelamatDatang.Location = new System.Drawing.Point(44, 83);
            this.labelSelamatDatang.Name = "labelSelamatDatang";
            this.labelSelamatDatang.Size = new System.Drawing.Size(411, 59);
            this.labelSelamatDatang.TabIndex = 0;
            this.labelSelamatDatang.Text = "Selamat Datang";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelJudul.ForeColor = System.Drawing.Color.Azure;
            this.labelJudul.Location = new System.Drawing.Point(580, 83);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(285, 63);
            this.labelJudul.TabIndex = 4;
            this.labelJudul.Text = "E-Raport";
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.labelKelas.ForeColor = System.Drawing.Color.Azure;
            this.labelKelas.Location = new System.Drawing.Point(584, 511);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(132, 43);
            this.labelKelas.TabIndex = 5;
            this.labelKelas.Text = "Kelas";
            // 
            // flowLayoutPanelKelas
            // 
            this.flowLayoutPanelKelas.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanelKelas.Location = new System.Drawing.Point(591, 149);
            this.flowLayoutPanelKelas.Name = "flowLayoutPanelKelas";
            this.flowLayoutPanelKelas.Size = new System.Drawing.Size(300, 342);
            this.flowLayoutPanelKelas.TabIndex = 6;
            // 
            // Beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(976, 628);
            this.Controls.Add(this.flowLayoutPanelKelas);
            this.Controls.Add(this.labelKelas);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Beranda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beranda";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelSelamatDatang;
        private System.Windows.Forms.Button buttonKelas;
        private System.Windows.Forms.Button buttonNilai;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKelas;
    }
}