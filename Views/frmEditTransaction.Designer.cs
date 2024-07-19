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
            dataGridView1 = new DataGridView();
            purpleLabel1 = new MeusControles.PurpleLabel();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 88);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(486, 268);
            dataGridView1.TabIndex = 0;
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
            // poisonDateTime1
            // 
            poisonDateTime1.Location = new Point(14, 41);
            poisonDateTime1.Margin = new Padding(3, 4, 3, 4);
            poisonDateTime1.MinimumSize = new Size(0, 30);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(265, 30);
            poisonDateTime1.TabIndex = 21;
            // 
            // frmEditTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 372);
            Controls.Add(poisonDateTime1);
            Controls.Add(purpleLabel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEditTransaction";
            Text = "frmEditTransaction";
            Load += frmEditTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MeusControles.PurpleLabel purpleLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
    }
}