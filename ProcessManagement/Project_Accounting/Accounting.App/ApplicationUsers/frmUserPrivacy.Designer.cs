namespace Accounting.App
{
    partial class frmUserPrivacy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAllow = new System.Windows.Forms.RadioButton();
            this.rbBlock = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Profile Visibility : ";
            // 
            // rbAllow
            // 
            this.rbAllow.AutoSize = true;
            this.rbAllow.Location = new System.Drawing.Point(124, 60);
            this.rbAllow.Name = "rbAllow";
            this.rbAllow.Size = new System.Drawing.Size(50, 17);
            this.rbAllow.TabIndex = 8;
            this.rbAllow.TabStop = true;
            this.rbAllow.Text = "Allow";
            this.rbAllow.UseVisualStyleBackColor = true;
            // 
            // rbBlock
            // 
            this.rbBlock.AutoSize = true;
            this.rbBlock.Location = new System.Drawing.Point(180, 60);
            this.rbBlock.Name = "rbBlock";
            this.rbBlock.Size = new System.Drawing.Size(52, 17);
            this.rbBlock.TabIndex = 9;
            this.rbBlock.TabStop = true;
            this.rbBlock.Text = "Block";
            this.rbBlock.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(47, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 18);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Saeed Khajeh Khalili";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(12, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 31);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(99)))), ((int)(((byte)(237)))));
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(99)))), ((int)(((byte)(237)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveChanges.Location = new System.Drawing.Point(113, 112);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(119, 31);
            this.btnSaveChanges.TabIndex = 32;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmUserPrivacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(397, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rbBlock);
            this.Controls.Add(this.rbAllow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserPrivacy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Privacy";
            this.Load += new System.EventHandler(this.frmUserPrivacy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAllow;
        private System.Windows.Forms.RadioButton rbBlock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}