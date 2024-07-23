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
            nameCategoria = new ReaLTaiizor.Controls.BigTextBox();
            purpleLabel2 = new MeusControles.PurpleLabel();
            newNameCategoria = new ReaLTaiizor.Controls.BigTextBox();
            btnDoneEdit = new Button();
            btnEraseCat = new Button();
            purpleLabel3 = new MeusControles.PurpleLabel();
            idCategoria = new ReaLTaiizor.Controls.BigTextBox();
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
            // nameCategoria
            // 
            nameCategoria.BackColor = Color.Transparent;
            nameCategoria.Enabled = false;
            nameCategoria.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameCategoria.ForeColor = Color.FromArgb(149, 88, 225);
            nameCategoria.Image = null;
            nameCategoria.Location = new Point(126, 9);
            nameCategoria.MaxLength = 32767;
            nameCategoria.Multiline = false;
            nameCategoria.Name = "nameCategoria";
            nameCategoria.ReadOnly = false;
            nameCategoria.Size = new Size(188, 41);
            nameCategoria.TabIndex = 4;
            nameCategoria.TextAlignment = HorizontalAlignment.Left;
            nameCategoria.UseSystemPasswordChar = false;
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(39, 91);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(81, 19);
            purpleLabel2.TabIndex = 5;
            purpleLabel2.Text = "New Name";
            // 
            // newNameCategoria
            // 
            newNameCategoria.BackColor = Color.Transparent;
            newNameCategoria.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newNameCategoria.ForeColor = Color.FromArgb(149, 88, 225);
            newNameCategoria.Image = null;
            newNameCategoria.Location = new Point(126, 91);
            newNameCategoria.MaxLength = 32767;
            newNameCategoria.Multiline = false;
            newNameCategoria.Name = "newNameCategoria";
            newNameCategoria.ReadOnly = false;
            newNameCategoria.Size = new Size(188, 41);
            newNameCategoria.TabIndex = 6;
            newNameCategoria.TextAlignment = HorizontalAlignment.Left;
            newNameCategoria.UseSystemPasswordChar = false;
            // 
            // btnDoneEdit
            // 
            btnDoneEdit.BackColor = Color.FromArgb(149, 88, 225);
            btnDoneEdit.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoneEdit.ForeColor = Color.White;
            btnDoneEdit.Location = new Point(206, 137);
            btnDoneEdit.Name = "btnDoneEdit";
            btnDoneEdit.Size = new Size(108, 42);
            btnDoneEdit.TabIndex = 24;
            btnDoneEdit.Text = "Done";
            btnDoneEdit.UseVisualStyleBackColor = false;
            btnDoneEdit.Click += btnDoneEdit_Click;
            // 
            // btnEraseCat
            // 
            btnEraseCat.BackColor = Color.FromArgb(192, 0, 0);
            btnEraseCat.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEraseCat.ForeColor = Color.White;
            btnEraseCat.Location = new Point(12, 137);
            btnEraseCat.Name = "btnEraseCat";
            btnEraseCat.Size = new Size(151, 42);
            btnEraseCat.TabIndex = 25;
            btnEraseCat.Text = "Erase Category";
            btnEraseCat.UseVisualStyleBackColor = false;
            btnEraseCat.Click += btnEraseCat_Click;
            // 
            // purpleLabel3
            // 
            purpleLabel3.AutoSize = true;
            purpleLabel3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel3.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel3.Location = new Point(39, 58);
            purpleLabel3.Name = "purpleLabel3";
            purpleLabel3.Size = new Size(27, 19);
            purpleLabel3.TabIndex = 26;
            purpleLabel3.Text = "ID";
            purpleLabel3.TextAlign = ContentAlignment.TopCenter;
            // 
            // idCategoria
            // 
            idCategoria.BackColor = Color.Transparent;
            idCategoria.Enabled = false;
            idCategoria.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idCategoria.ForeColor = Color.FromArgb(149, 88, 225);
            idCategoria.Image = null;
            idCategoria.Location = new Point(125, 49);
            idCategoria.MaxLength = 32767;
            idCategoria.Multiline = false;
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = false;
            idCategoria.Size = new Size(52, 41);
            idCategoria.TabIndex = 27;
            idCategoria.TextAlignment = HorizontalAlignment.Left;
            idCategoria.UseSystemPasswordChar = false;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 210);
            Controls.Add(idCategoria);
            Controls.Add(purpleLabel3);
            Controls.Add(btnEraseCat);
            Controls.Add(btnDoneEdit);
            Controls.Add(newNameCategoria);
            Controls.Add(purpleLabel2);
            Controls.Add(nameCategoria);
            Controls.Add(purpleLabel1);
            MaximumSize = new Size(381, 249);
            MinimumSize = new Size(381, 249);
            Name = "frmEditCategory";
            Text = "frmEditCategory";
            Load += frmEditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.BigTextBox nameCategoria;
        private MeusControles.PurpleLabel purpleLabel2;
        private ReaLTaiizor.Controls.BigTextBox newNameCategoria;
        private Button btnDoneEdit;
        private Button btnEraseCat;
        private MeusControles.PurpleLabel purpleLabel3;
        private ReaLTaiizor.Controls.BigTextBox idCategoria;
    }
}