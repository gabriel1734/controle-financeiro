namespace controlefinanceiro.Views
{
    partial class frmAddNewCat
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
            categoria = new ReaLTaiizor.Controls.BigTextBox();
            btnAddNew = new Button();
            SuspendLayout();
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(12, 9);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(45, 19);
            purpleLabel1.TabIndex = 2;
            purpleLabel1.Text = "Name";
            // 
            // categoria
            // 
            categoria.BackColor = Color.Transparent;
            categoria.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoria.ForeColor = Color.FromArgb(149, 88, 225);
            categoria.Image = null;
            categoria.Location = new Point(63, 9);
            categoria.MaxLength = 32767;
            categoria.Multiline = false;
            categoria.Name = "categoria";
            categoria.ReadOnly = false;
            categoria.Size = new Size(188, 41);
            categoria.TabIndex = 7;
            categoria.TextAlignment = HorizontalAlignment.Left;
            categoria.UseSystemPasswordChar = false;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(149, 88, 225);
            btnAddNew.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(124, 56);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(127, 42);
            btnAddNew.TabIndex = 24;
            btnAddNew.Text = "Add Category";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // frmAddNewCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 104);
            Controls.Add(btnAddNew);
            Controls.Add(categoria);
            Controls.Add(purpleLabel1);
            MaximumSize = new Size(276, 143);
            MinimumSize = new Size(276, 143);
            Name = "frmAddNewCat";
            Text = "frmAddNewCat";
            Load += frmAddNewCat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.BigTextBox categoria;
        private Button btnAddNew;
    }
}