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
    public partial class Reminder : Form
    {
        private string idReminder = "";
        public Reminder(string _idreminder)
        {
            idReminder = _idreminder;
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            tsReminder.Visible = false;
            lbTitle.Visible = false;
            lbText.Visible = false;
            lbDate.Visible = false;
            lbHourInterval.Visible = false;
            load_Reminders();
        }

        private void load_Reminders()
        {
            dgvReminder.Rows.Clear();
            DataBase.searchMsgRemMessage(Main.idUser, 0);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                dgvReminder.Rows.Add(drow["IdRemMessage"].ToString(), drow["IdMessage"].ToString(), drow["Sender"].ToString(), Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime(drow["CreateDate"].ToString())), AesCryp.decode(drow["ReminderText"].ToString()), Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime( drow["ReminderDate"].ToString())), drow["Receiver"].ToString(), AesCryp.decode(drow["TextMessage"].ToString()), drow["HourInterval"].ToString());
            }
            if(dgvReminder.RowCount > 0 && idReminder == "")
            {
                selectRow(0);
            }
            else if (dgvReminder.RowCount > 0 && idReminder != "")
            {
                foreach(DataGridViewRow grow in dgvReminder.Rows)
                {
                    if(grow.Cells["IdRemMes"].Value.ToString() == idReminder)
                    {
                        selectRow(grow.Index);
                    }
                }
            }
        }

        private void load_AllReminders()
        {
            dgvReminder.Rows.Clear();
            DataBase.searchMsgRemMessage(Main.idUser, 1);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                dgvReminder.Rows.Add(drow["IdRemMessage"].ToString(), drow["IdMessage"].ToString(), drow["Sender"].ToString(), Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime(drow["CreateDate"].ToString())), AesCryp.decode(drow["ReminderText"].ToString()), Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime(drow["ReminderDate"].ToString())), drow["Receiver"].ToString(), AesCryp.decode(drow["TextMessage"].ToString()), drow["HourInterval"].ToString());
            }
            if (dgvReminder.RowCount > 0)
            {
                selectRow(0);
            }
        }

        private void dgvReminder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvReminder.Rows.Count)
            {
                selectRow(e.RowIndex);
            }
        }

        private void selectRow(int RowIndex)
        {
            lbTitle.Visible = true;
            lbText.Visible = true;
            lbDate.Visible = true;
            lbHourInterval.Visible = true;
            lbDate.Text = dgvReminder.Rows[RowIndex].Cells["RemDate"].Value.ToString();
            lbText.Text = dgvReminder.Rows[RowIndex].Cells["TextMessage"].Value.ToString();
            lbTitle.Text = dgvReminder.Rows[RowIndex].Cells["RemText"].Value.ToString();
            lbHourInterval.Text = getHourInterval(Convert.ToInt32(dgvReminder.Rows[RowIndex].Cells["HourInterval"].Value.ToString()));
            dgvReminder.CurrentCell = dgvReminder.Rows[RowIndex].Cells["RemText"];
        }

        private string getHourInterval(int hour)
        {
            if (hour % 24 == 0)
            {
                return "یادآوری هر" + (hour / 24).ToString() + "روز";
            }
            return "یادآوری هر" + hour.ToString() + "ساعت";
        }

        private void btnShowReminder_Click(object sender, EventArgs e)
        {
            load_Reminders();
        }

        private void btnShowAllReminder_Click(object sender, EventArgs e)
        {
            load_AllReminders();
        }
    }
}
