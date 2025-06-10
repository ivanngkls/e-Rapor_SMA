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
            welcomeLabel = new Label();
            inputNilaiButton = new Button();
            kelasButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;

            welcomeLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(305, 73);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(417, 70);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Selamat Datang";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputNilaiButton
            // 
            inputNilaiButton.Location = new Point(331, 239);
            inputNilaiButton.Name = "inputNilaiButton";
            inputNilaiButton.Size = new Size(324, 50);
            inputNilaiButton.TabIndex = 1;
            inputNilaiButton.Text = "Input Nilai";
            inputNilaiButton.UseVisualStyleBackColor = true;
            inputNilaiButton.Click += inputNilaiButton_Click;
            // 
            // kelasButton
            // 
            kelasButton.Location = new Point(331, 324);
            kelasButton.Name = "kelasButton";
            kelasButton.Size = new Size(324, 50);
            kelasButton.TabIndex = 2;
            kelasButton.Text = "Lihat Kelas";
            kelasButton.UseVisualStyleBackColor = true;
            kelasButton.Click += kelasButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(331, 410);
            button1.Name = "button1";
            button1.Size = new Size(324, 50);
            button1.TabIndex = 3;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(976, 628);
            Controls.Add(button1);
            Controls.Add(kelasButton);
            Controls.Add(inputNilaiButton);
            Controls.Add(welcomeLabel);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button inputNilaiButton;
        private Button kelasButton;
        private Button button1;
    }
}