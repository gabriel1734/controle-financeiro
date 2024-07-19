namespace controlefinanceiro.Views
{
    partial class frmCategories
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
            categorias = new ReaLTaiizor.Controls.HopeComboBox();
            btnEditCat = new Button();
            btnAddNew = new Button();
            purpleLabel2 = new MeusControles.PurpleLabel();
            SuspendLayout();
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(14, 12);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(76, 23);
            purpleLabel1.TabIndex = 0;
            purpleLabel1.Text = "Select";
            // 
            // categorias
            // 
            categorias.DrawMode = DrawMode.OwnerDrawFixed;
            categorias.FlatStyle = FlatStyle.Flat;
            categorias.Font = new Font("Segoe UI", 12F);
            categorias.ForeColor = Color.FromArgb(149, 88, 225);
            categorias.FormattingEnabled = true;
            categorias.ItemHeight = 30;
            categorias.Location = new Point(93, 12);
            categorias.Margin = new Padding(3, 4, 3, 4);
            categorias.Name = "categorias";
            categorias.Size = new Size(321, 36);
            categorias.TabIndex = 8;
            // 
            // btnEditCat
            // 
            btnEditCat.BackColor = Color.FromArgb(149, 88, 225);
            btnEditCat.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditCat.ForeColor = Color.White;
            btnEditCat.Location = new Point(93, 84);
            btnEditCat.Margin = new Padding(3, 4, 3, 4);
            btnEditCat.Name = "btnEditCat";
            btnEditCat.Size = new Size(153, 56);
            btnEditCat.TabIndex = 22;
            btnEditCat.Text = "Edit Selected";
            btnEditCat.UseVisualStyleBackColor = false;
            btnEditCat.Click += btnEditCat_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(149, 88, 225);
            btnAddNew.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(290, 84);
            btnAddNew.Margin = new Padding(3, 4, 3, 4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(123, 56);
            btnAddNew.TabIndex = 23;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(253, 100);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(32, 23);
            purpleLabel2.TabIndex = 24;
            purpleLabel2.Text = "or";
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 159);
            Controls.Add(purpleLabel2);
            Controls.Add(btnAddNew);
            Controls.Add(btnEditCat);
            Controls.Add(categorias);
            Controls.Add(purpleLabel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategories";
            Text = "frmCategories";
            Load += frmCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.HopeComboBox categorias;
        private Button btnEditCat;
        private Button btnAddNew;
        private MeusControles.PurpleLabel purpleLabel2;
    }
}