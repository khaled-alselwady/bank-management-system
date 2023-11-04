namespace MainMenuForm.MainMenuForms
{
    partial class frmAddNewClient
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.maskAccountBalance = new System.Windows.Forms.MaskedTextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.masktxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.masktxtLastName = new System.Windows.Forms.MaskedTextBox();
            this.masktxtFirstName = new System.Windows.Forms.MaskedTextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.maskAccountBalance);
            this.panel1.Controls.Add(this.txtPinCode);
            this.panel1.Controls.Add(this.masktxtPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.masktxtLastName);
            this.panel1.Controls.Add(this.masktxtFirstName);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAccountNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 556);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(378, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 55);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // maskAccountBalance
            // 
            this.maskAccountBalance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maskAccountBalance.ForeColor = System.Drawing.Color.Black;
            this.maskAccountBalance.Location = new System.Drawing.Point(173, 362);
            this.maskAccountBalance.Mask = "000000000000";
            this.maskAccountBalance.Name = "maskAccountBalance";
            this.maskAccountBalance.PromptChar = ' ';
            this.maskAccountBalance.Size = new System.Drawing.Size(261, 27);
            this.maskAccountBalance.TabIndex = 20;
            this.maskAccountBalance.ValidatingType = typeof(int);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPinCode.ForeColor = System.Drawing.Color.Black;
            this.txtPinCode.Location = new System.Drawing.Point(173, 299);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(261, 27);
            this.txtPinCode.TabIndex = 18;
            // 
            // masktxtPhone
            // 
            this.masktxtPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtPhone.ForeColor = System.Drawing.Color.Black;
            this.masktxtPhone.Location = new System.Drawing.Point(173, 247);
            this.masktxtPhone.Mask = "000000000000000000000";
            this.masktxtPhone.Name = "masktxtPhone";
            this.masktxtPhone.PromptChar = ' ';
            this.masktxtPhone.Size = new System.Drawing.Size(261, 27);
            this.masktxtPhone.TabIndex = 16;
            this.masktxtPhone.ValidatingType = typeof(int);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(173, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 27);
            this.txtEmail.TabIndex = 14;
            // 
            // masktxtLastName
            // 
            this.masktxtLastName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtLastName.ForeColor = System.Drawing.Color.Black;
            this.masktxtLastName.Location = new System.Drawing.Point(173, 142);
            this.masktxtLastName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.masktxtLastName.Name = "masktxtLastName";
            this.masktxtLastName.PromptChar = ' ';
            this.masktxtLastName.Size = new System.Drawing.Size(261, 27);
            this.masktxtLastName.TabIndex = 12;
            // 
            // masktxtFirstName
            // 
            this.masktxtFirstName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.masktxtFirstName.ForeColor = System.Drawing.Color.Black;
            this.masktxtFirstName.Location = new System.Drawing.Point(173, 88);
            this.masktxtFirstName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.masktxtFirstName.Name = "masktxtFirstName";
            this.masktxtFirstName.PromptChar = ' ';
            this.masktxtFirstName.Size = new System.Drawing.Size(261, 27);
            this.masktxtFirstName.TabIndex = 10;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Location = new System.Drawing.Point(173, 39);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(261, 27);
            this.txtAccountNumber.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Account Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pin Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNumber.Location = new System.Drawing.Point(33, 40);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(134, 19);
            this.lblAccountNumber.TabIndex = 9;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // frmAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(898, 556);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddNewClient";
            this.Tag = "Add New Client";
            this.Text = "frmAddNewClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox maskAccountBalance;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.MaskedTextBox masktxtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox masktxtLastName;
        private System.Windows.Forms.MaskedTextBox masktxtFirstName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}