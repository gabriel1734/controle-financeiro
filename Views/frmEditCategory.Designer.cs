namespace controlefinanceiro.Views
{
    partial class frmEditCategory
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
            purpleLabel1 = new MeusControles.PurpleLabel();
            bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            purpleLabel2 = new MeusControles.PurpleLabel();
            bigTextBox2 = new ReaLTaiizor.Controls.BigTextBox();
            btnDoneEdit = new Button();
            btnEraseCat = new Button();
            SuspendLayout();
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(12, 9);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(108, 19);
            purpleLabel1.TabIndex = 0;
            purpleLabel1.Text = "Name Before";
            // 
            // bigTextBox1
            // 
            bigTextBox1.BackColor = Color.Transparent;
            bigTextBox1.Enabled = false;
            bigTextBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBox1.ForeColor = Color.FromArgb(149, 88, 225);
            bigTextBox1.Image = null;
            bigTextBox1.Location = new Point(126, 9);
            bigTextBox1.MaxLength = 32767;
            bigTextBox1.Multiline = false;
            bigTextBox1.Name = "bigTextBox1";
            bigTextBox1.ReadOnly = false;
            bigTextBox1.Size = new Size(188, 41);
            bigTextBox1.TabIndex = 4;
            bigTextBox1.TextAlignment = HorizontalAlignment.Left;
            bigTextBox1.UseSystemPasswordChar = false;
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(39, 56);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(81, 19);
            purpleLabel2.TabIndex = 5;
            purpleLabel2.Text = "New Name";
            // 
            // bigTextBox2
            // 
            bigTextBox2.BackColor = Color.Transparent;
            bigTextBox2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBox2.ForeColor = Color.FromArgb(149, 88, 225);
            bigTextBox2.Image = null;
            bigTextBox2.Location = new Point(126, 56);
            bigTextBox2.MaxLength = 32767;
            bigTextBox2.Multiline = false;
            bigTextBox2.Name = "bigTextBox2";
            bigTextBox2.ReadOnly = false;
            bigTextBox2.Size = new Size(188, 41);
            bigTextBox2.TabIndex = 6;
            bigTextBox2.TextAlignment = HorizontalAlignment.Left;
            bigTextBox2.UseSystemPasswordChar = false;
            // 
            // btnDoneEdit
            // 
            btnDoneEdit.BackColor = Color.FromArgb(149, 88, 225);
            btnDoneEdit.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoneEdit.ForeColor = Color.White;
            btnDoneEdit.Location = new Point(206, 103);
            btnDoneEdit.Name = "btnDoneEdit";
            btnDoneEdit.Size = new Size(108, 42);
            btnDoneEdit.TabIndex = 24;
            btnDoneEdit.Text = "Done";
            btnDoneEdit.UseVisualStyleBackColor = false;
            // 
            // btnEraseCat
            // 
            btnEraseCat.BackColor = Color.FromArgb(192, 0, 0);
            btnEraseCat.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEraseCat.ForeColor = Color.White;
            btnEraseCat.Location = new Point(12, 103);
            btnEraseCat.Name = "btnEraseCat";
            btnEraseCat.Size = new Size(151, 42);
            btnEraseCat.TabIndex = 25;
            btnEraseCat.Text = "Erase Category";
            btnEraseCat.UseVisualStyleBackColor = false;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 156);
            Controls.Add(btnEraseCat);
            Controls.Add(btnDoneEdit);
            Controls.Add(bigTextBox2);
            Controls.Add(purpleLabel2);
            Controls.Add(bigTextBox1);
            Controls.Add(purpleLabel1);
            Name = "frmEditCategory";
            Text = "frmEditCategory";
            Load += frmEditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private MeusControles.PurpleLabel purpleLabel2;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox2;
        private Button btnDoneEdit;
        private Button btnEraseCat;
    }
}