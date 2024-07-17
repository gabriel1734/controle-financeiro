namespace controlefinanceiro
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new ePOSOne.btnProduct.Button_WOC();
            txtUsername = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPassword = new TextBox();
            lblLogin = new Label();
            lblUsername = new Label();
            panel3 = new Panel();
            lblPassword = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BorderColor = Color.Transparent;
            btnLogin.ButtonColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(128, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.OnHoverBorderColor = Color.Transparent;
            btnLogin.OnHoverButtonColor = Color.Transparent;
            btnLogin.OnHoverTextColor = Color.Transparent;
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(100, 100);
            btnLogin.TabIndex = 3;
            btnLogin.TextAlign = ContentAlignment.BottomLeft;
            btnLogin.TextColor = Color.Transparent;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Consolas", 9F, FontStyle.Bold);
            txtUsername.ForeColor = Color.FromArgb(149, 88, 225);
            txtUsername.Location = new Point(9, 11);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(175, 15);
            txtUsername.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(txtUsername);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(82, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 40);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(txtPassword);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(82, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 40);
            panel2.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Consolas", 9F, FontStyle.Bold);
            txtPassword.ForeColor = Color.FromArgb(149, 88, 225);
            txtPassword.Location = new Point(9, 11);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 15);
            txtPassword.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Consolas", 32F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(149, 88, 225);
            lblLogin.Location = new Point(105, 22);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(142, 51);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(149, 88, 225);
            lblUsername.Location = new Point(82, 116);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(90, 22);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.FromArgb(149, 88, 225);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(449, -25);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 449);
            panel3.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(149, 88, 225);
            lblPassword.Location = new Point(82, 184);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 22);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(lblPassword);
            Controls.Add(panel3);
            Controls.Add(lblUsername);
            Controls.Add(lblLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Transparent;
            MaximumSize = new Size(816, 459);
            MinimumSize = new Size(816, 459);
            Name = "frmLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnLogin;
        private TextBox txtUsername;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label lblLogin;
        private Label lblUsername;
        private Panel panel3;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}
