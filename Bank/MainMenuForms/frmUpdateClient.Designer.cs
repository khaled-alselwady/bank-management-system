namespace MainMenuForm.MainMenuForms
{
    partial class frmUpdateClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.maskAccountBalance = new System.Windows.Forms.MaskedTextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.masktxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.masktxtLastName = new System.Windows.Forms.MaskedTextBox();
            this.masktxtFirstName = new System.Windows.Forms.MaskedTextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.maskAccountBalance);
            this.panel1.Controls.Add(this.txtPinCode);
            this.panel1.Controls.Add(this.masktxtPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.masktxtLastName);
            this.panel1.Controls.Add(this.masktxtFirstName);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Controls.Add(this.lblAccountBalance);
            this.panel1.Controls.Add(this.lblPinCode);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.lblAccountNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 556);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(427, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 55);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(530, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 33);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(176, 449);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 55);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // maskAccountBalance
            // 
            this.maskAccountBalance.Enabled = false;
            this.maskAccountBalance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maskAccountBalance.ForeColor = System.Drawing.Color.Black;
            this.maskAccountBalance.Location = new System.Drawing.Point(176, 359);
            this.maskAccountBalance.Mask = "000000000000";
            this.maskAccountBalance.Name = "maskAccountBalance";
            this.maskAccountBalance.PromptChar = ' ';
            this.maskAccountBalance.Size = new System.Drawing.Size(261, 27);
            this.maskAccountBalance.TabIndex = 35;
            this.maskAccountBalance.ValidatingType = typeof(int);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Enabled = false;
            this.txtPinCode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPinCode.ForeColor = System.Drawing.Color.Black;
            this.txtPinCode.Location = new System.Drawing.Point(176, 296);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(261, 27);
            this.txtPinCode.TabIndex = 33;
            // 
            // masktxtPhone
            // 
            this.masktxtPhone.Enabled = false;
            this.masktxtPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtPhone.ForeColor = System.Drawing.Color.Black;
            this.masktxtPhone.Location = new System.Drawing.Point(176, 244);
            this.masktxtPhone.Mask = "000000000000000000000";
            this.masktxtPhone.Name = "masktxtPhone";
            this.masktxtPhone.PromptChar = ' ';
            this.masktxtPhone.Size = new System.Drawing.Size(261, 27);
            this.masktxtPhone.TabIndex = 31;
            this.masktxtPhone.ValidatingType = typeof(int);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(176, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 27);
            this.txtEmail.TabIndex = 29;
            // 
            // masktxtLastName
            // 
            this.masktxtLastName.Enabled = false;
            this.masktxtLastName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtLastName.ForeColor = System.Drawing.Color.Black;
            this.masktxtLastName.Location = new System.Drawing.Point(176, 139);
            this.masktxtLastName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.masktxtLastName.Name = "masktxtLastName";
            this.masktxtLastName.PromptChar = ' ';
            this.masktxtLastName.Size = new System.Drawing.Size(261, 27);
            this.masktxtLastName.TabIndex = 27;
            // 
            // masktxtFirstName
            // 
            this.masktxtFirstName.Enabled = false;
            this.masktxtFirstName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtFirstName.ForeColor = System.Drawing.Color.Black;
            this.masktxtFirstName.Location = new System.Drawing.Point(176, 85);
            this.masktxtFirstName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.masktxtFirstName.Name = "masktxtFirstName";
            this.masktxtFirstName.PromptChar = ' ';
            this.masktxtFirstName.Size = new System.Drawing.Size(261, 27);
            this.masktxtFirstName.TabIndex = 25;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Location = new System.Drawing.Point(176, 36);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(261, 27);
            this.txtAccountNumber.TabIndex = 23;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAccountBalance.ForeColor = System.Drawing.Color.Black;
            this.lblAccountBalance.Location = new System.Drawing.Point(36, 359);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(130, 19);
            this.lblAccountBalance.TabIndex = 36;
            this.lblAccountBalance.Text = "Account Balance:";
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPinCode.ForeColor = System.Drawing.Color.Black;
            this.lblPinCode.Location = new System.Drawing.Point(36, 296);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(78, 19);
            this.lblPinCode.TabIndex = 34;
            this.lblPinCode.Text = "Pin Code:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(36, 244);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 19);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(36, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 19);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(36, 139);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 19);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(36, 83);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 19);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNumber.Location = new System.Drawing.Point(36, 37);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(134, 19);
            this.lblAccountNumber.TabIndex = 24;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // frmUpdateClient
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(898, 556);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateClient";
            this.Tag = "Update Client";
            this.Text = "frmUpdateClient";
            this.Load += new System.EventHandler(this.frmUpdateClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MaskedTextBox maskAccountBalance;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.MaskedTextBox masktxtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox masktxtLastName;
        private System.Windows.Forms.MaskedTextBox masktxtFirstName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}