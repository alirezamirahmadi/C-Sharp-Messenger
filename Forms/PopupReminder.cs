using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Messenger
{
    public partial class PopupReminder : Form
    {
        private DataRow Reminder;
        public PopupReminder(DataRow _reminder)
        {
            Reminder = _reminder;
            InitializeComponent();
        }

        private void PopupReminder_Load(object sender, EventArgs e)
        {
            lbTitle.Visible = false;
            lbRemDate.Visible = false;
            lbName.Visible = false;
            lbCreateDate.Visible = false;
            load_Reminder();
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width - 10 , Screen.PrimaryScreen.Bounds.Height - Size.Height - 50);
        }

        private void load_Reminder()
        {
            if (Reminder != null)
            {
                lbTitle.Visible = true;
                lbRemDate.Visible = true;
                lbName.Visible = true;
                lbCreateDate.Visible = true;
                lbCreateDate.Text = "تاریخ ارسال: " + Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime(Reminder["CreateDate"].ToString()));
                lbRemDate.Text = "تاریخ یادآوری: " + Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime(Reminder["ReminderDate"].ToString()));
                lbTitle.Text = AesCryp.decode(Reminder["ReminderText"].ToString());
                if(Reminder["RefUser"].ToString() == Main.idUser)
                {
                    lbName.Text = Reminder["Receiver"].ToString();
                }
                else
                {
                    lbName.Text = Reminder["Sender"].ToString();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main.listOpenReminder.Remove(Reminder["IdMessage"].ToString());
            Close();
        }
    }
}
