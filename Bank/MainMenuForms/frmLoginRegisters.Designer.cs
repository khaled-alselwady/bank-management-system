namespace MainMenuForm.MainMenuForms
{
    partial class frmLoginRegisters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShowLoginRegistersList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLoginRegistersList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShowLoginRegistersList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 523);
            this.panel1.TabIndex = 0;
            // 
            // dgvShowLoginRegistersList
            // 
            this.dgvShowLoginRegistersList.AllowUserToAddRows = false;
            this.dgvShowLoginRegistersList.AllowUserToDeleteRows = false;
            this.dgvShowLoginRegistersList.AllowUserToOrderColumns = true;
            this.dgvShowLoginRegistersList.AllowUserToResizeRows = false;
            this.dgvShowLoginRegistersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowLoginRegistersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvShowLoginRegistersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowLoginRegistersList.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowLoginRegistersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowLoginRegistersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowLoginRegistersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowLoginRegistersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowLoginRegistersList.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShowLoginRegistersList.Location = new System.Drawing.Point(0, 0);
            this.dgvShowLoginRegistersList.Name = "dgvShowLoginRegistersList";
            this.dgvShowLoginRegistersList.ReadOnly = true;
            this.dgvShowLoginRegistersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShowLoginRegistersList.Size = new System.Drawing.Size(891, 523);
            this.dgvShowLoginRegistersList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // showPToolStripMenuItem
            // 
            this.showPToolStripMenuItem.Name = "showPToolStripMenuItem";
            this.showPToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showPToolStripMenuItem.Text = "Show Details";
            this.showPToolStripMenuItem.Click += new System.EventHandler(this.showPToolStripMenuItem_Click);
            // 
            // frmLoginRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(891, 523);
            this.Controls.Add(this.panel1);
            this.Name = "frmLoginRegisters";
            this.Tag = "Login Registers";
            this.Text = "frmLoginRegisters";
            this.Load += new System.EventHandler(this.frmLoginRegisters_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLoginRegistersList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowLoginRegistersList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPToolStripMenuItem;
    }
}