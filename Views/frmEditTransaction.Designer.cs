namespace controlefinanceiro.Views
{
    partial class frmEditTransaction
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
            mainDataTransactions = new DataGridView();
            purpleLabel1 = new MeusControles.PurpleLabel();
            dateFilter = new ReaLTaiizor.Controls.PoisonDateTime();
            serchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)mainDataTransactions).BeginInit();
            SuspendLayout();
            // 
            // mainDataTransactions
            // 
            mainDataTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataTransactions.Location = new Point(14, 88);
            mainDataTransactions.Margin = new Padding(3, 4, 3, 4);
            mainDataTransactions.Name = "mainDataTransactions";
            mainDataTransactions.RowHeadersWidth = 51;
            mainDataTransactions.Size = new Size(486, 268);
            mainDataTransactions.TabIndex = 0;
            mainDataTransactions.CellContentClick += mainDataTransactions_CellContentClick;
            mainDataTransactions.CellDoubleClick += mainDataTransactions_CellContentClick;
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(14, 12);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(175, 23);
            purpleLabel1.TabIndex = 1;
            purpleLabel1.Text = "Filter by Date:";
            // 
            // dateFilter
            // 
            dateFilter.Format = DateTimePickerFormat.Custom;
            dateFilter.Location = new Point(14, 41);
            dateFilter.Margin = new Padding(3, 4, 3, 4);
            dateFilter.MinimumSize = new Size(0, 30);
            dateFilter.Name = "dateFilter";
            dateFilter.Size = new Size(265, 30);
            dateFilter.TabIndex = 21;
            // 
            // serchBtn
            // 
            serchBtn.BackColor = Color.FromArgb(149, 88, 225);
            serchBtn.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serchBtn.ForeColor = Color.White;
            serchBtn.Location = new Point(296, 37);
            serchBtn.Margin = new Padding(3, 4, 3, 4);
            serchBtn.Name = "serchBtn";
            serchBtn.Size = new Size(204, 40);
            serchBtn.TabIndex = 22;
            serchBtn.Text = "Filter";
            serchBtn.UseVisualStyleBackColor = false;
            serchBtn.Click += serchBtn_Click;
            // 
            // frmEditTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 372);
            Controls.Add(serchBtn);
            Controls.Add(dateFilter);
            Controls.Add(purpleLabel1);
            Controls.Add(mainDataTransactions);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEditTransaction";
            Text = "frmEditTransaction";
            Load += frmEditTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)mainDataTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mainDataTransactions;
        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime dateFilter;
        private Button serchBtn;
    }
}