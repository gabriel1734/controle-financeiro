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
            label1 = new Label();
            label2 = new Label();
            purpleLabel1 = new MeusControles.PurpleLabel();
            panel3 = new Panel();
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
            txtUsername.Size = new Size(175, 18);
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
            txtPassword.Size = new Size(175, 18);
            txtPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 32F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(149, 88, 225);
            label1.Location = new Point(105, 22);
            label1.Name = "label1";
            label1.Size = new Size(177, 64);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(149, 88, 225);
            label2.Location = new Point(82, 116);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(82, 186);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(116, 28);
            purpleLabel1.TabIndex = 11;
            purpleLabel1.Text = "Password";
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
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 412);
            Controls.Add(panel3);
            Controls.Add(purpleLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private MeusControles.PurpleLabel purpleLabel1;
        private Panel panel3;
        private TextBox txtPassword;
    }
}
