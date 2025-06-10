namespace E_Raport_SMA
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NIPLabel = new Label();
            label3 = new Label();
            txtNIP = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 43);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "Login to E-Raport";
            // 
            // NIPLabel
            // 
            NIPLabel.AutoSize = true;
            NIPLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NIPLabel.Location = new Point(74, 100);
            NIPLabel.Name = "NIPLabel";
            NIPLabel.Size = new Size(28, 13);
            NIPLabel.TabIndex = 1;
            NIPLabel.Text = "NIP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 143);
            label3.Name = "label3";
            label3.Size = new Size(61, 13);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtNIP
            // 
            txtNIP.Location = new Point(145, 96);
            txtNIP.Name = "txtNIP";
            txtNIP.PlaceholderText = "Masukkan NIP";
            txtNIP.Size = new Size(161, 23);
            txtNIP.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(145, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan Password";
            txtPassword.Size = new Size(161, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.CausesValidation = false;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(153, 194);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(440, 298);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtNIP);
            Controls.Add(label3);
            Controls.Add(NIPLabel);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label NIPLabel;
        private Label label3;
        private TextBox txtNIP;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
