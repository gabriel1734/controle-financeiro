namespace controlefinanceiro.Views
{
    partial class frmHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnDboard = new Button();
            manageContainer = new FlowLayoutPanel();
            panel4 = new Panel();
            btnManage = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel8 = new Panel();
            button7 = new Button();
            panel3 = new Panel();
            btnReport = new Button();
            panel5 = new Panel();
            btnLogout = new Button();
            manageTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            manageContainer.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(149, 88, 225);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 44);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.White;
            nightControlBox1.DisableMinimizeColor = Color.White;
            nightControlBox1.EnableCloseColor = Color.White;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.White;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.White;
            nightControlBox1.Location = new Point(661, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(149, 88, 225);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(manageContainer);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 406);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDboard);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 43);
            panel2.TabIndex = 2;
            // 
            // btnDboard
            // 
            btnDboard.BackColor = Color.FromArgb(133, 64, 217);
            btnDboard.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDboard.ForeColor = Color.White;
            btnDboard.Image = (Image)resources.GetObject("btnDboard.Image");
            btnDboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDboard.Location = new Point(-12, -15);
            btnDboard.Name = "btnDboard";
            btnDboard.Padding = new Padding(20, 0, 0, 0);
            btnDboard.Size = new Size(226, 73);
            btnDboard.TabIndex = 3;
            btnDboard.Text = "     Dashboard";
            btnDboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDboard.UseVisualStyleBackColor = false;
            // 
            // manageContainer
            // 
            manageContainer.Controls.Add(panel4);
            manageContainer.Controls.Add(panel6);
            manageContainer.Controls.Add(panel7);
            manageContainer.Controls.Add(panel8);
            manageContainer.Location = new Point(3, 52);
            manageContainer.Name = "manageContainer";
            manageContainer.Size = new Size(197, 43);
            manageContainer.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnManage);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 43);
            panel4.TabIndex = 6;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(133, 64, 217);
            btnManage.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.ForeColor = Color.White;
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(-12, -15);
            btnManage.Name = "btnManage";
            btnManage.Padding = new Padding(20, 0, 0, 0);
            btnManage.Size = new Size(226, 73);
            btnManage.TabIndex = 3;
            btnManage.Text = "     Manage";
            btnManage.TextAlign = ContentAlignment.MiddleLeft;
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(0, 43);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 43);
            panel6.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(149, 88, 225);
            button5.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-12, -15);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(226, 73);
            button5.TabIndex = 3;
            button5.Text = "     Add Transaction";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(0, 86);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 43);
            panel7.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(149, 88, 225);
            button6.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-12, -15);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(226, 73);
            button6.TabIndex = 3;
            button6.Text = "     Edit Transaction";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(button7);
            panel8.Location = new Point(0, 129);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 43);
            panel8.TabIndex = 9;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(149, 88, 225);
            button7.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-12, -15);
            button7.Name = "button7";
            button7.Padding = new Padding(20, 0, 0, 0);
            button7.Size = new Size(226, 73);
            button7.TabIndex = 3;
            button7.Text = "     Categories";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnReport);
            panel3.Location = new Point(3, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 43);
            panel3.TabIndex = 4;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(133, 64, 217);
            btnReport.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-12, -15);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(20, 0, 0, 0);
            btnReport.Size = new Size(226, 73);
            btnReport.TabIndex = 3;
            btnReport.Text = "     Reports";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Location = new Point(3, 150);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 43);
            panel5.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(133, 64, 217);
            btnLogout.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-12, -15);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(226, 73);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "     Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // manageTransition
            // 
            manageTransition.Tick += manageTransition_Tick;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "Home";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            manageContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button btnDboard;
        private Panel panel3;
        private Button btnReport;
        private Panel panel5;
        private Button btnLogout;
        private Panel panel4;
        private Button btnManage;
        private FlowLayoutPanel manageContainer;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private Panel panel8;
        private Button button7;
        private System.Windows.Forms.Timer manageTransition;
    }
}