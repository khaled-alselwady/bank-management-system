namespace MainMenuForm.TransactionsMenuForms
{
    partial class frmTotalBalance
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
            this.dgvShowInfoTotalBalances = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfoTotalBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowInfoTotalBalances
            // 
            this.dgvShowInfoTotalBalances.AllowUserToAddRows = false;
            this.dgvShowInfoTotalBalances.AllowUserToDeleteRows = false;
            this.dgvShowInfoTotalBalances.AllowUserToOrderColumns = true;
            this.dgvShowInfoTotalBalances.AllowUserToResizeRows = false;
            this.dgvShowInfoTotalBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowInfoTotalBalances.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvShowInfoTotalBalances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowInfoTotalBalances.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowInfoTotalBalances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowInfoTotalBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowInfoTotalBalances.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowInfoTotalBalances.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShowInfoTotalBalances.Location = new System.Drawing.Point(2, 1);
            this.dgvShowInfoTotalBalances.Name = "dgvShowInfoTotalBalances";
            this.dgvShowInfoTotalBalances.ReadOnly = true;
            this.dgvShowInfoTotalBalances.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvShowInfoTotalBalances.Size = new System.Drawing.Size(914, 446);
            this.dgvShowInfoTotalBalances.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(223, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Balances:";
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalances.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalBalances.Location = new System.Drawing.Point(378, 478);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(46, 23);
            this.lblTotalBalances.TabIndex = 3;
            this.lblTotalBalances.Text = "250";
            // 
            // frmTotalBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(918, 556);
            this.Controls.Add(this.lblTotalBalances);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShowInfoTotalBalances);
            this.Name = "frmTotalBalance";
            this.Tag = "Total Balances";
            this.Text = "frmTotalBalance";
            this.Load += new System.EventHandler(this.frmTotalBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfoTotalBalances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowInfoTotalBalances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalBalances;
    }
}