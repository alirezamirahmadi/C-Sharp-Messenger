using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class LoginUser : Form
    {
        static public bool isLogin = false;
        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checking() == false)
            {
                return;
            }
            try
            {
                if (ActiveDirectoryUsers.validateUser(txtUserName.Text, txtPassword.Text))
                {
                    DataBase.findMsgUser(txtUserName.Text);
                    isLogin = true;
                    if (chbSavePassword.Checked)
                    {
                        saveUserSetting();
                    }
                    else
                    {
                        txtUserName.Clear();
                        txtPassword.Clear();
                        saveUserSetting();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("کلمه یا رمز عبور اشتباه است");
                }
            }
            catch(Exception me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
            //DataBase.Connect();
            rtxtUserSetting.Visible = false;
            loadUserSetting();
            //txtUserName.Text = Environment.UserName;
            txtPassword.Select();
        }

        private bool checking()
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("کلمه عبور را وارد کنید");
                return false;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("رمز عبور را وارد کنید");
                return false;
            }
            return true;
        }

        private void keydownLogin(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(null, null);
            }
        }

        private void loadUserSetting()
        {
            try
            {
                string[] text = new string[2];
                rtxtUserSetting.LoadFile(@"D:\UserSet.cfg");
                text = AesCryp.decode(rtxtUserSetting.Text).Split('~');
                if (AesCryp.decode(rtxtUserSetting.Text).Length > 0)
                {
                    txtUserName.Text = text[0];
                    txtPassword.Text = text[1];
                    chbSavePassword.Checked = true;
                }
            }
            catch (Exception)
            { }
        }

        private void saveUserSetting()
        {
            try
            {
                rtxtUserSetting.Clear();
                rtxtUserSetting.Text = AesCryp.code(txtUserName.Text + "~" + txtPassword.Text);
                rtxtUserSetting.SaveFile(@"D:\UserSet.cfg");
            }
            catch (Exception)
            { }
        }
    }
}
