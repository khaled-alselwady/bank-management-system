namespace MainMenuForm.TransactionsMenuForms
{
    partial class frmWithdraw
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.maskWithdrawAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShowClientInfo = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(657, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // maskWithdrawAmount
            // 
            this.maskWithdrawAmount.Enabled = false;
            this.maskWithdrawAmount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maskWithdrawAmount.ForeColor = System.Drawing.Color.Black;
            this.maskWithdrawAmount.Location = new System.Drawing.Point(224, 321);
            this.maskWithdrawAmount.Mask = "000000000000";
            this.maskWithdrawAmount.Name = "maskWithdrawAmount";
            this.maskWithdrawAmount.PromptChar = ' ';
            this.maskWithdrawAmount.Size = new System.Drawing.Size(261, 27);
            this.maskWithdrawAmount.TabIndex = 58;
            this.maskWithdrawAmount.ValidatingType = typeof(int);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithdraw.Location = new System.Drawing.Point(519, 319);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(91, 33);
            this.btnWithdraw.TabIndex = 57;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Withdraw Amount:";
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
            this.dgvShowClientInfo.Location = new System.Drawing.Point(45, 159);
            this.dgvShowClientInfo.Name = "dgvShowClientInfo";
            this.dgvShowClientInfo.ReadOnly = true;
            this.dgvShowClientInfo.Size = new System.Drawing.Size(840, 66);
            this.dgvShowClientInfo.TabIndex = 55;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(519, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 33);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Location = new System.Drawing.Point(217, 69);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(261, 27);
            this.txtAccountNumber.TabIndex = 52;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNumber.Location = new System.Drawing.Point(77, 70);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(134, 19);
            this.lblAccountNumber.TabIndex = 53;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // frmWithdraw
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(918, 556);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.maskWithdrawAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShowClientInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "frmWithdraw";
            this.Tag = "Withdraw";
            this.Text = "frmWithdraw";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox maskWithdrawAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShowClientInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}