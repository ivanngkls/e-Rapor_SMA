namespace E_Raport_SMA
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            welcomeLabel = new Label();
            inputNilaiButton = new Button();
            kelasButton = new Button();
            button1 = new Button();
            kelasPanel = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(53, 67);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(417, 70);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Selamat Datang";
            welcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputNilaiButton
            // 
            inputNilaiButton.BackColor = Color.LightSkyBlue;
            inputNilaiButton.FlatStyle = FlatStyle.Flat;
            inputNilaiButton.Location = new Point(79, 304);
            inputNilaiButton.Name = "inputNilaiButton";
            inputNilaiButton.Size = new Size(324, 50);
            inputNilaiButton.TabIndex = 1;
            inputNilaiButton.Text = "Input Nilai";
            inputNilaiButton.UseVisualStyleBackColor = false;
            inputNilaiButton.Click += inputNilaiButton_Click;
            // 
            // kelasButton
            // 
            kelasButton.BackColor = Color.LightSkyBlue;
            kelasButton.FlatStyle = FlatStyle.Flat;
            kelasButton.Location = new Point(79, 224);
            kelasButton.Name = "kelasButton";
            kelasButton.Size = new Size(324, 50);
            kelasButton.TabIndex = 2;
            kelasButton.Text = "Lihat Kelas";
            kelasButton.UseVisualStyleBackColor = false;
            kelasButton.Click += kelasButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(79, 382);
            button1.Name = "button1";
            button1.Size = new Size(324, 50);
            button1.TabIndex = 3;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // kelasPanel
            // 
            kelasPanel.BackColor = Color.Azure;
            kelasPanel.Location = new Point(587, 140);
            kelasPanel.Name = "kelasPanel";
            kelasPanel.Size = new Size(300, 342);
            kelasPanel.TabIndex = 4;
            kelasPanel.Paint += kelasPanel_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(600, 47);
            label1.Name = "label1";
            label1.Size = new Size(285, 63);
            label1.TabIndex = 5;
            label1.Text = "E-RAPORT";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(kelasButton);
            panel1.Controls.Add(inputNilaiButton);
            panel1.Controls.Add(welcomeLabel);
            panel1.Location = new Point(-11, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 645);
            panel1.TabIndex = 6;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(976, 628);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(kelasPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button inputNilaiButton;
        private Button kelasButton;
        private Button button1;
        private FlowLayoutPanel kelasPanel;
        private Label label1;
        private Panel panel1;
    }
}