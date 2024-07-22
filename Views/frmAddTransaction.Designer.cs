namespace controlefinanceiro.Views
{
    partial class frmAddTransaction
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
            valueTransaction = new ReaLTaiizor.Controls.BigTextBox();
            category = new ReaLTaiizor.Controls.HopeComboBox();
            descriptionTransaction = new ReaLTaiizor.Controls.HopeRichTextBox();
            typeTransaction = new ReaLTaiizor.Controls.HopeComboBox();
            purpleLabel1 = new MeusControles.PurpleLabel();
            purpleLabel2 = new MeusControles.PurpleLabel();
            purpleLabel3 = new MeusControles.PurpleLabel();
            purpleLabel4 = new MeusControles.PurpleLabel();
            purpleLabel5 = new MeusControles.PurpleLabel();
            DateTransaction = new ReaLTaiizor.Controls.PoisonDateTime();
            button1 = new Button();
            purpleLabel6 = new MeusControles.PurpleLabel();
            idTransaction = new ReaLTaiizor.Controls.BigTextBox();
            userID = new ReaLTaiizor.Controls.BigTextBox();
            SuspendLayout();
            // 
            // valueTransaction
            // 
            valueTransaction.BackColor = Color.Transparent;
            valueTransaction.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valueTransaction.ForeColor = Color.FromArgb(149, 88, 225);
            valueTransaction.Image = null;
            valueTransaction.Location = new Point(128, 94);
            valueTransaction.MaxLength = 32767;
            valueTransaction.Multiline = false;
            valueTransaction.Name = "valueTransaction";
            valueTransaction.ReadOnly = false;
            valueTransaction.Size = new Size(100, 41);
            valueTransaction.TabIndex = 3;
            valueTransaction.Text = "0,00";
            valueTransaction.TextAlignment = HorizontalAlignment.Left;
            valueTransaction.UseSystemPasswordChar = false;
            // 
            // category
            // 
            category.DrawMode = DrawMode.OwnerDrawFixed;
            category.FlatStyle = FlatStyle.Flat;
            category.Font = new Font("Segoe UI", 12F);
            category.ForeColor = Color.FromArgb(149, 88, 225);
            category.FormattingEnabled = true;
            category.ItemHeight = 30;
            category.Location = new Point(128, 141);
            category.Name = "category";
            category.Size = new Size(121, 36);
            category.TabIndex = 7;
            // 
            // descriptionTransaction
            // 
            descriptionTransaction.BorderColor = Color.FromArgb(220, 223, 230);
            descriptionTransaction.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTransaction.ForeColor = Color.FromArgb(149, 88, 225);
            descriptionTransaction.Hint = "";
            descriptionTransaction.HoverBorderColor = Color.FromArgb(64, 158, 255);
            descriptionTransaction.Location = new Point(128, 183);
            descriptionTransaction.MaxLength = 32767;
            descriptionTransaction.Multiline = true;
            descriptionTransaction.Name = "descriptionTransaction";
            descriptionTransaction.PasswordChar = '\0';
            descriptionTransaction.ScrollBars = ScrollBars.None;
            descriptionTransaction.SelectedText = "";
            descriptionTransaction.SelectionLength = 0;
            descriptionTransaction.SelectionStart = 0;
            descriptionTransaction.Size = new Size(245, 97);
            descriptionTransaction.TabIndex = 8;
            descriptionTransaction.TabStop = false;
            descriptionTransaction.UseSystemPasswordChar = false;
            // 
            // typeTransaction
            // 
            typeTransaction.DrawMode = DrawMode.OwnerDrawFixed;
            typeTransaction.FlatStyle = FlatStyle.Flat;
            typeTransaction.Font = new Font("Segoe UI", 12F);
            typeTransaction.ForeColor = Color.FromArgb(149, 88, 225);
            typeTransaction.FormattingEnabled = true;
            typeTransaction.ItemHeight = 30;
            typeTransaction.Location = new Point(128, 286);
            typeTransaction.Name = "typeTransaction";
            typeTransaction.Size = new Size(121, 36);
            typeTransaction.TabIndex = 14;
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(77, 59);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(45, 19);
            purpleLabel1.TabIndex = 15;
            purpleLabel1.Text = "Date";
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(68, 94);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(54, 19);
            purpleLabel2.TabIndex = 16;
            purpleLabel2.Text = "Value";
            // 
            // purpleLabel3
            // 
            purpleLabel3.AutoSize = true;
            purpleLabel3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel3.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel3.Location = new Point(41, 141);
            purpleLabel3.Name = "purpleLabel3";
            purpleLabel3.Size = new Size(81, 19);
            purpleLabel3.TabIndex = 17;
            purpleLabel3.Text = "Category";
            // 
            // purpleLabel4
            // 
            purpleLabel4.AutoSize = true;
            purpleLabel4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel4.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel4.Location = new Point(14, 183);
            purpleLabel4.Name = "purpleLabel4";
            purpleLabel4.Size = new Size(108, 19);
            purpleLabel4.TabIndex = 18;
            purpleLabel4.Text = "Description";
            // 
            // purpleLabel5
            // 
            purpleLabel5.AutoSize = true;
            purpleLabel5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel5.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel5.Location = new Point(77, 286);
            purpleLabel5.Name = "purpleLabel5";
            purpleLabel5.Size = new Size(45, 19);
            purpleLabel5.TabIndex = 19;
            purpleLabel5.Text = "Type";
            // 
            // DateTransaction
            // 
            DateTransaction.Format = DateTimePickerFormat.Custom;
            DateTransaction.Location = new Point(128, 59);
            DateTransaction.MinimumSize = new Size(0, 29);
            DateTransaction.Name = "DateTransaction";
            DateTransaction.Size = new Size(100, 30);
            DateTransaction.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(149, 88, 225);
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(128, 345);
            button1.Name = "button1";
            button1.Size = new Size(134, 51);
            button1.TabIndex = 21;
            button1.Text = "Add Updates";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // purpleLabel6
            // 
            purpleLabel6.AutoSize = true;
            purpleLabel6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel6.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel6.Location = new Point(94, 21);
            purpleLabel6.Name = "purpleLabel6";
            purpleLabel6.Size = new Size(27, 19);
            purpleLabel6.TabIndex = 23;
            purpleLabel6.Text = "ID";
            // 
            // idTransaction
            // 
            idTransaction.BackColor = Color.Transparent;
            idTransaction.Enabled = false;
            idTransaction.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTransaction.ForeColor = Color.FromArgb(149, 88, 225);
            idTransaction.Image = null;
            idTransaction.Location = new Point(128, 12);
            idTransaction.MaxLength = 32767;
            idTransaction.Multiline = false;
            idTransaction.Name = "idTransaction";
            idTransaction.ReadOnly = false;
            idTransaction.Size = new Size(100, 41);
            idTransaction.TabIndex = 22;
            idTransaction.TextAlignment = HorizontalAlignment.Left;
            idTransaction.UseSystemPasswordChar = false;
            idTransaction.TextChanged += idTransaction_TextChanged;
            // 
            // userID
            // 
            userID.BackColor = Color.Transparent;
            userID.BackgroundImageLayout = ImageLayout.Center;
            userID.Enabled = false;
            userID.Font = new Font("Tahoma", 11F);
            userID.ForeColor = Color.DimGray;
            userID.Image = null;
            userID.Location = new Point(233, 12);
            userID.Margin = new Padding(3, 2, 3, 2);
            userID.MaxLength = 32767;
            userID.Multiline = false;
            userID.Name = "userID";
            userID.ReadOnly = false;
            userID.Size = new Size(109, 41);
            userID.TabIndex = 24;
            userID.Text = "userID";
            userID.TextAlignment = HorizontalAlignment.Left;
            userID.UseSystemPasswordChar = false;
            userID.Visible = false;
            // 
            // frmAddTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 408);
            Controls.Add(userID);
            Controls.Add(purpleLabel6);
            Controls.Add(idTransaction);
            Controls.Add(button1);
            Controls.Add(DateTransaction);
            Controls.Add(purpleLabel5);
            Controls.Add(purpleLabel4);
            Controls.Add(purpleLabel3);
            Controls.Add(purpleLabel2);
            Controls.Add(purpleLabel1);
            Controls.Add(typeTransaction);
            Controls.Add(descriptionTransaction);
            Controls.Add(category);
            Controls.Add(valueTransaction);
            Name = "frmAddTransaction";
            Text = "frmAddTransaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigTextBox valueTransaction;
        private ReaLTaiizor.Controls.HopeComboBox category;
        private ReaLTaiizor.Controls.HopeRichTextBox descriptionTransaction;
        private ReaLTaiizor.Controls.HopeComboBox typeTransaction;
        private MeusControles.PurpleLabel purpleLabel1;
        private MeusControles.PurpleLabel purpleLabel2;
        private MeusControles.PurpleLabel purpleLabel3;
        private MeusControles.PurpleLabel purpleLabel4;
        private MeusControles.PurpleLabel purpleLabel5;
        private ReaLTaiizor.Controls.PoisonDateTime DateTransaction;
        private Button button1;
        private MeusControles.PurpleLabel purpleLabel6;
        private ReaLTaiizor.Controls.BigTextBox idTransaction;
        private ReaLTaiizor.Controls.BigTextBox userID;
    }
}