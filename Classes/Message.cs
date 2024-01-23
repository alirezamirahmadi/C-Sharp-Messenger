using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Messenger
{
    class Message
    {

        #region ... Message

        static public void read_message(object newMessages)
        {
            if (newMessages != null)
            {
                DataTable table = (DataTable)newMessages;
                foreach (DataRow drow in table.Rows)
                {
                    if (!DataBase.findMsgReadMessage(Main.idUser, drow["IdMessage"].ToString()))
                    {
                        DataBase.insertIntoMsgReadMessage(drow["IdMessage"].ToString(), DateTime.Now);
                    }
                }
            }
        }

        static private bool checkSendMessage(string typeMessage, string textMessage, string remTextMessage, DateTime dtpReminder, DateTime dtpReminderFrom)
        {
            if (textMessage.Trim() == "")
            {
                return false;
            }
            if (typeMessage == "3" && (DateTime.Compare(dtpReminder.Date, DateTime.Now.Date) < 0 || DateTime.Compare(dtpReminderFrom.Date, DateTime.Now.Date) < 0))
            {
                MessageBox.Show("تاریخ انتخاب شده قبل از تاریخ جاری است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (typeMessage == "3" && DateTime.Compare(dtpReminder.Date, dtpReminderFrom.Date) < 0)
            {
                MessageBox.Show("تاریخ اول بعد از تاریخ دوم است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (typeMessage == "3" && remTextMessage.Trim() == "")
            {
                MessageBox.Show("عنوان یادآوری را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion

        #region ... Text

        static public void sendGroupTextMessage(string idGroup, string textMessage)
        {
            Main main = new Main();
            
            DataBase.searchMsgUserGroup(idGroup);
            DataTable table = DataBase.dataTable;
            if (checkSendMessage("1", textMessage, "", DateTime.Now, DateTime.Now))
            {
                foreach (DataRow drow in table.Rows)
                {
                    Conversation.checkActiveConversation(drow["refUser"].ToString());
                    Conversation.startNewConversation(drow["refUser"].ToString());
                    DataBase.searchOldConversation(Main.idUser, drow["refUser"].ToString());
                    if (DataBase.dataTable.Rows.Count == 1)
                    {
                        DataBase.insertIntoMsgMessage(DataBase.dataTable.Rows[0]["IdConversation"].ToString(), textMessage, DateTime.Now);
                    }
                }
                MessageBox.Show("پیام گروهی ارسال شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region ... Reminder 

        static public void alarmReminder()
        {
            
            DataBase.searchMsgPopRemMessage(Main.idUser);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                if (drow["HourInterval"].ToString() != "0")
                {
                    DateTime now = DateTime.Now;

                    DateTime from = Convert.ToDateTime(drow["ReminderFromDate"].ToString());
                    int hour = Convert.ToInt32(drow["HourInterval"].ToString());
                    while (DateTime.Compare(from, now) == -1)
                    {
                        from = from.AddHours(hour);
                        if (from.ToShortDateString() == now.ToShortDateString() && from.Hour == now.Hour && !Main.listOpenReminder.Contains(drow["IdMessage"].ToString()))
                        {
                            Main.listOpenReminder.Add(drow["IdMessage"].ToString());
                            PopupReminder pr = new PopupReminder(drow);
                            pr.Show();
                        }
                    }
                }
            }
        }

        static public void sendGroupReminder(string idGroup, string textMessage, string textReminder, int hourInterval, DateTime reminder, DateTime reminderFrom, string reciever)
        {

            DataBase.searchMsgUserGroup(idGroup);
            DataTable table = DataBase.dataTable;
            if (checkSendMessage("3", textMessage, textReminder, reminder, reminderFrom))
            {
                foreach (DataRow drow in table.Rows)
                {
                    Conversation.checkActiveConversation(drow["refUser"].ToString());
                    Conversation.startNewConversation(drow["refUser"].ToString());
                    DataBase.searchOldConversation(Main.idUser, drow["refUser"].ToString());
                    if (DataBase.dataTable.Rows.Count == 1)
                    {
                        DataBase.insertIntoMsgRemMessage(DataBase.dataTable.Rows[0]["IdConversation"].ToString(), textMessage, DateTime.Now, textReminder, hourInterval, reminder, reminderFrom, getUserInterval(reciever, drow["refUser"].ToString()));
                    }
                }
                MessageBox.Show("پیام یادآوری گروهی ارسال شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static private string getUserInterval(string reciever, string refUser)
        {
            if (reciever == "دریافت کننده")
            {
                return DataBase.insertIntoMsgRemUser(refUser);
            }
            else if (reciever == "ارسال کننده")
            {
                return DataBase.insertIntoMsgRemUser(Main.idUser);
            }
            else if (reciever == "هر دو")
            {
                return DataBase.insertIntoMsgRemUser(Main.idUser) + DataBase.insertIntoMsgRemUser(refUser);
            }
            return "";
        }
        #endregion

        #region ... File

        static public bool downloadFile(string path, string idMessage, string typeMessage)
        {
            try
            {
                byte[] file;
                if (typeMessage == "2")
                {
                    DataBase.searchMsgFile("IdMessage", idMessage);
                    DataTable table = DataBase.dataTable;
                    if (table.Rows.Count == 1)
                    {
                        file = (byte[])table.Rows[0]["FileSource"];

                        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                        fs.Write(file, 0, file.Length);
                        fs.Close();
                        if (!DataBase.findMsgDownloadedFile(idMessage))
                        {
                            DataBase.insertIntoMsgDownloadFile(table.Rows[0]["IdFile"].ToString(), DateTime.Now);
                        }
                        //DataBase.DeleteFromMsgFile("IdFile", dgvConversation.Rows[dgvConversation.SelectedCells[0].RowIndex].Cells["Id"].Value.ToString());
                    }
                    return true;
                }
                return false;
            }
            catch (Exception me)
            {
                //MessageBox.Show(me.Message);
                return false;
            }
        }

        static public int sizeAllFiles(string refUser)
        {
            int TotalSize = 0;
            DataBase.searchMsgMyFile(refUser);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                TotalSize += ((byte[])drow["FileSource"]).Length;
            }
            return TotalSize;
        }

        static public void sendGroupFile(string idGroup, string[] paths)
        {
            DataBase.searchMsgUserGroup(idGroup);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                Conversation.checkActiveConversation(drow["refUser"].ToString());
                Conversation.startNewConversation(drow["refUser"].ToString());
                FileStream stream;
                BinaryReader reader;
                foreach (string path in paths)
                {
                    byte[] file;
                    stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    if (stream.Length > Main.limitSizeFile)
                    {
                        MessageBox.Show("حجم فایل نباید بیش از 5 مگابایت باشد");
                        continue;
                    }
                    reader = new BinaryReader(stream);
                    file = reader.ReadBytes((int)stream.Length);

                    DataBase.searchOldConversation(Main.idUser, drow["refUser"].ToString());
                    if (DataBase.dataTable.Rows.Count == 1)
                    {
                        DataBase.insertIntoMsgFile(DataBase.dataTable.Rows[0]["IdConversation"].ToString(), Path.GetFileName(path), file, DateTime.Now);
                        //DataBase.insertIntoMsgMessage(DataBase.dataTable.Rows[0]["IdConversation"].ToString(), textMessage, DateTime.Now);
                    }
                }
            }
            MessageBox.Show("فایل گروهی ارسال شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
