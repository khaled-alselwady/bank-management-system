using BankBusinessLayer;
using FontAwesome.Sharp;
using MainMenuForm.MainMenuForms;
using MainMenuForm.TransactionsMenuForms;
using MainMenuForm.UserMenuForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class frmMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Form frmDeniedMassage = new frmAccessDeniedMessage();

        clsUser _User;

        public frmMainMenu(clsUser User)
        {
            InitializeComponent();

            this._User = User;
            lblUserName.Text = _User.UserName;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 42);
            panelMenu.Controls.Add(leftBorderBtn);


            //HideSubMenu();
            panelSubMenuTransactions.Visible = false;
            panelSubMenuUsers.Visible = false;
            btnShowManageUserMenu.Location = new Point(0, 370);
            btnLoginRegister.Location = new Point(0, 412);
            btnLogOut.Location = new Point(0, 454);


            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }


        public enum enYLocationOfSumMenu
        {
            Deposit = 370, WithDraw = 412, TotalBalances = 454, Transfer = 496, TransfersLogList = 538,
            ShowUserList = 412, AddNewUser = 454, DeleteUser = 496, UpdateUser = 538, FindUser = 580
        }

        public enYLocationOfSumMenu YLocationOfSumMenu = enYLocationOfSumMenu.Deposit;

        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(169, 54, 161);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(135, 150, 21);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(255, 242, 88);
            public static Color color7 = Color.FromArgb(134, 109, 15);
            public static Color color8 = Color.FromArgb(124, 11, 51);
            public static Color color9 = Color.FromArgb(24, 161, 251);
            public static Color color10 = Color.FromArgb(193, 84, 67);
            public static Color color11 = Color.FromArgb(172, 126, 241);
            public static Color color12 = Color.FromArgb(164, 62, 122);
            public static Color color13 = Color.FromArgb(24, 132, 255);
            public static Color color14 = Color.FromArgb(255, 231, 88);
            public static Color color15 = Color.FromArgb(82, 145, 63);
            public static Color color16 = Color.FromArgb(255, 158, 93);
            public static Color color17 = Color.FromArgb(255, 150, 97);

        }


        //Methods
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;

                if (currentBtn.Tag != null && (currentBtn.Tag.ToString() == "SubMenu"))
                {
                    currentBtn.BackColor = Color.FromArgb(65, 62, 144);
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(2, (int)YLocationOfSumMenu);
                }
                else
                {
                    //To put the `left border` in the ManageUserButton after opining the `panelSubMenuTransactions`.
                    if (currentBtn.Tag != null && panelSubMenuTransactions.Visible && currentBtn.Tag.ToString() == "User")
                    {
                        leftBorderBtn.BackColor = RGBColors.color7;
                        leftBorderBtn.Location = new Point(0, 370);
                    }
                    else
                    {
                        leftBorderBtn.BackColor = color;
                        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    }

                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);

                }

                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button

                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {
                if (currentBtn.Tag != null && (currentBtn.Tag.ToString() == "SubMenu"))
                {
                    currentBtn.BackColor = Color.FromArgb(48, 46, 106);
                }
                else
                {
                    currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                }

                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                lblTitleChildForm.Text = childForm.Tag.ToString();
            }
            else
            {
                lblTitleChildForm.Text = childForm.Text;
            }
        }

        public bool _CheckAccessDenied(clsUser.enPermissions enPermissions)
        {

            if (this._User.Permissions == (int)clsUser.enPermissions.All)
            {
                return true;
            }


            if (((int)enPermissions & this._User.Permissions) == (int)enPermissions)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnShowClient_Click(object sender, EventArgs e)
        {
            if (!_CheckAccessDenied(clsUser.enPermissions.ShowClientsList))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            HideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmShowClientsList());
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessDenied(clsUser.enPermissions.AddNewClient))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            HideSubMenu();
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmAddNewClient());
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessDenied(clsUser.enPermissions.DeleteClient))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            HideSubMenu();
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmDeleteClient());
        }

        public void btnUpdateClient_Click(object sender, EventArgs e, string AccountNumber = "-1")
        {
            if (!_CheckAccessDenied(clsUser.enPermissions.UpdateClient))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            HideSubMenu();
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmUpdateClient(AccountNumber));
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessDenied(clsUser.enPermissions.FindClient))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            HideSubMenu();
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new frmFindClient());
        }

        private void btnShowTransactionsMenu_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessDenied(clsUser.enPermissions.Transactions))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            ActivateButton(sender, RGBColors.color6);
            ShowSumMenu(panelSubMenuTransactions);
            lblTitleChildForm.Text = "Transactions";

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void btnShowManageUserMenu_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessDenied(clsUser.enPermissions.ManageUsers))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            ActivateButton(sender, RGBColors.color7);
            ShowSumMenu(panelSubMenuUsers);

            lblTitleChildForm.Text = "Manage Users";

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender, RGBColors.color8);
            Form login = new frmLoginForm();
            login.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            HideSubMenu();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "    Home";
        }

        public void HideSubMenu()
        {
            if (panelSubMenuTransactions.Visible)
            {
                panelSubMenuTransactions.Visible = false;

            }

            if (panelSubMenuUsers.Visible)
            {
                panelSubMenuUsers.Visible = false;
            }

            btnShowManageUserMenu.Location = new Point(0, 370);
            btnLoginRegister.Location = new Point(0, 412);
            btnLogOut.Location = new Point(0, 454);
        }

        private void ShowSumMenu(Panel SumMenu)
        {
            if (SumMenu.Tag.ToString() == "Transactions")
            {

                if (SumMenu.Visible == false)
                {
                    HideSubMenu();
                    SumMenu.Visible = true;


                    btnShowManageUserMenu.Location = new Point(0, 582);
                    btnLoginRegister.Location = new Point(0, 624);
                    btnLogOut.Location = new Point(0, 666);


                }

                else
                {
                    SumMenu.Visible = false;


                    btnShowManageUserMenu.Location = new Point(0, 370);
                    btnLoginRegister.Location = new Point(0, 412);
                    btnLogOut.Location = new Point(0, 454);

                }

            }

            else
            {
                if (SumMenu.Visible == false)
                {
                    HideSubMenu();
                    SumMenu.Visible = true;
                    panelSubMenuUsers.Location = new Point(0, 412);
                    btnLoginRegister.Location = new Point(0, 623);
                    btnLogOut.Location = new Point(0, 665);

                }

                else
                {
                    SumMenu.Visible = false;
                    btnLoginRegister.Location = new Point(0, 412);
                    btnLogOut.Location = new Point(0, 454);
                }
            }
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnShowDeposit_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.Deposit;
            ActivateButton(sender, RGBColors.color9);
            OpenChildForm(new frmDeposit());
            //HideSubMenu();
        }

        private void btnShowWithdraw_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.WithDraw;
            ActivateButton(sender, RGBColors.color10);
            OpenChildForm(new frmWithdraw());
            //HideSubMenu();
        }

        private void btnTotalBalance_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.TotalBalances;
            ActivateButton(sender, RGBColors.color11);
            OpenChildForm(new frmTotalBalance());
            //HideSubMenu();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.Transfer;
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmTransfer(_User.UserName));
        }

        private void btnTransfersLogList_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.TransfersLogList;
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmTransfersLogList());
        }

        private void btnShowUsersList_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.ShowUserList;
            ActivateButton(sender, RGBColors.color12);
            OpenChildForm(new frmShowUsersList());
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.AddNewUser;
            ActivateButton(sender, RGBColors.color13);
            OpenChildForm(new frmAddNewUser());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.DeleteUser;
            ActivateButton(sender, RGBColors.color14);
            OpenChildForm(new frmDeleteUser());
        }


        public void btnUpdateUser_Click(object sender, EventArgs e, string UserName = "-1")
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.UpdateUser;
            ActivateButton(sender, RGBColors.color15);
            OpenChildForm(new frmUpdateUser(UserName));
        }

        public void btnUpdateUser_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.UpdateUser;
            ActivateButton(sender, RGBColors.color15);
            OpenChildForm(new frmUpdateUser("-1"));
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            YLocationOfSumMenu = enYLocationOfSumMenu.FindUser;
            ActivateButton(sender, RGBColors.color16);
            OpenChildForm(new frmFindUser());
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessDenied(clsUser.enPermissions.LoginRegisters))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            HideSubMenu();
            ActivateButton(sender, RGBColors.color17);
            OpenChildForm(new frmLoginRegisters());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (!_CheckAccessDenied(clsUser.enPermissions.UpdateClient))
            {
                frmDeniedMassage.ShowDialog();
                return;
            }

            HideSubMenu();
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmUpdateClient("-1"));
        }


    }
}
