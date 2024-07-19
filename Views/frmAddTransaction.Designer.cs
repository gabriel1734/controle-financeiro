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
            valueTransaction.Location = new Point(146, 125);
            valueTransaction.Margin = new Padding(3, 4, 3, 4);
            valueTransaction.MaxLength = 32767;
            valueTransaction.Multiline = false;
            valueTransaction.Name = "valueTransaction";
            valueTransaction.ReadOnly = false;
            valueTransaction.Size = new Size(114, 45);
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
            category.Location = new Point(146, 188);
            category.Margin = new Padding(3, 4, 3, 4);
            category.Name = "category";
            category.Size = new Size(138, 36);
            category.TabIndex = 7;
            // 
            // descriptionTransaction
            // 
            descriptionTransaction.BorderColor = Color.FromArgb(220, 223, 230);
            descriptionTransaction.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTransaction.ForeColor = Color.FromArgb(149, 88, 225);
            descriptionTransaction.Hint = "";
            descriptionTransaction.HoverBorderColor = Color.FromArgb(64, 158, 255);
            descriptionTransaction.Location = new Point(146, 244);
            descriptionTransaction.Margin = new Padding(3, 4, 3, 4);
            descriptionTransaction.MaxLength = 32767;
            descriptionTransaction.Multiline = true;
            descriptionTransaction.Name = "descriptionTransaction";
            descriptionTransaction.PasswordChar = '\0';
            descriptionTransaction.ScrollBars = ScrollBars.None;
            descriptionTransaction.SelectedText = "";
            descriptionTransaction.SelectionLength = 0;
            descriptionTransaction.SelectionStart = 0;
            descriptionTransaction.Size = new Size(280, 129);
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
            typeTransaction.Location = new Point(146, 381);
            typeTransaction.Margin = new Padding(3, 4, 3, 4);
            typeTransaction.Name = "typeTransaction";
            typeTransaction.Size = new Size(138, 36);
            typeTransaction.TabIndex = 14;
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(88, 79);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(54, 23);
            purpleLabel1.TabIndex = 15;
            purpleLabel1.Text = "Date";
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(78, 125);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(65, 23);
            purpleLabel2.TabIndex = 16;
            purpleLabel2.Text = "Value";
            // 
            // purpleLabel3
            // 
            purpleLabel3.AutoSize = true;
            purpleLabel3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel3.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel3.Location = new Point(47, 188);
            purpleLabel3.Name = "purpleLabel3";
            purpleLabel3.Size = new Size(98, 23);
            purpleLabel3.TabIndex = 17;
            purpleLabel3.Text = "Category";
            // 
            // purpleLabel4
            // 
            purpleLabel4.AutoSize = true;
            purpleLabel4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel4.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel4.Location = new Point(16, 244);
            purpleLabel4.Name = "purpleLabel4";
            purpleLabel4.Size = new Size(131, 23);
            purpleLabel4.TabIndex = 18;
            purpleLabel4.Text = "Description";
            // 
            // purpleLabel5
            // 
            purpleLabel5.AutoSize = true;
            purpleLabel5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel5.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel5.Location = new Point(88, 381);
            purpleLabel5.Name = "purpleLabel5";
            purpleLabel5.Size = new Size(54, 23);
            purpleLabel5.TabIndex = 19;
            purpleLabel5.Text = "Type";
            // 
            // DateTransaction
            // 
            DateTransaction.Format = DateTimePickerFormat.Custom;
            DateTransaction.Location = new Point(146, 79);
            DateTransaction.Margin = new Padding(3, 4, 3, 4);
            DateTransaction.MinimumSize = new Size(0, 30);
            DateTransaction.Name = "DateTransaction";
            DateTransaction.Size = new Size(114, 30);
            DateTransaction.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(149, 88, 225);
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(146, 460);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(138, 68);
            button1.TabIndex = 21;
            button1.Text = "Add Transaction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // purpleLabel6
            // 
            purpleLabel6.AutoSize = true;
            purpleLabel6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel6.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel6.Location = new Point(108, 28);
            purpleLabel6.Name = "purpleLabel6";
            purpleLabel6.Size = new Size(32, 23);
            purpleLabel6.TabIndex = 23;
            purpleLabel6.Text = "ID";
            // 
            // idTransaction
            // 
            idTransaction.BackColor = Color.Transparent;
            idTransaction.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTransaction.ForeColor = Color.FromArgb(149, 88, 225);
            idTransaction.Image = null;
            idTransaction.Location = new Point(146, 16);
            idTransaction.Margin = new Padding(3, 4, 3, 4);
            idTransaction.MaxLength = 32767;
            idTransaction.Multiline = false;
            idTransaction.Name = "idTransaction";
            idTransaction.ReadOnly = false;
            idTransaction.Size = new Size(114, 45);
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
            userID.Location = new Point(266, 16);
            userID.MaxLength = 32767;
            userID.Multiline = false;
            userID.Name = "userID";
            userID.ReadOnly = false;
            userID.Size = new Size(125, 46);
            userID.TabIndex = 24;
            userID.Text = "bigTextBox1";
            userID.TextAlignment = HorizontalAlignment.Left;
            userID.UseSystemPasswordChar = false;
            userID.Visible = false;
            // 
            // frmAddTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 544);
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
            Margin = new Padding(3, 4, 3, 4);
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