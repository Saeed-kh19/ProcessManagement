namespace Accounting.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblWelcome = new System.Windows.Forms.ToolStripLabel();
            this.lblSpaceBetween = new System.Windows.Forms.ToolStripLabel();
            this.lblDay = new System.Windows.Forms.ToolStripLabel();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUserPrivacy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApplicationUsers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccountSide = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.lblAverageOutcome = new System.Windows.Forms.Label();
            this.lblTodayOutcome = new System.Windows.Forms.Label();
            this.lblTotalOutcome = new System.Windows.Forms.Label();
            this.lblAverageIncome = new System.Windows.Forms.Label();
            this.lblTodayIncome = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tmrTransactionAnalysisRefresh = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings,
            this.toolStripSeparator1,
            this.lblWelcome,
            this.lblSpaceBetween,
            this.lblDay,
            this.lblTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::Accounting.App.Properties.Resources.icons8_settings_50;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(74, 22);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblWelcome
            // 
            this.lblWelcome.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(145, 22);
            this.lblWelcome.Text = "Welcome to Accounting";
            // 
            // lblSpaceBetween
            // 
            this.lblSpaceBetween.Name = "lblSpaceBetween";
            this.lblSpaceBetween.Size = new System.Drawing.Size(420, 22);
            this.lblSpaceBetween.Text = "                                                                                 " +
    "                      ";
            // 
            // lblDay
            // 
            this.lblDay.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblDay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(75, 22);
            this.lblDay.Text = "Wednesday";
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 22);
            this.lblTime.Text = "12:34 PM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnAboutUs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSignOut);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnUserPrivacy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnApplicationUsers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNewTransaction);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAccountSide);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.Location = new System.Drawing.Point(605, 30);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(68, 60);
            this.btnAboutUs.TabIndex = 22;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "About us";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Image = global::Accounting.App.Properties.Resources.icons8_log_out_48;
            this.btnSignOut.Location = new System.Drawing.Point(692, 30);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(68, 60);
            this.btnSignOut.TabIndex = 20;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(702, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sign out";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Image = global::Accounting.App.Properties.Resources.icons8_passwords_48;
            this.btnChangePassword.Location = new System.Drawing.Point(505, 30);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(68, 60);
            this.btnChangePassword.TabIndex = 18;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Change Password";
            // 
            // btnUserPrivacy
            // 
            this.btnUserPrivacy.BackColor = System.Drawing.Color.Transparent;
            this.btnUserPrivacy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUserPrivacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserPrivacy.Image = global::Accounting.App.Properties.Resources.icons8_user_shield_48;
            this.btnUserPrivacy.Location = new System.Drawing.Point(406, 30);
            this.btnUserPrivacy.Name = "btnUserPrivacy";
            this.btnUserPrivacy.Size = new System.Drawing.Size(68, 60);
            this.btnUserPrivacy.TabIndex = 14;
            this.btnUserPrivacy.UseVisualStyleBackColor = false;
            this.btnUserPrivacy.Click += new System.EventHandler(this.btnUserPrivacy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "User Privacy";
            // 
            // btnApplicationUsers
            // 
            this.btnApplicationUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnApplicationUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApplicationUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicationUsers.Image = global::Accounting.App.Properties.Resources.icons8_people_skin_type_7_48;
            this.btnApplicationUsers.Location = new System.Drawing.Point(303, 30);
            this.btnApplicationUsers.Name = "btnApplicationUsers";
            this.btnApplicationUsers.Size = new System.Drawing.Size(68, 60);
            this.btnApplicationUsers.TabIndex = 12;
            this.btnApplicationUsers.UseVisualStyleBackColor = false;
            this.btnApplicationUsers.Click += new System.EventHandler(this.btnApplicationUsers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Application Users";
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Image = global::Accounting.App.Properties.Resources.icons8_analytics_48;
            this.btnReports.Location = new System.Drawing.Point(209, 30);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(68, 60);
            this.btnReports.TabIndex = 10;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Transaction";
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTransaction.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Image = global::Accounting.App.Properties.Resources.icons8_transaction_48;
            this.btnNewTransaction.Location = new System.Drawing.Point(120, 30);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(68, 60);
            this.btnNewTransaction.TabIndex = 6;
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account Side";
            // 
            // btnAccountSide
            // 
            this.btnAccountSide.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountSide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccountSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSide.Image = global::Accounting.App.Properties.Resources.icons8_user_menu_male_50;
            this.btnAccountSide.Location = new System.Drawing.Point(23, 30);
            this.btnAccountSide.Name = "btnAccountSide";
            this.btnAccountSide.Size = new System.Drawing.Size(68, 60);
            this.btnAccountSide.TabIndex = 4;
            this.btnAccountSide.UseVisualStyleBackColor = false;
            this.btnAccountSide.Click += new System.EventHandler(this.btnAccountSide_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(325, 17);
            this.toolStripStatusLabel2.Text = "                                                                                 " +
    "                         ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.BlueViolet;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Developed by Saeed.Kh";
            // 
            // tmrDateAndTime
            // 
            this.tmrDateAndTime.Enabled = true;
            this.tmrDateAndTime.Interval = 1000;
            this.tmrDateAndTime.Tick += new System.EventHandler(this.tmrDateAndTime_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.lblFinalBalance);
            this.groupBox2.Controls.Add(this.lblAverageOutcome);
            this.groupBox2.Controls.Add(this.lblTodayOutcome);
            this.groupBox2.Controls.Add(this.lblTotalOutcome);
            this.groupBox2.Controls.Add(this.lblAverageIncome);
            this.groupBox2.Controls.Add(this.lblTodayIncome);
            this.groupBox2.Controls.Add(this.lblTotalIncome);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 244);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Analysis";
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(85)))), ((int)(((byte)(38)))));
            this.lblFinalBalance.Location = new System.Drawing.Point(213, 144);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(157, 15);
            this.lblFinalBalance.TabIndex = 42;
            this.lblFinalBalance.Text = "12\'357\'964\'321  (Outcome)";
            // 
            // lblAverageOutcome
            // 
            this.lblAverageOutcome.AutoSize = true;
            this.lblAverageOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageOutcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblAverageOutcome.Location = new System.Drawing.Point(620, 107);
            this.lblAverageOutcome.Name = "lblAverageOutcome";
            this.lblAverageOutcome.Size = new System.Drawing.Size(93, 15);
            this.lblAverageOutcome.TabIndex = 40;
            this.lblAverageOutcome.Text = "12\'357\'964\'321";
            // 
            // lblTodayOutcome
            // 
            this.lblTodayOutcome.AutoSize = true;
            this.lblTodayOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayOutcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblTodayOutcome.Location = new System.Drawing.Point(396, 107);
            this.lblTodayOutcome.Name = "lblTodayOutcome";
            this.lblTodayOutcome.Size = new System.Drawing.Size(93, 15);
            this.lblTodayOutcome.TabIndex = 39;
            this.lblTodayOutcome.Text = "12\'357\'964\'321";
            // 
            // lblTotalOutcome
            // 
            this.lblTotalOutcome.AutoSize = true;
            this.lblTotalOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOutcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotalOutcome.Location = new System.Drawing.Point(193, 107);
            this.lblTotalOutcome.Name = "lblTotalOutcome";
            this.lblTotalOutcome.Size = new System.Drawing.Size(93, 15);
            this.lblTotalOutcome.TabIndex = 38;
            this.lblTotalOutcome.Text = "12\'357\'964\'321";
            // 
            // lblAverageIncome
            // 
            this.lblAverageIncome.AutoSize = true;
            this.lblAverageIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageIncome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAverageIncome.Location = new System.Drawing.Point(613, 70);
            this.lblAverageIncome.Name = "lblAverageIncome";
            this.lblAverageIncome.Size = new System.Drawing.Size(93, 15);
            this.lblAverageIncome.TabIndex = 37;
            this.lblAverageIncome.Text = "12\'357\'964\'321";
            // 
            // lblTodayIncome
            // 
            this.lblTodayIncome.AutoSize = true;
            this.lblTodayIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayIncome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTodayIncome.Location = new System.Drawing.Point(389, 70);
            this.lblTodayIncome.Name = "lblTodayIncome";
            this.lblTodayIncome.Size = new System.Drawing.Size(93, 15);
            this.lblTodayIncome.TabIndex = 36;
            this.lblTodayIncome.Text = "12\'357\'964\'321";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalIncome.Location = new System.Drawing.Point(186, 70);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(93, 15);
            this.lblTotalIncome.TabIndex = 35;
            this.lblTotalIncome.Text = "12\'357\'964\'321";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Accounting.App.Properties.Resources.icons8_coin_in_hand_48;
            this.pictureBox4.Location = new System.Drawing.Point(78, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(105, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 15);
            this.label16.TabIndex = 31;
            this.label16.Text = "Your final balance : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(515, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Average income : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(515, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Average outcome :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Accounting.App.Properties.Resources.icons8_arrowOut_48;
            this.pictureBox2.Location = new System.Drawing.Point(78, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.icons8_arrowIn_48;
            this.pictureBox1.Location = new System.Drawing.Point(78, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Today income : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(302, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Today outcome : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total income : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total outcome : ";
            // 
            // tmrTransactionAnalysisRefresh
            // 
            this.tmrTransactionAnalysisRefresh.Enabled = true;
            this.tmrTransactionAnalysisRefresh.Interval = 1000;
            this.tmrTransactionAnalysisRefresh.Tick += new System.EventHandler(this.tmrTransactionAnalysisRefresh_Tick);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Accounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblWelcome;
        private System.Windows.Forms.ToolStripLabel lblSpaceBetween;
        private System.Windows.Forms.ToolStripLabel lblDay;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccountSide;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnApplicationUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUserPrivacy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.Timer tmrDateAndTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblAverageIncome;
        private System.Windows.Forms.Label lblTodayIncome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblAverageOutcome;
        private System.Windows.Forms.Label lblTodayOutcome;
        private System.Windows.Forms.Label lblTotalOutcome;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Timer tmrTransactionAnalysisRefresh;
    }
}

