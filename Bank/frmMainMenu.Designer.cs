namespace MainMenuForm
{
    partial class frmMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLoginRegister = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuUsers = new System.Windows.Forms.Panel();
            this.btnFindUser = new FontAwesome.Sharp.IconButton();
            this.btnUpdateUser = new FontAwesome.Sharp.IconButton();
            this.btnDeleteUser = new FontAwesome.Sharp.IconButton();
            this.btnAddNewUser = new FontAwesome.Sharp.IconButton();
            this.btnShowUsersList = new FontAwesome.Sharp.IconButton();
            this.btnAddNewClient = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuTransactions = new System.Windows.Forms.Panel();
            this.btnTransfersLogList = new FontAwesome.Sharp.IconButton();
            this.btnTransfer = new FontAwesome.Sharp.IconButton();
            this.btnTotalBalance = new FontAwesome.Sharp.IconButton();
            this.btnShowDeposit = new FontAwesome.Sharp.IconButton();
            this.btnShowWithdraw = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnShowManageUserMenu = new FontAwesome.Sharp.IconButton();
            this.btnShowTransactionsMenu = new FontAwesome.Sharp.IconButton();
            this.btnFindClient = new FontAwesome.Sharp.IconButton();
            this.btnUpdateClient = new FontAwesome.Sharp.IconButton();
            this.btnDeleteClient = new FontAwesome.Sharp.IconButton();
            this.btnShowClient = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelMenu.SuspendLayout();
            this.panelSubMenuUsers.SuspendLayout();
            this.panelSubMenuTransactions.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnLoginRegister);
            this.panelMenu.Controls.Add(this.panelSubMenuUsers);
            this.panelMenu.Controls.Add(this.btnAddNewClient);
            this.panelMenu.Controls.Add(this.panelSubMenuTransactions);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnShowManageUserMenu);
            this.panelMenu.Controls.Add(this.btnShowTransactionsMenu);
            this.panelMenu.Controls.Add(this.btnFindClient);
            this.panelMenu.Controls.Add(this.btnUpdateClient);
            this.panelMenu.Controls.Add(this.btnDeleteClient);
            this.panelMenu.Controls.Add(this.btnShowClient);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 750);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.FlatAppearance.BorderSize = 0;
            this.btnLoginRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRegister.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLoginRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoginRegister.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnLoginRegister.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoginRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginRegister.IconSize = 32;
            this.btnLoginRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginRegister.Location = new System.Drawing.Point(0, 833);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLoginRegister.Size = new System.Drawing.Size(258, 42);
            this.btnLoginRegister.TabIndex = 9;
            this.btnLoginRegister.Text = "Login Registers";
            this.btnLoginRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginRegister.UseVisualStyleBackColor = true;
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // panelSubMenuUsers
            // 
            this.panelSubMenuUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.panelSubMenuUsers.Controls.Add(this.btnFindUser);
            this.panelSubMenuUsers.Controls.Add(this.btnUpdateUser);
            this.panelSubMenuUsers.Controls.Add(this.btnDeleteUser);
            this.panelSubMenuUsers.Controls.Add(this.btnAddNewUser);
            this.panelSubMenuUsers.Controls.Add(this.btnShowUsersList);
            this.panelSubMenuUsers.Location = new System.Drawing.Point(0, 623);
            this.panelSubMenuUsers.Name = "panelSubMenuUsers";
            this.panelSubMenuUsers.Size = new System.Drawing.Size(260, 210);
            this.panelSubMenuUsers.TabIndex = 0;
            this.panelSubMenuUsers.Tag = "Users";
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFindUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFindUser.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnFindUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFindUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindUser.IconSize = 32;
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.Location = new System.Drawing.Point(0, 168);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnFindUser.Size = new System.Drawing.Size(258, 42);
            this.btnFindUser.TabIndex = 16;
            this.btnFindUser.Tag = "SubMenu";
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindUser.UseVisualStyleBackColor = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateUser.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnUpdateUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateUser.IconSize = 32;
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(3, 126);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(258, 42);
            this.btnUpdateUser.TabIndex = 15;
            this.btnUpdateUser.Tag = "SubMenu";
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteUser.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.btnDeleteUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteUser.IconSize = 32;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 84);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(258, 42);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Tag = "SubMenu";
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddNewUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewUser.IconSize = 32;
            this.btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewUser.Location = new System.Drawing.Point(0, 42);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnAddNewUser.Size = new System.Drawing.Size(258, 42);
            this.btnAddNewUser.TabIndex = 13;
            this.btnAddNewUser.Tag = "SubMenu";
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnShowUsersList
            // 
            this.btnShowUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnShowUsersList.FlatAppearance.BorderSize = 0;
            this.btnShowUsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUsersList.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowUsersList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowUsersList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnShowUsersList.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowUsersList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowUsersList.IconSize = 32;
            this.btnShowUsersList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowUsersList.Location = new System.Drawing.Point(0, 0);
            this.btnShowUsersList.Name = "btnShowUsersList";
            this.btnShowUsersList.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnShowUsersList.Size = new System.Drawing.Size(258, 42);
            this.btnShowUsersList.TabIndex = 12;
            this.btnShowUsersList.Tag = "SubMenu";
            this.btnShowUsersList.Text = "Show Users List";
            this.btnShowUsersList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowUsersList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowUsersList.UseVisualStyleBackColor = false;
            this.btnShowUsersList.Click += new System.EventHandler(this.btnShowUsersList_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.FlatAppearance.BorderSize = 0;
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddNewClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewClient.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddNewClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewClient.IconSize = 32;
            this.btnAddNewClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewClient.Location = new System.Drawing.Point(0, 161);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddNewClient.Size = new System.Drawing.Size(258, 42);
            this.btnAddNewClient.TabIndex = 2;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // panelSubMenuTransactions
            // 
            this.panelSubMenuTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.panelSubMenuTransactions.Controls.Add(this.btnTransfersLogList);
            this.panelSubMenuTransactions.Controls.Add(this.btnTransfer);
            this.panelSubMenuTransactions.Controls.Add(this.btnTotalBalance);
            this.panelSubMenuTransactions.Controls.Add(this.btnShowDeposit);
            this.panelSubMenuTransactions.Controls.Add(this.btnShowWithdraw);
            this.panelSubMenuTransactions.Location = new System.Drawing.Point(0, 371);
            this.panelSubMenuTransactions.Name = "panelSubMenuTransactions";
            this.panelSubMenuTransactions.Size = new System.Drawing.Size(260, 210);
            this.panelSubMenuTransactions.TabIndex = 0;
            this.panelSubMenuTransactions.Tag = "Transactions";
            // 
            // btnTransfersLogList
            // 
            this.btnTransfersLogList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnTransfersLogList.FlatAppearance.BorderSize = 0;
            this.btnTransfersLogList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfersLogList.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTransfersLogList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransfersLogList.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnTransfersLogList.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTransfersLogList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransfersLogList.IconSize = 32;
            this.btnTransfersLogList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfersLogList.Location = new System.Drawing.Point(0, 168);
            this.btnTransfersLogList.Name = "btnTransfersLogList";
            this.btnTransfersLogList.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnTransfersLogList.Size = new System.Drawing.Size(258, 42);
            this.btnTransfersLogList.TabIndex = 13;
            this.btnTransfersLogList.Tag = "SubMenu";
            this.btnTransfersLogList.Text = "Transfers Log List";
            this.btnTransfersLogList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfersLogList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfersLogList.UseVisualStyleBackColor = false;
            this.btnTransfersLogList.Click += new System.EventHandler(this.btnTransfersLogList_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTransfer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnTransfer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransfer.IconSize = 32;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 126);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnTransfer.Size = new System.Drawing.Size(258, 42);
            this.btnTransfer.TabIndex = 12;
            this.btnTransfer.Tag = "SubMenu";
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTotalBalance
            // 
            this.btnTotalBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnTotalBalance.FlatAppearance.BorderSize = 0;
            this.btnTotalBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalBalance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTotalBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTotalBalance.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnTotalBalance.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTotalBalance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTotalBalance.IconSize = 32;
            this.btnTotalBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalBalance.Location = new System.Drawing.Point(0, 84);
            this.btnTotalBalance.Name = "btnTotalBalance";
            this.btnTotalBalance.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnTotalBalance.Size = new System.Drawing.Size(258, 42);
            this.btnTotalBalance.TabIndex = 11;
            this.btnTotalBalance.Tag = "SubMenu";
            this.btnTotalBalance.Text = "Total Balances";
            this.btnTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTotalBalance.UseVisualStyleBackColor = false;
            this.btnTotalBalance.Click += new System.EventHandler(this.btnTotalBalance_Click);
            // 
            // btnShowDeposit
            // 
            this.btnShowDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnShowDeposit.FlatAppearance.BorderSize = 0;
            this.btnShowDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDeposit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowDeposit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowDeposit.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.btnShowDeposit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowDeposit.IconSize = 32;
            this.btnShowDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDeposit.Location = new System.Drawing.Point(0, 0);
            this.btnShowDeposit.Name = "btnShowDeposit";
            this.btnShowDeposit.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnShowDeposit.Size = new System.Drawing.Size(258, 42);
            this.btnShowDeposit.TabIndex = 9;
            this.btnShowDeposit.Tag = "SubMenu";
            this.btnShowDeposit.Text = "Deposit";
            this.btnShowDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowDeposit.UseVisualStyleBackColor = false;
            this.btnShowDeposit.Click += new System.EventHandler(this.btnShowDeposit_Click);
            // 
            // btnShowWithdraw
            // 
            this.btnShowWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(106)))));
            this.btnShowWithdraw.FlatAppearance.BorderSize = 0;
            this.btnShowWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowWithdraw.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowWithdraw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowWithdraw.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btnShowWithdraw.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowWithdraw.IconSize = 32;
            this.btnShowWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowWithdraw.Location = new System.Drawing.Point(0, 42);
            this.btnShowWithdraw.Name = "btnShowWithdraw";
            this.btnShowWithdraw.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnShowWithdraw.Size = new System.Drawing.Size(258, 42);
            this.btnShowWithdraw.TabIndex = 10;
            this.btnShowWithdraw.Tag = "SubMenu";
            this.btnShowWithdraw.Text = "Withdraw";
            this.btnShowWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowWithdraw.UseVisualStyleBackColor = false;
            this.btnShowWithdraw.Click += new System.EventHandler(this.btnShowWithdraw_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 32;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 875);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogOut.Size = new System.Drawing.Size(258, 42);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShowManageUserMenu
            // 
            this.btnShowManageUserMenu.FlatAppearance.BorderSize = 0;
            this.btnShowManageUserMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowManageUserMenu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowManageUserMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowManageUserMenu.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnShowManageUserMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowManageUserMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowManageUserMenu.IconSize = 32;
            this.btnShowManageUserMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowManageUserMenu.Location = new System.Drawing.Point(0, 581);
            this.btnShowManageUserMenu.Name = "btnShowManageUserMenu";
            this.btnShowManageUserMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShowManageUserMenu.Size = new System.Drawing.Size(258, 42);
            this.btnShowManageUserMenu.TabIndex = 7;
            this.btnShowManageUserMenu.Tag = "User";
            this.btnShowManageUserMenu.Text = "Manage Users";
            this.btnShowManageUserMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowManageUserMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowManageUserMenu.UseVisualStyleBackColor = true;
            this.btnShowManageUserMenu.Click += new System.EventHandler(this.btnShowManageUserMenu_Click);
            // 
            // btnShowTransactionsMenu
            // 
            this.btnShowTransactionsMenu.FlatAppearance.BorderSize = 0;
            this.btnShowTransactionsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTransactionsMenu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowTransactionsMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowTransactionsMenu.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnShowTransactionsMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowTransactionsMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowTransactionsMenu.IconSize = 32;
            this.btnShowTransactionsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTransactionsMenu.Location = new System.Drawing.Point(0, 329);
            this.btnShowTransactionsMenu.Name = "btnShowTransactionsMenu";
            this.btnShowTransactionsMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShowTransactionsMenu.Size = new System.Drawing.Size(258, 42);
            this.btnShowTransactionsMenu.TabIndex = 6;
            this.btnShowTransactionsMenu.Text = "Transactions";
            this.btnShowTransactionsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTransactionsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTransactionsMenu.UseVisualStyleBackColor = true;
            this.btnShowTransactionsMenu.Click += new System.EventHandler(this.btnShowTransactionsMenu_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFindClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFindClient.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnFindClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFindClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindClient.IconSize = 32;
            this.btnFindClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.Location = new System.Drawing.Point(0, 287);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFindClient.Size = new System.Drawing.Size(258, 42);
            this.btnFindClient.TabIndex = 5;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClient.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnUpdateClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateClient.IconSize = 32;
            this.btnUpdateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClient.Location = new System.Drawing.Point(0, 245);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUpdateClient.Size = new System.Drawing.Size(258, 42);
            this.btnUpdateClient.TabIndex = 4;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteClient.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.btnDeleteClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteClient.IconSize = 32;
            this.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.Location = new System.Drawing.Point(0, 203);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDeleteClient.Size = new System.Drawing.Size(258, 42);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnShowClient
            // 
            this.btnShowClient.FlatAppearance.BorderSize = 0;
            this.btnShowClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowClient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowClient.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnShowClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowClient.IconSize = 32;
            this.btnShowClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowClient.Location = new System.Drawing.Point(0, 119);
            this.btnShowClient.Name = "btnShowClient";
            this.btnShowClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShowClient.Size = new System.Drawing.Size(258, 42);
            this.btnShowClient.TabIndex = 1;
            this.btnShowClient.Text = "Show Clients List";
            this.btnShowClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowClient.UseVisualStyleBackColor = true;
            this.btnShowClient.Click += new System.EventHandler(this.btnShowClient_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(260, 118);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(108, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::MainMenuForm.Properties.Resources.Logo2Update;
            this.btnHome.Location = new System.Drawing.Point(-86, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(323, 115);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblUserName);
            this.panelTitleBar.Controls.Add(this.label5);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.IconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(260, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(923, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(722, 47);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 17);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Admin";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(679, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "User:";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 18;
            this.btnMinimize.Location = new System.Drawing.Point(809, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 18;
            this.btnMaximize.Location = new System.Drawing.Point(847, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 32);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 18;
            this.btnExit.Location = new System.Drawing.Point(885, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(59, 32);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(60, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "    Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(18, 24);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(260, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(923, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 22F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(414, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "System";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Controls.Add(this.lblClock);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(260, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(923, 661);
            this.panelDesktop.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(99)))), ((int)(((byte)(188)))));
            this.lblDate.Location = new System.Drawing.Point(347, 363);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblClock
            // 
            this.lblClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClock.AutoSize = true;
            this.lblClock.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblClock.Font = new System.Drawing.Font("Arial", 37.25F);
            this.lblClock.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClock.Location = new System.Drawing.Point(349, 302);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(221, 57);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 40.25F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(404, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 61);
            this.label4.TabIndex = 2;
            this.label4.Text = "BANK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::MainMenuForm.Properties.Resources.Logo2Update;
            this.pictureBox1.Location = new System.Drawing.Point(138, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 15;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1183, 750);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1183, 715);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuUsers.ResumeLayout(false);
            this.panelSubMenuTransactions.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnShowClient;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnShowManageUserMenu;
        private FontAwesome.Sharp.IconButton btnShowTransactionsMenu;
        private FontAwesome.Sharp.IconButton btnFindClient;
        private FontAwesome.Sharp.IconButton btnDeleteClient;
        private FontAwesome.Sharp.IconButton btnAddNewClient;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnTotalBalance;
        private FontAwesome.Sharp.IconButton btnShowWithdraw;
        private FontAwesome.Sharp.IconButton btnShowDeposit;
        private System.Windows.Forms.Panel panelSubMenuUsers;
        private FontAwesome.Sharp.IconButton btnFindUser;
        private FontAwesome.Sharp.IconButton btnDeleteUser;
        private FontAwesome.Sharp.IconButton btnAddNewUser;
        private FontAwesome.Sharp.IconButton btnShowUsersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private FontAwesome.Sharp.IconButton btnLoginRegister;
        public FontAwesome.Sharp.IconButton btnUpdateClient;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSubMenuTransactions;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTitleChildForm;
        public FontAwesome.Sharp.IconButton btnUpdateUser;
        private FontAwesome.Sharp.IconButton btnTransfer;
        private FontAwesome.Sharp.IconButton btnTransfersLogList;
    }
}

