namespace MainMenuForm.UserMenuForms
{
    partial class frmAddNewUser
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
            this.chklistboxPermissions = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.masktxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.masktxtLastName = new System.Windows.Forms.MaskedTextBox();
            this.masktxtFirstName = new System.Windows.Forms.MaskedTextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chklistboxPermissions);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.masktxtPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.masktxtLastName);
            this.panel1.Controls.Add(this.masktxtFirstName);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 607);
            this.panel1.TabIndex = 0;
            // 
            // chklistboxPermissions
            // 
            this.chklistboxPermissions.CheckOnClick = true;
            this.chklistboxPermissions.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chklistboxPermissions.FormattingEnabled = true;
            this.chklistboxPermissions.Items.AddRange(new object[] {
            "All",
            "Show Clients List",
            "Add New Client",
            "Delete Client",
            "Update Client",
            "Find Client",
            "Transactions",
            "Manage Users",
            "Login Registers"});
            this.chklistboxPermissions.Location = new System.Drawing.Point(166, 345);
            this.chklistboxPermissions.Name = "chklistboxPermissions";
            this.chklistboxPermissions.Size = new System.Drawing.Size(203, 202);
            this.chklistboxPermissions.TabIndex = 38;
            this.chklistboxPermissions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklistboxPermissions_ItemCheck);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(425, 513);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 55);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(166, 282);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 27);
            this.txtPassword.TabIndex = 33;
            // 
            // masktxtPhone
            // 
            this.masktxtPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtPhone.ForeColor = System.Drawing.Color.Black;
            this.masktxtPhone.Location = new System.Drawing.Point(166, 230);
            this.masktxtPhone.Mask = "000000000000000000000";
            this.masktxtPhone.Name = "masktxtPhone";
            this.masktxtPhone.PromptChar = ' ';
            this.masktxtPhone.Size = new System.Drawing.Size(261, 27);
            this.masktxtPhone.TabIndex = 31;
            this.masktxtPhone.ValidatingType = typeof(int);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(166, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 27);
            this.txtEmail.TabIndex = 29;
            // 
            // masktxtLastName
            // 
            this.masktxtLastName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtLastName.ForeColor = System.Drawing.Color.Black;
            this.masktxtLastName.Location = new System.Drawing.Point(166, 125);
            this.masktxtLastName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.masktxtLastName.Name = "masktxtLastName";
            this.masktxtLastName.PromptChar = ' ';
            this.masktxtLastName.Size = new System.Drawing.Size(261, 27);
            this.masktxtLastName.TabIndex = 27;
            // 
            // masktxtFirstName
            // 
            this.masktxtFirstName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtFirstName.ForeColor = System.Drawing.Color.Black;
            this.masktxtFirstName.Location = new System.Drawing.Point(166, 71);
            this.masktxtFirstName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.masktxtFirstName.Name = "masktxtFirstName";
            this.masktxtFirstName.PromptChar = ' ';
            this.masktxtFirstName.Size = new System.Drawing.Size(261, 27);
            this.masktxtFirstName.TabIndex = 25;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(166, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 27);
            this.txtUserName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Permissions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(26, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 19);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "UserName:";
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(916, 607);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddNewUser";
            this.Tag = "Add New User";
            this.Text = "frmAddNewUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox masktxtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox masktxtLastName;
        private System.Windows.Forms.MaskedTextBox masktxtFirstName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckedListBox chklistboxPermissions;
    }
}