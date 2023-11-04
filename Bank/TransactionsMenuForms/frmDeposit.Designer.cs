namespace MainMenuForm.TransactionsMenuForms
{
    partial class frmDeposit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShowClientInfo = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskDepositAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowClientInfo
            // 
            this.dgvShowClientInfo.AllowUserToAddRows = false;
            this.dgvShowClientInfo.AllowUserToDeleteRows = false;
            this.dgvShowClientInfo.AllowUserToOrderColumns = true;
            this.dgvShowClientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowClientInfo.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvShowClientInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowClientInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowClientInfo.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShowClientInfo.Location = new System.Drawing.Point(56, 136);
            this.dgvShowClientInfo.Name = "dgvShowClientInfo";
            this.dgvShowClientInfo.ReadOnly = true;
            this.dgvShowClientInfo.Size = new System.Drawing.Size(840, 66);
            this.dgvShowClientInfo.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(530, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 33);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Location = new System.Drawing.Point(228, 46);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(261, 27);
            this.txtAccountNumber.TabIndex = 43;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNumber.Location = new System.Drawing.Point(88, 47);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(134, 19);
            this.lblAccountNumber.TabIndex = 44;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnDeposit.Location = new System.Drawing.Point(530, 296);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(91, 33);
            this.btnDeposit.TabIndex = 49;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Deposit Amount:";
            // 
            // maskDepositAmount
            // 
            this.maskDepositAmount.Enabled = false;
            this.maskDepositAmount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maskDepositAmount.ForeColor = System.Drawing.Color.Black;
            this.maskDepositAmount.Location = new System.Drawing.Point(228, 298);
            this.maskDepositAmount.Mask = "000000000000";
            this.maskDepositAmount.Name = "maskDepositAmount";
            this.maskDepositAmount.PromptChar = ' ';
            this.maskDepositAmount.Size = new System.Drawing.Size(261, 27);
            this.maskDepositAmount.TabIndex = 50;
            this.maskDepositAmount.ValidatingType = typeof(int);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(668, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDeposit
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(918, 556);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.maskDepositAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShowClientInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "frmDeposit";
            this.Tag = "Deposit";
            this.Text = "frmDeposit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowClientInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskDepositAmount;
        private System.Windows.Forms.Button btnCancel;
    }
}