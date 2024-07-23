
namespace controlefinanceiro.Views
{
    partial class frmResetPassword
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
            purpleLabel2 = new MeusControles.PurpleLabel();
            txtPassword = new ReaLTaiizor.Controls.BigTextBox();
            purpleLabel1 = new MeusControles.PurpleLabel();
            txtConfirmPassword = new ReaLTaiizor.Controls.BigTextBox();
            btnReset = new Button();
            SuspendLayout();
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(48, 9);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(117, 19);
            purpleLabel2.TabIndex = 18;
            purpleLabel2.Text = "New Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(149, 88, 225);
            txtPassword.Image = null;
            txtPassword.Location = new Point(171, 9);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = false;
            txtPassword.Size = new Size(176, 41);
            txtPassword.TabIndex = 17;
            txtPassword.TextAlignment = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += valueTransaction_TextChanged;
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(12, 56);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(153, 19);
            purpleLabel1.TabIndex = 20;
            purpleLabel1.Text = "Confirm Password";
            purpleLabel1.Click += purpleLabel1_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.Transparent;
            txtConfirmPassword.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.FromArgb(149, 88, 225);
            txtConfirmPassword.Image = null;
            txtConfirmPassword.Location = new Point(171, 56);
            txtConfirmPassword.MaxLength = 32767;
            txtConfirmPassword.Multiline = false;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.ReadOnly = false;
            txtConfirmPassword.Size = new Size(176, 41);
            txtConfirmPassword.TabIndex = 19;
            txtConfirmPassword.TextAlignment = HorizontalAlignment.Left;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(149, 88, 225);
            btnReset.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(213, 103);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 51);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 163);
            Controls.Add(btnReset);
            Controls.Add(purpleLabel1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(purpleLabel2);
            Controls.Add(txtPassword);
            MaximumSize = new Size(386, 202);
            MinimumSize = new Size(386, 202);
            Name = "frmResetPassword";
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MeusControles.PurpleLabel purpleLabel2;
        private ReaLTaiizor.Controls.BigTextBox txtPassword;
        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtConfirmPassword;
        private Button btnReset;
    }
}