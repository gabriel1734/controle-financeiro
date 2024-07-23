namespace controlefinanceiro.Views
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            purpleLabel1 = new MeusControles.PurpleLabel();
            label2 = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            panel1 = new Panel();
            txtUsername = new TextBox();
            label1 = new Label();
            purpleLabel2 = new MeusControles.PurpleLabel();
            panel3 = new Panel();
            txtConfirmPassword = new TextBox();
            btnLogin = new ePOSOne.btnProduct.Button_WOC();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(61, 169);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(90, 22);
            purpleLabel1.TabIndex = 15;
            purpleLabel1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(149, 88, 225);
            label2.Location = new Point(61, 94);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(txtPassword);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(61, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 40);
            panel2.TabIndex = 13;
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(txtUsername);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(61, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 40);
            panel1.TabIndex = 12;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 32F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(149, 88, 225);
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 51);
            label1.TabIndex = 16;
            label1.Text = "Register";
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(61, 237);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(170, 22);
            purpleLabel2.TabIndex = 18;
            purpleLabel2.Text = "Confirm Password";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(txtConfirmPassword);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(61, 262);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 40);
            panel3.TabIndex = 17;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Consolas", 9F, FontStyle.Bold);
            txtConfirmPassword.ForeColor = Color.FromArgb(149, 88, 225);
            txtConfirmPassword.Location = new Point(9, 11);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(175, 15);
            txtConfirmPassword.TabIndex = 5;
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
            btnLogin.Location = new Point(101, 323);
            btnLogin.MaximumSize = new Size(100, 100);
            btnLogin.MinimumSize = new Size(100, 100);
            btnLogin.Name = "btnLogin";
            btnLogin.OnHoverBorderColor = Color.Transparent;
            btnLogin.OnHoverButtonColor = Color.Transparent;
            btnLogin.OnHoverTextColor = Color.Transparent;
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(100, 100);
            btnLogin.TabIndex = 19;
            btnLogin.TextAlign = ContentAlignment.BottomLeft;
            btnLogin.TextColor = Color.Transparent;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 450);
            Controls.Add(btnLogin);
            Controls.Add(purpleLabel2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(purpleLabel1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRegister";
            Text = "Cadastro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MeusControles.PurpleLabel purpleLabel1;
        private Label label2;
        private Panel panel2;
        private TextBox txtPassword;
        private Panel panel1;
        private TextBox txtUsername;
        private Label label1;
        private MeusControles.PurpleLabel purpleLabel2;
        private Panel panel3;
        private TextBox txtConfirmPassword;
        private ePOSOne.btnProduct.Button_WOC btnLogin;
    }
}