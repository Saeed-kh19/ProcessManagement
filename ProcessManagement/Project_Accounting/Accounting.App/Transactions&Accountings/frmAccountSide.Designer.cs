namespace Accounting.App
{
    partial class frmAccountSide
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblWelcome = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblDay = new System.Windows.Forms.ToolStripLabel();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgPersons = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).BeginInit();
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
            this.toolStripLabel2,
            this.lblDay,
            this.lblTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(424, 22);
            this.toolStripLabel2.Text = "                                                                                 " +
    "                       ";
            // 
            // lblDay
            // 
            this.lblDay.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblDay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(59, 22);
            this.lblDay.Text = "Saturday";
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 22);
            this.lblTime.Text = "12:34 PM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Person";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::Accounting.App.Properties.Resources.icons8_add_48;
            this.btnAddPerson.Location = new System.Drawing.Point(15, 152);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(55, 48);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Edit Person";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPerson.Image = global::Accounting.App.Properties.Resources.icons8_edit_48;
            this.btnEditPerson.Location = new System.Drawing.Point(16, 241);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(54, 49);
            this.btnEditPerson.TabIndex = 8;
            this.btnEditPerson.UseVisualStyleBackColor = false;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Refresh";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::Accounting.App.Properties.Resources.icons8_update_48;
            this.btnRefresh.Location = new System.Drawing.Point(15, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 46);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Remove Person";
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemovePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePerson.Image = global::Accounting.App.Properties.Resources.icons8_remove_48;
            this.btnRemovePerson.Location = new System.Drawing.Point(15, 333);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(55, 52);
            this.btnRemovePerson.TabIndex = 10;
            this.btnRemovePerson.UseVisualStyleBackColor = false;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(87, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1, 410);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dgPersons
            // 
            this.dgPersons.AllowUserToAddRows = false;
            this.dgPersons.AllowUserToDeleteRows = false;
            this.dgPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPersons.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgPersons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Mobile,
            this.Email});
            this.dgPersons.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgPersons.Location = new System.Drawing.Point(120, 79);
            this.dgPersons.Name = "dgPersons";
            this.dgPersons.ReadOnly = true;
            this.dgPersons.Size = new System.Drawing.Size(651, 344);
            this.dgPersons.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PersonID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Fullname";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "PhoneNumber";
            this.Mobile.HeaderText = "Phone Number";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email Address";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtSearch.Location = new System.Drawing.Point(228, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 19);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search People :  ";
            // 
            // frmAccountSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgPersons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemovePerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAccountSide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Side";
            this.Load += new System.EventHandler(this.frmAccountSide_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblWelcome;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblDay;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
    }
}