using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BankBusinessLayer;

namespace MainMenuForm
{
    public partial class frmLoginForm : Form
    {

        Label overlayLabelHidingUserName = new Label();
        Label overlayLabelHidingPassword = new Label();
        byte NumberOfTrails = 3; 
        public frmLoginForm()
        {
            InitializeComponent();

            // To hide txtUserName            
            HideTxtUserName();

            //  To hide txtPassword
            HideTxtPassword();

            HandleFocusBetweenTxtUserNameAndPassword();

            HandleTypeInTxtUserName();

        }

        private void HideTxtUserName()
        {
            overlayLabelHidingUserName.BackColor = Color.Transparent;
            overlayLabelHidingUserName.Location = txtUserName.Location;
            overlayLabelHidingUserName.Size = txtUserName.Size;
            overlayLabelHidingUserName.ForeColor = txtUserName.ForeColor;
            overlayLabelHidingUserName.Font = txtUserName.Font;
            overlayLabelHidingUserName.Cursor = txtUserName.Cursor;
            overlayLabelHidingUserName.TextAlign = ContentAlignment.BottomLeft;
            this.Controls.Add(overlayLabelHidingUserName);
            overlayLabelHidingUserName.BringToFront();
        }

        private void HideTxtPassword()
        {
            overlayLabelHidingPassword.BackColor = Color.Transparent;
            overlayLabelHidingPassword.Location = txtPassword.Location;
            overlayLabelHidingPassword.Size = txtPassword.Size;
            overlayLabelHidingPassword.ForeColor = txtPassword.ForeColor;
            overlayLabelHidingPassword.Font = txtPassword.Font;
            overlayLabelHidingPassword.Cursor = txtPassword.Cursor;
            overlayLabelHidingPassword.TextAlign = ContentAlignment.BottomLeft;
            this.Controls.Add(overlayLabelHidingPassword);
            overlayLabelHidingPassword.BringToFront();
        }

        private void HandleFocusBetweenTxtUserNameAndPassword()
        {
            overlayLabelHidingPassword.Click += (sender, e) =>
            {
                txtPassword.Focus();
                panelUserName.BackColor = Color.FromArgb(173, 175, 181);
                panelPassword.BackColor = Color.FromArgb(67, 116, 179);
            };

            overlayLabelHidingUserName.Click += (sender, e) =>
            {
                txtUserName.Focus();
                panelUserName.BackColor = Color.FromArgb(67, 116, 179);
                panelPassword.BackColor = Color.FromArgb(173, 175, 181);
            };
        }

        private void HandleTypeInTxtUserName()
        {
            txtPassword.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (overlayLabelHidingPassword.Text.Length > 0)
                    {
                        overlayLabelHidingPassword.Text = overlayLabelHidingPassword.Text.Substring(0, overlayLabelHidingPassword.Text.Length - 1);
                    }
                    e.Handled = true; // Prevent Backspace key from being processed by the text box
                }
                else if (!char.IsLetterOrDigit((char)e.KeyCode) && !char.IsWhiteSpace((char)e.KeyCode))
                {
                    e.Handled = true; // Prevent non-character keys from being processed
                }
                else
                {
                    overlayLabelHidingPassword.Text += "*";
                }
            };
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelFullScreen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            overlayLabelHidingUserName.Text = txtUserName.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //overlayLabelHidingPassword.Text += "*";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsUser user = clsUser.Find(txtUserName.Text, txtPassword.Text);

            if (user == null)
            {
                NumberOfTrails--;
                lblInvalid.Visible = true;
                lblTrails.Visible = true;

                if (NumberOfTrails <= 1)
                {
                    lblTrails.Text = "You have 1 trail to login";
                }
                else
                {
                    lblTrails.Text = $"You have {NumberOfTrails} trails to login";
                }

                if (NumberOfTrails < 1)
                {
                    MessageBox.Show("You are locked after 3 failed trails.","Locked!");
                    Application.Exit();
                }

                return;
            }

            else
            {
                lblInvalid.Visible = false;
                lblTrails.Visible = false;

                user.SaveRegisterLogins();

                Form main = new frmMainMenu(user);
                main.Show();
                this.Hide();
            }

        }
    }
}
