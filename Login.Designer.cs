namespace E_Raport_SMA_Pemvis_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNIP = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNIP = new System.Windows.Forms.Label();
            this.labelSelamatDatang = new System.Windows.Forms.Label();
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Azure;
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxNIP);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelNIP);
            this.panelLogin.Controls.Add(this.labelSelamatDatang);
            this.panelLogin.Controls.Add(this.buttonMasuk);
            this.panelLogin.Location = new System.Drawing.Point(188, 49);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(396, 452);
            this.panelLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(147, 258);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(210, 26);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNIP
            // 
            this.textBoxNIP.Location = new System.Drawing.Point(147, 208);
            this.textBoxNIP.Name = "textBoxNIP";
            this.textBoxNIP.Size = new System.Drawing.Size(210, 26);
            this.textBoxNIP.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(27, 262);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(92, 25);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNIP
            // 
            this.labelNIP.AutoSize = true;
            this.labelNIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNIP.Location = new System.Drawing.Point(27, 211);
            this.labelNIP.Name = "labelNIP";
            this.labelNIP.Size = new System.Drawing.Size(43, 25);
            this.labelNIP.TabIndex = 4;
            this.labelNIP.Text = "NIP";
            this.labelNIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSelamatDatang
            // 
            this.labelSelamatDatang.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelSelamatDatang.Location = new System.Drawing.Point(76, 26);
            this.labelSelamatDatang.Name = "labelSelamatDatang";
            this.labelSelamatDatang.Size = new System.Drawing.Size(249, 142);
            this.labelSelamatDatang.TabIndex = 2;
            this.labelSelamatDatang.Text = "Login to E-Raport";
            this.labelSelamatDatang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMasuk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasuk.Location = new System.Drawing.Point(32, 355);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(324, 49);
            this.buttonMasuk.TabIndex = 3;
            this.buttonMasuk.Text = "Login";
            this.buttonMasuk.UseVisualStyleBackColor = false;
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(789, 549);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonMasuk;
        private System.Windows.Forms.Label labelSelamatDatang;
        private System.Windows.Forms.Label labelNIP;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNIP;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}