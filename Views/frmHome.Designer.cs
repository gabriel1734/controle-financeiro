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
            profileContainer = new Panel();
            lblUser = new Label();
            btnProfile = new Button();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            sidebarContainer = new FlowLayoutPanel();
            dboardPanel = new Panel();
            btnDboard = new Button();
            manageContainer = new FlowLayoutPanel();
            managePanel = new Panel();
            btnManage = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel8 = new Panel();
            button7 = new Button();
            reportPanel = new Panel();
            btnReport = new Button();
            panel2 = new Panel();
            btnResetPassword = new Button();
            logoutPanel = new Panel();
            btnLogout = new Button();
            manageTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            mainTransactions = new DataGridView();
            DayBalance = new ReaLTaiizor.Controls.BigTextBox();
            TotalBalance = new ReaLTaiizor.Controls.BigTextBox();
            dateTransaction = new ReaLTaiizor.Controls.PoisonDateTime();
            findBtn = new Button();
            profileTransition = new System.Windows.Forms.Timer(components);
            lblDayBalance = new Label();
            lblTotalBalance = new Label();
            lblDate = new Label();
            panel1.SuspendLayout();
            profileContainer.SuspendLayout();
            sidebarContainer.SuspendLayout();
            dboardPanel.SuspendLayout();
            manageContainer.SuspendLayout();
            managePanel.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            reportPanel.SuspendLayout();
            panel2.SuspendLayout();
            logoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainTransactions).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(149, 88, 225);
            panel1.Controls.Add(profileContainer);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 44);
            panel1.TabIndex = 0;
            // 
            // profileContainer
            // 
            profileContainer.Controls.Add(lblUser);
            profileContainer.Controls.Add(btnProfile);
            profileContainer.Location = new Point(9, 7);
            profileContainer.Name = "profileContainer";
            profileContainer.Size = new Size(200, 30);
            profileContainer.TabIndex = 9;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.FromArgb(133, 64, 217);
            lblUser.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(57, 8);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 14);
            lblUser.TabIndex = 9;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(-24, -21);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(20, 0, 0, 0);
            btnProfile.Size = new Size(226, 73);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "     Hi";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += button1_Click;
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
            nightControlBox1.Location = new Point(1557, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(149, 88, 225);
            sidebarContainer.Controls.Add(dboardPanel);
            sidebarContainer.Controls.Add(manageContainer);
            sidebarContainer.Controls.Add(reportPanel);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(logoutPanel);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 44);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(0, 406);
            sidebarContainer.TabIndex = 1;
            // 
            // dboardPanel
            // 
            dboardPanel.Controls.Add(btnDboard);
            dboardPanel.Location = new Point(3, 3);
            dboardPanel.Name = "dboardPanel";
            dboardPanel.Size = new Size(200, 43);
            dboardPanel.TabIndex = 2;
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
            manageContainer.Controls.Add(managePanel);
            manageContainer.Controls.Add(panel6);
            manageContainer.Controls.Add(panel7);
            manageContainer.Controls.Add(panel8);
            manageContainer.Location = new Point(3, 52);
            manageContainer.Name = "manageContainer";
            manageContainer.Size = new Size(197, 43);
            manageContainer.TabIndex = 7;
            // 
            // managePanel
            // 
            managePanel.Controls.Add(btnManage);
            managePanel.Location = new Point(0, 0);
            managePanel.Margin = new Padding(0);
            managePanel.Name = "managePanel";
            managePanel.Size = new Size(200, 43);
            managePanel.TabIndex = 6;
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
            button5.Click += button5_Click;
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
            button6.Click += button6_Click;
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
            button7.Click += button7_Click;
            // 
            // reportPanel
            // 
            reportPanel.Controls.Add(btnReport);
            reportPanel.Location = new Point(3, 101);
            reportPanel.Name = "reportPanel";
            reportPanel.Size = new Size(200, 43);
            reportPanel.TabIndex = 4;
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
            btnReport.Click += btnReport_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnResetPassword);
            panel2.Location = new Point(3, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 43);
            panel2.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(133, 64, 217);
            btnResetPassword.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Image = (Image)resources.GetObject("btnResetPassword.Image");
            btnResetPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetPassword.Location = new Point(-12, -15);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Padding = new Padding(20, 0, 0, 0);
            btnResetPassword.Size = new Size(226, 73);
            btnResetPassword.TabIndex = 3;
            btnResetPassword.Text = "     Reset Password";
            btnResetPassword.TextAlign = ContentAlignment.MiddleLeft;
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(btnLogout);
            logoutPanel.Location = new Point(3, 199);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(200, 43);
            logoutPanel.TabIndex = 5;
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
            btnLogout.Click += logout_Click;
            // 
            // manageTransition
            // 
            manageTransition.Interval = 5;
            manageTransition.Tick += manageTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 1;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // mainTransactions
            // 
            mainTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainTransactions.Location = new Point(223, 89);
            mainTransactions.Name = "mainTransactions";
            mainTransactions.RowHeadersWidth = 51;
            mainTransactions.Size = new Size(651, 349);
            mainTransactions.TabIndex = 2;
            mainTransactions.CellContentClick += mainTransactions_CellContentClick;
            // 
            // DayBalance
            // 
            DayBalance.BackColor = Color.Transparent;
            DayBalance.Enabled = false;
            DayBalance.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DayBalance.ForeColor = Color.FromArgb(149, 88, 225);
            DayBalance.Image = null;
            DayBalance.Location = new Point(20, 96);
            DayBalance.MaxLength = 32767;
            DayBalance.Multiline = false;
            DayBalance.Name = "DayBalance";
            DayBalance.ReadOnly = false;
            DayBalance.Size = new Size(148, 46);
            DayBalance.TabIndex = 5;
            DayBalance.Text = "0,00";
            DayBalance.TextAlignment = HorizontalAlignment.Left;
            DayBalance.UseSystemPasswordChar = false;
            DayBalance.TextChanged += DayBalance_TextChanged;
            // 
            // TotalBalance
            // 
            TotalBalance.BackColor = Color.Transparent;
            TotalBalance.Enabled = false;
            TotalBalance.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalBalance.ForeColor = Color.FromArgb(149, 88, 225);
            TotalBalance.Image = null;
            TotalBalance.Location = new Point(20, 182);
            TotalBalance.MaxLength = 32767;
            TotalBalance.Multiline = false;
            TotalBalance.Name = "TotalBalance";
            TotalBalance.ReadOnly = false;
            TotalBalance.Size = new Size(148, 46);
            TotalBalance.TabIndex = 7;
            TotalBalance.Text = "0,00";
            TotalBalance.TextAlignment = HorizontalAlignment.Left;
            TotalBalance.UseSystemPasswordChar = false;
            TotalBalance.TextChanged += TotalBalance_TextChanged;
            // 
            // dateTransaction
            // 
            dateTransaction.Format = DateTimePickerFormat.Custom;
            dateTransaction.Location = new Point(20, 269);
            dateTransaction.Margin = new Padding(3, 2, 3, 2);
            dateTransaction.MinimumSize = new Size(0, 29);
            dateTransaction.Name = "dateTransaction";
            dateTransaction.Size = new Size(148, 29);
            dateTransaction.TabIndex = 8;
            // 
            // findBtn
            // 
            findBtn.BackColor = Color.FromArgb(149, 88, 225);
            findBtn.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            findBtn.ForeColor = Color.Transparent;
            findBtn.Location = new Point(20, 314);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(153, 51);
            findBtn.TabIndex = 0;
            findBtn.Text = "Search";
            findBtn.UseVisualStyleBackColor = false;
            findBtn.Click += findBtn_Click;
            // 
            // profileTransition
            // 
            profileTransition.Interval = 1;
            profileTransition.Tick += profileTransition_Tick;
            // 
            // lblDayBalance
            // 
            lblDayBalance.AutoSize = true;
            lblDayBalance.BackColor = Color.Transparent;
            lblDayBalance.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblDayBalance.ForeColor = Color.FromArgb(149, 88, 225);
            lblDayBalance.Location = new Point(20, 68);
            lblDayBalance.Name = "lblDayBalance";
            lblDayBalance.Size = new Size(120, 22);
            lblDayBalance.TabIndex = 15;
            lblDayBalance.Text = "Day Balance";
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.BackColor = Color.Transparent;
            lblTotalBalance.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblTotalBalance.ForeColor = Color.FromArgb(149, 88, 225);
            lblTotalBalance.Location = new Point(20, 154);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(140, 22);
            lblTotalBalance.TabIndex = 16;
            lblTotalBalance.Text = "Total Balance";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(149, 88, 225);
            lblDate.Location = new Point(20, 243);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 22);
            lblDate.TabIndex = 17;
            lblDate.Text = "Date";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 450);
            Controls.Add(lblDate);
            Controls.Add(lblTotalBalance);
            Controls.Add(lblDayBalance);
            Controls.Add(sidebarContainer);
            Controls.Add(findBtn);
            Controls.Add(dateTransaction);
            Controls.Add(TotalBalance);
            Controls.Add(DayBalance);
            Controls.Add(mainTransactions);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(898, 450);
            MinimumSize = new Size(898, 450);
            Name = "frmHome";
            Text = "Home";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            profileContainer.ResumeLayout(false);
            profileContainer.PerformLayout();
            sidebarContainer.ResumeLayout(false);
            dboardPanel.ResumeLayout(false);
            manageContainer.ResumeLayout(false);
            managePanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            reportPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            logoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebarContainer;
        private Panel dboardPanel;
        private Button btnDboard;
        private Panel reportPanel;
        private Button btnReport;
        private Panel logoutPanel;
        private Button btnLogout;
        private Panel managePanel;
        private Button btnManage;
        private FlowLayoutPanel manageContainer;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private Panel panel8;
        private Button button7;
        private System.Windows.Forms.Timer manageTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private DataGridView mainTransactions;
        private MeusControles.PurpleLabel purpleLabel1;
        private MeusControles.PurpleLabel purpleLabel2;
        private ReaLTaiizor.Controls.BigTextBox DayBalance;
        private ReaLTaiizor.Controls.BigTextBox TotalBalance;
        private MeusControles.PurpleLabel purpleLabel3;
        private ReaLTaiizor.Controls.PoisonDateTime dateTransaction;
        private Button findBtn;
        private MeusControles.PurpleLabel purpleLabel4;
        private Panel profileContainer;
        private Button btnProfile;
        private System.Windows.Forms.Timer profileTransition;
        private Panel panel2;
        private Button btnResetPassword;
        private Label lblUser;
        private Label lblDayBalance;
        private Label lblTotalBalance;
        private Label lblDate;
    }
}