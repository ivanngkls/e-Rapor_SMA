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
            inputNIP = new TextBox();
            inputPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 45);
            label1.TabIndex = 0;
            label1.Text = "Login to E-Raport";
            label1.Click += label1_Click;
            // 
            // NIPLabel
            // 
            NIPLabel.AutoSize = true;
            NIPLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NIPLabel.Location = new Point(103, 167);
            NIPLabel.Margin = new Padding(4, 0, 4, 0);
            NIPLabel.Name = "NIPLabel";
            NIPLabel.Size = new Size(39, 20);
            NIPLabel.TabIndex = 1;
            NIPLabel.Text = "NIP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 238);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // inputNIP
            // 
            inputNIP.Location = new Point(207, 160);
            inputNIP.Margin = new Padding(4, 5, 4, 5);
            inputNIP.Name = "inputNIP";
            inputNIP.PlaceholderText = "Masukkan NIP";
            inputNIP.Size = new Size(228, 31);
            inputNIP.TabIndex = 3;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(207, 232);
            inputPassword.Margin = new Padding(4, 5, 4, 5);
            inputPassword.Name = "inputPassword";
            inputPassword.PlaceholderText = "Masukkan Password";
            inputPassword.Size = new Size(228, 31);
            inputPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.InactiveCaption;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.CausesValidation = false;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(219, 323);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(629, 497);
            Controls.Add(btnLogin);
            Controls.Add(inputPassword);
            Controls.Add(inputNIP);
            Controls.Add(label3);
            Controls.Add(NIPLabel);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label NIPLabel;
        private Label label3;
        private TextBox inputNIP;
        private TextBox inputPassword;
        private Button btnLogin;
    }
}
