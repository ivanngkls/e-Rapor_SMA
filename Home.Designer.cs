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
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(311, 82);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(183, 32);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Selamat Datang";
            // 
            // inputNilaiButton
            // 
            inputNilaiButton.Location = new Point(343, 155);
            inputNilaiButton.Name = "inputNilaiButton";
            inputNilaiButton.Size = new Size(112, 34);
            inputNilaiButton.TabIndex = 1;
            inputNilaiButton.Text = "Input Nilai";
            inputNilaiButton.UseVisualStyleBackColor = true;
            // 
            // kelasButton
            // 
            kelasButton.Location = new Point(343, 205);
            kelasButton.Name = "kelasButton";
            kelasButton.Size = new Size(112, 34);
            kelasButton.TabIndex = 2;
            kelasButton.Text = "Lihat Kelas";
            kelasButton.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}