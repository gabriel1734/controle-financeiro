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
            SuspendLayout();
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(14, 12);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(131, 23);
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
            nameCategoria.Location = new Point(144, 12);
            nameCategoria.Margin = new Padding(3, 4, 3, 4);
            nameCategoria.MaxLength = 32767;
            nameCategoria.Multiline = false;
            nameCategoria.Name = "nameCategoria";
            nameCategoria.ReadOnly = false;
            nameCategoria.Size = new Size(215, 45);
            nameCategoria.TabIndex = 4;
            nameCategoria.TextAlignment = HorizontalAlignment.Left;
            nameCategoria.UseSystemPasswordChar = false;
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(45, 75);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(98, 23);
            purpleLabel2.TabIndex = 5;
            purpleLabel2.Text = "New Name";
            // 
            // newNameCategoria
            // 
            newNameCategoria.BackColor = Color.Transparent;
            newNameCategoria.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newNameCategoria.ForeColor = Color.FromArgb(149, 88, 225);
            newNameCategoria.Image = null;
            newNameCategoria.Location = new Point(144, 75);
            newNameCategoria.Margin = new Padding(3, 4, 3, 4);
            newNameCategoria.MaxLength = 32767;
            newNameCategoria.Multiline = false;
            newNameCategoria.Name = "newNameCategoria";
            newNameCategoria.ReadOnly = false;
            newNameCategoria.Size = new Size(215, 45);
            newNameCategoria.TabIndex = 6;
            newNameCategoria.TextAlignment = HorizontalAlignment.Left;
            newNameCategoria.UseSystemPasswordChar = false;
            // 
            // btnDoneEdit
            // 
            btnDoneEdit.BackColor = Color.FromArgb(149, 88, 225);
            btnDoneEdit.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoneEdit.ForeColor = Color.White;
            btnDoneEdit.Location = new Point(235, 137);
            btnDoneEdit.Margin = new Padding(3, 4, 3, 4);
            btnDoneEdit.Name = "btnDoneEdit";
            btnDoneEdit.Size = new Size(123, 56);
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
            btnEraseCat.Location = new Point(14, 137);
            btnEraseCat.Margin = new Padding(3, 4, 3, 4);
            btnEraseCat.Name = "btnEraseCat";
            btnEraseCat.Size = new Size(173, 56);
            btnEraseCat.TabIndex = 25;
            btnEraseCat.Text = "Erase Category";
            btnEraseCat.UseVisualStyleBackColor = false;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 208);
            Controls.Add(btnEraseCat);
            Controls.Add(btnDoneEdit);
            Controls.Add(newNameCategoria);
            Controls.Add(purpleLabel2);
            Controls.Add(nameCategoria);
            Controls.Add(purpleLabel1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}