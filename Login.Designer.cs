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
            label2 = new Label();
            label3 = new Label();
            inputUsn = new TextBox();
            inputPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 46);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "Login to E-Raport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 13);
            label2.TabIndex = 1;
            label2.Text = "Username";
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
            // inputUsn
            // 
            inputUsn.Location = new Point(145, 96);
            inputUsn.Name = "inputUsn";
            inputUsn.Size = new Size(161, 23);
            inputUsn.TabIndex = 3;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(145, 139);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(161, 23);
            inputPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.InactiveCaption;
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
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(440, 298);
            Controls.Add(btnLogin);
            Controls.Add(inputPassword);
            Controls.Add(inputUsn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputUsn;
        private TextBox inputPassword;
        private Button btnLogin;
    }
}
