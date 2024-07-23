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
            valueTransaction = new ReaLTaiizor.Controls.BigTextBox();
            purpleLabel1 = new MeusControles.PurpleLabel();
            bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(12, 9);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(153, 19);
            purpleLabel2.TabIndex = 18;
            purpleLabel2.Text = "Current Password";
            // 
            // valueTransaction
            // 
            valueTransaction.BackColor = Color.Transparent;
            valueTransaction.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valueTransaction.ForeColor = Color.FromArgb(149, 88, 225);
            valueTransaction.Image = null;
            valueTransaction.Location = new Point(171, 9);
            valueTransaction.MaxLength = 32767;
            valueTransaction.Multiline = false;
            valueTransaction.Name = "valueTransaction";
            valueTransaction.ReadOnly = false;
            valueTransaction.Size = new Size(176, 41);
            valueTransaction.TabIndex = 17;
            valueTransaction.TextAlignment = HorizontalAlignment.Left;
            valueTransaction.UseSystemPasswordChar = false;
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(48, 56);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(117, 19);
            purpleLabel1.TabIndex = 20;
            purpleLabel1.Text = "New Password";
            // 
            // bigTextBox1
            // 
            bigTextBox1.BackColor = Color.Transparent;
            bigTextBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBox1.ForeColor = Color.FromArgb(149, 88, 225);
            bigTextBox1.Image = null;
            bigTextBox1.Location = new Point(171, 56);
            bigTextBox1.MaxLength = 32767;
            bigTextBox1.Multiline = false;
            bigTextBox1.Name = "bigTextBox1";
            bigTextBox1.ReadOnly = false;
            bigTextBox1.Size = new Size(176, 41);
            bigTextBox1.TabIndex = 19;
            bigTextBox1.TextAlignment = HorizontalAlignment.Left;
            bigTextBox1.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(149, 88, 225);
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(213, 103);
            button1.Name = "button1";
            button1.Size = new Size(134, 51);
            button1.TabIndex = 22;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 163);
            Controls.Add(button1);
            Controls.Add(purpleLabel1);
            Controls.Add(bigTextBox1);
            Controls.Add(purpleLabel2);
            Controls.Add(valueTransaction);
            Name = "frmResetPassword";
            Text = "Reset Password";
            Load += frmRestPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MeusControles.PurpleLabel purpleLabel2;
        private ReaLTaiizor.Controls.BigTextBox valueTransaction;
        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private Button button1;
    }
}