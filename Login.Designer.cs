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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            NIPLabel = new Label();
            label3 = new Label();
            txtNIP = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 33);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 0;
            label1.Text = "Login to E-Raport";
            // 
            // NIPLabel
            // 
            NIPLabel.AutoSize = true;
            NIPLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            NIPLabel.Location = new Point(84, 97);
            NIPLabel.Name = "NIPLabel";
            NIPLabel.Size = new Size(33, 17);
            NIPLabel.TabIndex = 1;
            NIPLabel.Text = "NIP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label3.Location = new Point(84, 139);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtNIP
            // 
            txtNIP.Font = new Font("Segoe UI", 10F);
            txtNIP.Location = new Point(183, 91);
            txtNIP.Name = "txtNIP";
            txtNIP.PlaceholderText = "Masukkan NIP";
            txtNIP.Size = new Size(148, 25);
            txtNIP.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(183, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan Password";
            txtPassword.Size = new Size(148, 25);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.CausesValidation = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(161, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtNIP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NIPLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 272);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(526, 357);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label NIPLabel;
        private Label label3;
        private TextBox txtNIP;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel panel1;
    }
}
