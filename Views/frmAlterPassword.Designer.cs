namespace controlefinanceiro.Views
{
    partial class frmAlterPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterPassword));
            btnLogin = new ePOSOne.btnProduct.Button_WOC();
            purpleLabel2 = new MeusControles.PurpleLabel();
            panel3 = new Panel();
            txtConfirmPassword = new TextBox();
            purpleLabel1 = new MeusControles.PurpleLabel();
            panel2 = new Panel();
            txtPassword = new TextBox();
            panel3.SuspendLayout();
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
            btnLogin.Location = new Point(72, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.OnHoverBorderColor = Color.Transparent;
            btnLogin.OnHoverButtonColor = Color.Transparent;
            btnLogin.OnHoverTextColor = Color.Transparent;
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(100, 100);
            btnLogin.TabIndex = 24;
            btnLogin.TextAlign = ContentAlignment.BottomLeft;
            btnLogin.TextColor = Color.Transparent;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(32, 166);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(170, 22);
            purpleLabel2.TabIndex = 23;
            purpleLabel2.Text = "Confirm Password";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(txtConfirmPassword);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(32, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 40);
            panel3.TabIndex = 22;
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
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(32, 98);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(90, 22);
            purpleLabel1.TabIndex = 21;
            purpleLabel1.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(txtPassword);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(32, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 40);
            panel2.TabIndex = 20;
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
            // frmAlterPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 450);
            Controls.Add(btnLogin);
            Controls.Add(purpleLabel2);
            Controls.Add(panel3);
            Controls.Add(purpleLabel1);
            Controls.Add(panel2);
            Name = "frmAlterPassword";
            Text = "frmAlterPassword";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnLogin;
        private MeusControles.PurpleLabel purpleLabel2;
        private Panel panel3;
        private TextBox txtConfirmPassword;
        private MeusControles.PurpleLabel purpleLabel1;
        private Panel panel2;
        private TextBox txtPassword;
    }
}