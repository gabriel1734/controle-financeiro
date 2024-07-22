namespace controlefinanceiro.Views
{
    partial class frmRelatorio
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
            dataInicio = new DateTimePicker();
            dataFim = new DateTimePicker();
            categoria = new ComboBox();
            EntradaSaida = new ComboBox();
            purpleLabel2 = new MeusControles.PurpleLabel();
            purpleLabel1 = new MeusControles.PurpleLabel();
            purpleLabel3 = new MeusControles.PurpleLabel();
            purpleLabel4 = new MeusControles.PurpleLabel();
            btnGenerate = new Button();
            btnExport = new Button();
            dataExcel = new DataGridView();
            DayBalance = new ReaLTaiizor.Controls.BigTextBox();
            purpleLabel5 = new MeusControles.PurpleLabel();
            ((System.ComponentModel.ISupportInitialize)dataExcel).BeginInit();
            SuspendLayout();
            // 
            // dataInicio
            // 
            dataInicio.Format = DateTimePickerFormat.Custom;
            dataInicio.Location = new Point(7, 29);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(135, 23);
            dataInicio.TabIndex = 0;
            // 
            // dataFim
            // 
            dataFim.Format = DateTimePickerFormat.Custom;
            dataFim.Location = new Point(153, 27);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(135, 23);
            dataFim.TabIndex = 1;
            // 
            // categoria
            // 
            categoria.FormattingEnabled = true;
            categoria.Location = new Point(486, 29);
            categoria.Name = "categoria";
            categoria.Size = new Size(129, 23);
            categoria.TabIndex = 2;
            categoria.SelectedIndexChanged += categoria_SelectedIndexChanged;
            // 
            // EntradaSaida
            // 
            EntradaSaida.FormattingEnabled = true;
            EntradaSaida.Location = new Point(334, 29);
            EntradaSaida.Name = "EntradaSaida";
            EntradaSaida.Size = new Size(146, 23);
            EntradaSaida.TabIndex = 3;
            // 
            // purpleLabel2
            // 
            purpleLabel2.AutoSize = true;
            purpleLabel2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel2.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel2.Location = new Point(7, 4);
            purpleLabel2.Name = "purpleLabel2";
            purpleLabel2.Size = new Size(100, 22);
            purpleLabel2.TabIndex = 7;
            purpleLabel2.Text = "Start Day";
            // 
            // purpleLabel1
            // 
            purpleLabel1.AutoSize = true;
            purpleLabel1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel1.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel1.Location = new Point(153, 4);
            purpleLabel1.Name = "purpleLabel1";
            purpleLabel1.Size = new Size(80, 22);
            purpleLabel1.TabIndex = 8;
            purpleLabel1.Text = "End Day";
            // 
            // purpleLabel3
            // 
            purpleLabel3.AutoSize = true;
            purpleLabel3.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel3.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel3.Location = new Point(486, 4);
            purpleLabel3.Name = "purpleLabel3";
            purpleLabel3.Size = new Size(90, 22);
            purpleLabel3.TabIndex = 9;
            purpleLabel3.Text = "Category";
            // 
            // purpleLabel4
            // 
            purpleLabel4.AutoSize = true;
            purpleLabel4.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel4.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel4.Location = new Point(334, 4);
            purpleLabel4.Name = "purpleLabel4";
            purpleLabel4.Size = new Size(50, 22);
            purpleLabel4.TabIndex = 10;
            purpleLabel4.Text = "Type";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(149, 88, 225);
            btnGenerate.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Transparent;
            btnGenerate.Location = new Point(635, 7);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(153, 65);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate  Reports";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += gerarRelatorio_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(149, 88, 225);
            btnExport.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Transparent;
            btnExport.Location = new Point(635, 377);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(153, 68);
            btnExport.TabIndex = 12;
            btnExport.Text = "Export Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += exportarExcel_Click;
            // 
            // dataExcel
            // 
            dataExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataExcel.Location = new Point(7, 78);
            dataExcel.Name = "dataExcel";
            dataExcel.Size = new Size(776, 293);
            dataExcel.TabIndex = 5;
            // 
            // DayBalance
            // 
            DayBalance.BackColor = Color.Transparent;
            DayBalance.Enabled = false;
            DayBalance.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DayBalance.ForeColor = Color.FromArgb(149, 88, 225);
            DayBalance.Image = null;
            DayBalance.Location = new Point(7, 399);
            DayBalance.MaxLength = 32767;
            DayBalance.Multiline = false;
            DayBalance.Name = "DayBalance";
            DayBalance.ReadOnly = false;
            DayBalance.Size = new Size(148, 46);
            DayBalance.TabIndex = 13;
            DayBalance.Text = "0,00";
            DayBalance.TextAlignment = HorizontalAlignment.Right;
            DayBalance.UseSystemPasswordChar = false;
            DayBalance.TextChanged += DayBalance_TextChanged;
            // 
            // purpleLabel5
            // 
            purpleLabel5.AutoSize = true;
            purpleLabel5.Font = new Font("Consolas", 14F, FontStyle.Bold);
            purpleLabel5.ForeColor = Color.FromArgb(149, 88, 225);
            purpleLabel5.Location = new Point(7, 377);
            purpleLabel5.Name = "purpleLabel5";
            purpleLabel5.Size = new Size(230, 22);
            purpleLabel5.TabIndex = 14;
            purpleLabel5.Text = "Balance in this Period";
            // 
            // frmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(purpleLabel5);
            Controls.Add(DayBalance);
            Controls.Add(btnExport);
            Controls.Add(btnGenerate);
            Controls.Add(purpleLabel4);
            Controls.Add(purpleLabel3);
            Controls.Add(purpleLabel1);
            Controls.Add(purpleLabel2);
            Controls.Add(dataExcel);
            Controls.Add(EntradaSaida);
            Controls.Add(categoria);
            Controls.Add(dataFim);
            Controls.Add(dataInicio);
            Name = "frmRelatorio";
            Text = "Movement Reports";
            ((System.ComponentModel.ISupportInitialize)dataExcel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dataInicio;
        private DateTimePicker dataFim;
        private ComboBox categoria;
        private ComboBox EntradaSaida;
        private MeusControles.PurpleLabel purpleLabel2;
        private MeusControles.PurpleLabel purpleLabel1;
        private MeusControles.PurpleLabel purpleLabel3;
        private MeusControles.PurpleLabel purpleLabel4;
        private Button btnGenerate;
        private Button btnExport;
        private DataGridView dataExcel;
        private MeusControles.PurpleLabel purpleLabel5;
        public ReaLTaiizor.Controls.BigTextBox DayBalance;
    }
}