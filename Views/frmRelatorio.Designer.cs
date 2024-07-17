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
            dataExcel = new DataGridView();
            exportarExcel = new Button();
            gerarRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataExcel).BeginInit();
            SuspendLayout();
            // 
            // dataInicio
            // 
            dataInicio.Format = DateTimePickerFormat.Custom;
            dataInicio.Location = new Point(12, 29);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(95, 23);
            dataInicio.TabIndex = 0;
            // 
            // dataFim
            // 
            dataFim.Format = DateTimePickerFormat.Custom;
            dataFim.Location = new Point(113, 29);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(135, 23);
            dataFim.TabIndex = 1;
            // 
            // categoria
            // 
            categoria.FormattingEnabled = true;
            categoria.Location = new Point(266, 29);
            categoria.Name = "categoria";
            categoria.Size = new Size(121, 23);
            categoria.TabIndex = 2;
            // 
            // EntradaSaida
            // 
            EntradaSaida.FormattingEnabled = true;
            EntradaSaida.Location = new Point(416, 29);
            EntradaSaida.Name = "EntradaSaida";
            EntradaSaida.Size = new Size(121, 23);
            EntradaSaida.TabIndex = 3;
            // 
            // dataExcel
            // 
            dataExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataExcel.Location = new Point(12, 78);
            dataExcel.Name = "dataExcel";
            dataExcel.Size = new Size(776, 337);
            dataExcel.TabIndex = 4;
            // 
            // exportarExcel
            // 
            exportarExcel.Location = new Point(704, 421);
            exportarExcel.Name = "exportarExcel";
            exportarExcel.Size = new Size(75, 23);
            exportarExcel.TabIndex = 5;
            exportarExcel.Text = "excel";
            exportarExcel.UseVisualStyleBackColor = true;
            // 
            // gerarRelatorio
            // 
            gerarRelatorio.Location = new Point(564, 29);
            gerarRelatorio.Name = "gerarRelatorio";
            gerarRelatorio.Size = new Size(115, 23);
            gerarRelatorio.TabIndex = 6;
            gerarRelatorio.Text = "Gerar Relatório";
            gerarRelatorio.UseVisualStyleBackColor = true;
            gerarRelatorio.Click += gerarRelatorio_Click;
            // 
            // frmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gerarRelatorio);
            Controls.Add(exportarExcel);
            Controls.Add(dataExcel);
            Controls.Add(EntradaSaida);
            Controls.Add(categoria);
            Controls.Add(dataFim);
            Controls.Add(dataInicio);
            Name = "frmRelatorio";
            Text = "frmRelatorio";
            ((System.ComponentModel.ISupportInitialize)dataExcel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dataInicio;
        private DateTimePicker dataFim;
        private ComboBox categoria;
        private ComboBox EntradaSaida;
        private DataGridView dataExcel;
        private Button exportarExcel;
        private Button gerarRelatorio;
    }
}