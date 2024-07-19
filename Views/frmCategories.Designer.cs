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
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
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
            purpleLabel1.Location = new Point(12, 9);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(63, 19);
            purpleLabel1.TabIndex = 0;
            purpleLabel1.Text = "Select";
            // 
            // hopeComboBox1
            // 
            hopeComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox1.FlatStyle = FlatStyle.Flat;
            hopeComboBox1.Font = new Font("Segoe UI", 12F);
            hopeComboBox1.ForeColor = Color.FromArgb(149, 88, 225);
            hopeComboBox1.FormattingEnabled = true;
            hopeComboBox1.ItemHeight = 30;
            hopeComboBox1.Location = new Point(81, 9);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(281, 36);
            hopeComboBox1.TabIndex = 8;
            // 
            // btnEditCat
            // 
            btnEditCat.BackColor = Color.FromArgb(149, 88, 225);
            btnEditCat.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditCat.ForeColor = Color.White;
            btnEditCat.Location = new Point(81, 63);
            btnEditCat.Name = "btnEditCat";
            btnEditCat.Size = new Size(134, 42);
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
            btnAddNew.Location = new Point(254, 63);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(108, 42);
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
            purpleLabel2.Location = new Point(221, 75);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(27, 19);
            purpleLabel2.TabIndex = 24;
            purpleLabel2.Text = "or";
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 119);
            Controls.Add(purpleLabel2);
            Controls.Add(btnAddNew);
            Controls.Add(btnEditCat);
            Controls.Add(hopeComboBox1);
            Controls.Add(purpleLabel1);
            Name = "frmCategories";
            Text = "frmCategories";
            Load += frmCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private Button btnEditCat;
        private Button btnAddNew;
        private MeusControles.PurpleLabel purpleLabel2;
    }
}