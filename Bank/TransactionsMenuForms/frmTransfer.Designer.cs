namespace MainMenuForm.TransactionsMenuForms
{
    partial class frmTransfer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvShowClientInfoTo = new System.Windows.Forms.DataGridView();
            this.btnSearchTo = new System.Windows.Forms.Button();
            this.txtAccountNumberTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShowClientInfoFrom = new System.Windows.Forms.DataGridView();
            this.btnSearchFrom = new System.Windows.Forms.Button();
            this.txtAccountNumberFrom = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfoTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfoFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtTransferAmount);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnTransfer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvShowClientInfoTo);
            this.panel1.Controls.Add(this.btnSearchTo);
            this.panel1.Controls.Add(this.txtAccountNumberTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvShowClientInfoFrom);
            this.panel1.Controls.Add(this.btnSearchFrom);
            this.panel1.Controls.Add(this.txtAccountNumberFrom);
            this.panel1.Controls.Add(this.lblAccountNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 556);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(747, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.Location = new System.Drawing.Point(612, 448);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(91, 33);
            this.btnTransfer.TabIndex = 55;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(150, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Transfer Amount:";
            // 
            // dgvShowClientInfoTo
            // 
            this.dgvShowClientInfoTo.AllowUserToAddRows = false;
            this.dgvShowClientInfoTo.AllowUserToDeleteRows = false;
            this.dgvShowClientInfoTo.AllowUserToOrderColumns = true;
            this.dgvShowClientInfoTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowClientInfoTo.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvShowClientInfoTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowClientInfoTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowClientInfoTo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowClientInfoTo.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShowClientInfoTo.Location = new System.Drawing.Point(284, 293);
            this.dgvShowClientInfoTo.Name = "dgvShowClientInfoTo";
            this.dgvShowClientInfoTo.ReadOnly = true;
            this.dgvShowClientInfoTo.Size = new System.Drawing.Size(419, 66);
            this.dgvShowClientInfoTo.TabIndex = 53;
            // 
            // btnSearchTo
            // 
            this.btnSearchTo.Enabled = false;
            this.btnSearchTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearchTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearchTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearchTo.ForeColor = System.Drawing.Color.Black;
            this.btnSearchTo.Location = new System.Drawing.Point(612, 246);
            this.btnSearchTo.Name = "btnSearchTo";
            this.btnSearchTo.Size = new System.Drawing.Size(91, 33);
            this.btnSearchTo.TabIndex = 52;
            this.btnSearchTo.Text = "Search";
            this.btnSearchTo.UseVisualStyleBackColor = true;
            this.btnSearchTo.Click += new System.EventHandler(this.btnSearchTo_Click);
            // 
            // txtAccountNumberTo
            // 
            this.txtAccountNumberTo.Enabled = false;
            this.txtAccountNumberTo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAccountNumberTo.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumberTo.Location = new System.Drawing.Point(312, 250);
            this.txtAccountNumberTo.Name = "txtAccountNumberTo";
            this.txtAccountNumberTo.Size = new System.Drawing.Size(261, 27);
            this.txtAccountNumberTo.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Account Number to Transfer to:";
            // 
            // dgvShowClientInfoFrom
            // 
            this.dgvShowClientInfoFrom.AllowUserToAddRows = false;
            this.dgvShowClientInfoFrom.AllowUserToDeleteRows = false;
            this.dgvShowClientInfoFrom.AllowUserToOrderColumns = true;
            this.dgvShowClientInfoFrom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowClientInfoFrom.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvShowClientInfoFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowClientInfoFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowClientInfoFrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowClientInfoFrom.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShowClientInfoFrom.Location = new System.Drawing.Point(284, 112);
            this.dgvShowClientInfoFrom.Name = "dgvShowClientInfoFrom";
            this.dgvShowClientInfoFrom.ReadOnly = true;
            this.dgvShowClientInfoFrom.Size = new System.Drawing.Size(419, 66);
            this.dgvShowClientInfoFrom.TabIndex = 49;
            // 
            // btnSearchFrom
            // 
            this.btnSearchFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearchFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearchFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFrom.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearchFrom.ForeColor = System.Drawing.Color.Black;
            this.btnSearchFrom.Location = new System.Drawing.Point(612, 62);
            this.btnSearchFrom.Name = "btnSearchFrom";
            this.btnSearchFrom.Size = new System.Drawing.Size(91, 33);
            this.btnSearchFrom.TabIndex = 48;
            this.btnSearchFrom.Text = "Search";
            this.btnSearchFrom.UseVisualStyleBackColor = true;
            this.btnSearchFrom.Click += new System.EventHandler(this.btnSearchFrom_Click);
            // 
            // txtAccountNumberFrom
            // 
            this.txtAccountNumberFrom.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAccountNumberFrom.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumberFrom.Location = new System.Drawing.Point(312, 66);
            this.txtAccountNumberFrom.Name = "txtAccountNumberFrom";
            this.txtAccountNumberFrom.Size = new System.Drawing.Size(261, 27);
            this.txtAccountNumberFrom.TabIndex = 46;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNumber.Location = new System.Drawing.Point(50, 69);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(256, 19);
            this.lblAccountNumber.TabIndex = 47;
            this.lblAccountNumber.Text = "Account Number to Transfer from:";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Enabled = false;
            this.txtTransferAmount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTransferAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTransferAmount.Location = new System.Drawing.Point(312, 450);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(261, 27);
            this.txtTransferAmount.TabIndex = 58;
            this.txtTransferAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskTransferAmount_KeyPress);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(918, 556);
            this.Controls.Add(this.panel1);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfoTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClientInfoFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchFrom;
        private System.Windows.Forms.TextBox txtAccountNumberFrom;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.DataGridView dgvShowClientInfoTo;
        private System.Windows.Forms.Button btnSearchTo;
        private System.Windows.Forms.TextBox txtAccountNumberTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShowClientInfoFrom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransferAmount;
    }
}