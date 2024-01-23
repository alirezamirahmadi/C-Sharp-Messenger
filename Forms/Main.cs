using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Media;
using System.Reflection;

namespace Messenger
{
    public partial class Main : Form
    {
        static public string idUser = "";
        static public string[] idConversation = new string[2];
        static public int limitSizeFile = 0;
        static private int limitSizeAllFile = 0;
        static public ArrayList listOfConversation = new ArrayList();
        static public ArrayList listOpenReminder = new ArrayList();

        private bool isClose = false;
        private DataTable forwardMes = new DataTable();

        public Main()
        {
            InitializeComponent();
        }

        #region ... Form

        private void Main_Load(object sender, EventArgs e)
        {
            DataBase.Connect();
            DataBase.searchMsgUser("All", "");
            DataBase.dataTable.WriteXml("a.xml");
            return;

            addToStartup();
            login();

            try
            {
                DataBase.searchMsgUser("IdUser", idUser);
                if (DataBase.dataTable.Rows.Count == 1)
                {
                    lbName.Text = DataBase.dataTable.Rows[0]["FirstName"].ToString() + " " + DataBase.dataTable.Rows[0]["LastName"].ToString();
                    nfiMain.Text = lbName.Text + " - " + "پیام رسان گروه صنایع سیمان کرمان";
                }

                lbUserName.Text = DataBase.dataTable.Rows[0]["UserName"].ToString();
                dgvListUser.Visible = false;
                cbtnCloseWindow.Visible = false;
                btnExit.Visible = false;
                clearReminderItem();

                //btnFileManagement.Visible = false;
                //dtpReminder.SetTodayDate(DateTime.Now);
                //dtpReminderFrom.SetTodayDate(DateTime.Now);
                dgvListConversation.Dock = DockStyle.Fill;
                DGVSelectionStyle();
                load_ListConversations();
                load_newMessages();
                load_OnlineUserListConversation();
                Message.alarmReminder();
                addDateToForwardTable(-1);
                tiNewMessage.Start();
                tiReminder.Start();
                DataBase.DeleteFromOnlineUser();
                DataBase.insertIntoMsgOnlineUser(DateTime.Now);
                dgvListConversation.CurrentCell = null;
                nfiMain.Visible = true;

                limitSizeFile = 10 * 1024 * 1024;
                limitSizeAllFile = 1 * 1024 * 1024 * 100;

                Visible = false;
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
                MessageBox.Show("کاربری شما دچار مشکل شده است");
                Exit();
            }
        }

        private void login()
        {
            try
            {

                DataBase.Connect();
                if (isApplicationOpen())
                {
                    MessageBox.Show("نرم افزار پیام رسان قبلا باز شده است");
                    Exit();
                }
                else
                {
                    //****** Login With Username and Password

                    //LoginUser luser = new LoginUser();
                    //luser.ShowDialog();
                    //if (!LoginUser.isLogin || idUser == "")
                    //{
                    //    Exit();
                    //}

                    //****** Login Without Username and Password *** and Login With Username and Password

                    DataBase.findMsgUser(ActiveDirectoryUsers.getCurrentUser());
                    if (idUser == "")
                    {
                        //Exit();
                        LoginUser luser = new LoginUser();
                        luser.ShowDialog();
                        if (!LoginUser.isLogin || idUser == "")
                        {
                            Exit();
                        }
                    }
                }
            }
            catch (Exception)
            {
                Exit();
            }
        }

        private void checkLogOnline()
        {
            if(!DataBase.findMsgOnlineUser(idUser))
            {
                Exit();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClose)
            {
                nfiMain.BalloonTipText = "نرم افزار پیام رسان همچنان باز است";
                nfiMain.ShowBalloonTip(3);
                e.Cancel = true;
                Visible = false;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBase.updateMsgUser(DateTime.Now);
            DataBase.DeleteFromOnlineUser();
        }

        private void cbtnOpenWindow_Click(object sender, EventArgs e)
        {
            popupWindow();
        }

        private void nfiMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
        }

        private void cbtnCloseWindow_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        #endregion

        #region ... User

        public void load_User()
        {
            try
            {
                dgvListUser.Rows.Clear();
                DataBase.searchMsgUser("All", "");
                DataTable tableAllUser = DataBase.dataTable;
                foreach (DataRow drow in tableAllUser.Rows)
                {
                    if (drow["IdUser"].ToString() == idUser)
                    {
                        continue;
                    }
                    dgvListUser.Rows.Add(drow["IdUser"].ToString(), imlStatus.Images[0], drow["FirstName"].ToString() + " " + drow["LastName"].ToString());
                    //loadLastSeenInUsers(drow["IdUser"].ToString(), drow["LastSeen"].ToString());
                    if (DataBase.findMsgOnlineUser(drow["IdUser"].ToString()))
                    {
                        dgvListUser.Rows[dgvListUser.Rows.Count - 1].Cells["StatusUr"].Value = imlStatus.Images[1];
                    }
                }
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void load_OnlineUser()
        {
            if(!dgvListUser.Visible)
            {
                return;
            }
            foreach (DataGridViewRow grow in dgvListUser.Rows)
            {
                if (DataBase.findMsgOnlineUser(grow.Cells["IdUr"].Value.ToString()))
                {
                    grow.Cells["StatusUr"].Value = imlStatus.Images[1];
                    grow.Cells["NameUr"].ToolTipText = "آنلاین";
                    //grow.DefaultCellStyle.ForeColor = Color.Green;
                }
                else
                {
                    grow.Cells["StatusUr"].Value = imlStatus.Images[0];
                    grow.Cells["NameUr"].ToolTipText = "";
                    //grow.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void load_Groups()
        {
            bool check = false;
            DataBase.searchMsgGroup("All", "");
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                check = false;
                foreach (DataGridViewRow grow in dgvListConversation.Rows)
                {
                    if (grow.Cells["TypeCon"].Value.ToString() == "2" && drow["IdGroup"].ToString() == grow.Cells["IdCon"].Value.ToString())
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    dgvListConversation.Rows.Add("2", drow["IdGroup"].ToString(), "0", imlStatus.Images[2], drow["GroupName"].ToString(), drow["About"].ToString());
                }
            }

            foreach (DataGridViewRow grow in dgvListConversation.Rows)
            {
                check = false;
                foreach (DataRow drow in table.Rows)
                {
                    if (grow.Cells["TypeCon"].Value.ToString() == "2" && drow["IdGroup"].ToString() == grow.Cells["IdCon"].Value.ToString())
                    {
                        check = true;
                    }
                }
                if (!check && grow.Cells["TypeCon"].Value.ToString() == "2")
                {
                    grow.Cells["TypeCon"].Value = "-1";
                    grow.Visible = false;
                }
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            show_User();
        }

        private void show_User()
        {
            lbTypeList.Text = "لیست کاربران";
            dgvListConversation.Visible = false;
            dgvListUser.Visible = true;
            dgvListUser.Dock = DockStyle.Fill;

            load_User();
            txtSearchItem.Focus();
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            if (dgvListUser.Visible)
            {
                foreach (DataGridViewRow grow in dgvListUser.Rows)
                {
                    if (grow.Cells["NameUr"].Value.ToString().Contains(txtSearchItem.Text))
                    {
                        grow.Visible = true;
                    }
                    else
                    {
                        grow.Visible = false;
                    }
                }
            }
            else if (dgvListConversation.Visible)
            {
                foreach (DataGridViewRow grow in dgvListConversation.Rows)
                {
                    if (grow.Cells["ToolTipCon"].Value.ToString().Contains(txtSearchItem.Text))
                    {
                        grow.Visible = true;
                    }
                    else
                    {
                        grow.Visible = false;
                    }
                }
            }
        }

        private void dgvListUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            startNewConversation(dgvListUser.Rows[e.RowIndex].Cells["IdUr"].Value.ToString());
            checkedItemListConversation("1", idConversation[1]);
            show_Conversation();
        }

        private void dgvListUser_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            loadLastSeenInUsers(dgvListUser.Rows[e.RowIndex].Cells["IdUr"].Value.ToString(), e.RowIndex);
        }

        private void loadLastSeenInUsers(string iduser, int rowIndex)
        {
            if (DataBase.findMsgOnlineUser(iduser))
            {
                dgvListUser.Rows[rowIndex].Cells["NameUr"].ToolTipText = "آنلاین";
            }
            else
            {
                try
                {
                    DataBase.searchMsgUser("IdUser", iduser);
                    dgvListUser.Rows[rowIndex].Cells["NameUr"].ToolTipText = "آخرین بازدید: " + Time.convertMiladiToShamsi(Convert.ToDateTime(DataBase.dataTable.Rows[0]["LastSeen"].ToString()));
                }
                catch { }
            }

            //if (DataBase.findMsgOnlineUser(iduser))
            //{
            //    dgvListUser.Rows[dgvListUser.Rows.Count - 1].Cells["StatusUr"].Value = imlStatus.Images[1];
            //    dgvListUser.Rows[dgvListUser.Rows.Count - 1].Cells["NameUr"].ToolTipText = "آنلاین";
            //}
            //else
            //{
            //    try
            //    {
            //        dgvListUser.Rows[dgvListUser.Rows.Count - 1].Cells["NameUr"].ToolTipText = "آخرین بازدید: " + Time.convertMiladiToShamsi(Convert.ToDateTime(lastSeen));
            //    }
            //    catch { }
            //}
        }

        private void btnGroupUser_Click(object sender, EventArgs e)
        {
            GroupUser gUser = new GroupUser();
            gUser.ShowDialog();
            //load_Conversations();
            //load_newMessages();
            //load_OnlineUserListConversation();
            //load_Messages();
            //dgvListConversation.Rows.Clear();
            load_ListConversations();
        }
        #endregion

        #region ... Conversation

        private void load_ListConversations()
        {
            // 1=conversation 2=group
            load_Conversation();
            load_Groups();
            checkedItemListConversation("1", idConversation[1]);
        }

        private void load_Conversation()
        {
            string name = "";
            bool check = false;
            DataBase.searchMsgConversation(idUser);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                check = false;
                foreach (DataGridViewRow grow in dgvListConversation.Rows)
                {
                    if (grow.Cells["TypeCon"].Value.ToString() == "1" && drow["IdConversation"].ToString() == grow.Cells["IdCon"].Value.ToString())
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    name = drow["FirstName"].ToString() + " " + drow["LastName"].ToString();
                    dgvListConversation.Rows.Add("1", drow["IdConversation"].ToString(), drow["refUser"].ToString(), imlStatus.Images[0], name, name);
                }
            }
        }

        private void load_OnlineUserListConversation()
        {
            if(!dgvListConversation.Visible)
            {
                return;
            }
            foreach (DataGridViewRow grow in dgvListConversation.Rows)
            {
                if (grow.Cells["TypeCon"].Value.ToString() == "1")
                {
                    if (DataBase.findMsgOnlineUser(grow.Cells["refUser"].Value.ToString()))
                    {
                        grow.Cells["StatusUser"].Value = imlStatus.Images[1];
                        //grow.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        grow.Cells["StatusUser"].Value = imlStatus.Images[0];
                        //grow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private int load_OldConversation(string idUserPar)
        {
            //dgvListConversation.Rows.Clear();
            DataBase.searchOldConversation(idUser, idUserPar);
            if (DataBase.dataTable.Rows.Count == 1)
            {
                idConversation[1] = DataBase.dataTable.Rows[0]["IdConversation"].ToString();
                idConversation[0] = "1";
                //load_Conversations();
                foreach (DataGridViewRow grow in dgvListConversation.Rows)
                {
                    if (grow.Cells["IdCon"].Value.ToString() == idConversation[1])
                    {
                        idConversation[1] = grow.Cells["IdCon"].Value.ToString();
                        idConversation[0] = "1";
                        load_Messages();
                        return Convert.ToInt32(grow.Cells["IdCon"].Value.ToString());
                    }
                }
            }
            else if (DataBase.dataTable.Rows.Count == 0)
            {
                return 0;
            }
            MessageBox.Show("مشکل در ایجاد مکالمه");
            return -1;
        }

        private void startNewConversation(string idUserPar)
        {
            if (load_OldConversation(idUserPar) != 0)
            {
                return;
            }
            DataBase.searchAllConversation(idUser, idUserPar);
            if (DataBase.dataTable.Rows.Count == 1)
            {
                string idCon = DataBase.dataTable.Rows[0]["IdConversation"].ToString();
                string idDel = DataBase.findMsgDelConversation(idCon, idUser);
                if (idDel != "")
                {
                    DataBase.DeleteFromMsgDelConversation(idDel);
                }
                load_ListConversations();
                load_newMessages();
                load_OnlineUserListConversation();
                load_OldConversation(idUserPar);
                return;
            }
            else if (DataBase.dataTable.Rows.Count == 0)
            {
                new_Conversation(idUserPar, "");
                return;
            }
            else
            {
                MessageBox.Show("مشکل در ایجاد مکالمه");
            }
        }

        public void new_Conversation(string refUser, string title)
        {
            int idCon = DataBase.insertIntoMsgConversation(title, DateTime.Now, refUser, DateTime.Now);
            load_ListConversations();
            //load_newMessages();
            load_OnlineUserListConversation();
            foreach (DataGridViewRow grow in dgvListConversation.Rows)
            {
                if (grow.Cells["IdCon"].Value.ToString() == idCon.ToString())
                {
                    idConversation[1] = grow.Cells["IdCon"].Value.ToString();
                    idConversation[0] = "1";
                    //load_Messages();
                }
            }
            dgvConversation.Rows.Clear();
        }

        private void btnConversation_Click(object sender, EventArgs e)
        {
            show_Conversation();
        }

        private void show_Conversation()
        {
            lbTypeList.Text = "لیست مکالمات";
            dgvListUser.Visible = false;
            dgvListConversation.Visible = true;
            dgvListConversation.Dock = DockStyle.Fill;
            //load_Conversations();
        }

        private void dgvListConversation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListConversation.Enabled = false;
                if (dgvListConversation.Rows[e.RowIndex].Cells["TypeCon"].Value.ToString() == "1")
                {                
                    checkedItemListConversation("1", dgvListConversation.Rows[e.RowIndex].Cells["IdCon"].Value.ToString());
                    idConversation[1] = dgvListConversation.Rows[e.RowIndex].Cells["IdCon"].Value.ToString();
                    idConversation[0] = "1";
                    load_Messages();
                    newMessage newM = newMessage.findFromListConversation(dgvListConversation.Rows[e.RowIndex].Cells["IdCon"].Value.ToString());
                    if (newM != null)
                    {
                        Message.read_message(newM.table);
                        newMessage.clearFromListConversation(newM);
                    }
                    dgvListConversation.Rows[e.RowIndex].Cells["NameCon"].Value = dgvListConversation.Rows[e.RowIndex].Cells["ToolTipCon"].Value.ToString();
                    forwardMessage();
                    isActiveParUser(dgvListConversation.Rows[e.RowIndex].Cells["refUser"].Value.ToString());
                }
                else if(dgvListConversation.Rows[e.RowIndex].Cells["TypeCon"].Value.ToString() == "2")
                {
                    idConversation[1] = "0";
                    idConversation[0] = "2";
                    dgvConversation.Rows.Clear();
                    checkedItemListConversation("2", dgvListConversation.Rows[e.RowIndex].Cells["IdCon"].Value.ToString());
                }
                dgvListConversation.Enabled = true;

                lbNameParticipant.Text = dgvListConversation.Rows[e.RowIndex].Cells["NameCon"].Value.ToString();
                lbLastSeenParticipant.Text = loadLastSeenInConversations(dgvListConversation.Rows[e.RowIndex].Cells["refUser"].Value.ToString(), dgvListConversation.Rows[e.RowIndex].Index);
            }
            catch (Exception)
            {
                dgvListConversation.Enabled = true;
            }
        }


        private void dgvListConversation_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            loadLastSeenInConversations(dgvListConversation.Rows[e.RowIndex].Cells["refUser"].Value.ToString(), dgvListConversation.Rows[e.RowIndex].Index);
        }

        private string loadLastSeenInConversations(string iduser, int rowIndex)
        {
            if (DataBase.findMsgOnlineUser(iduser))
            {
                return dgvListConversation.Rows[rowIndex].Cells["NameCon"].ToolTipText = "آنلاین";
            }
            else
            {
                try
                {
                    DataBase.searchMsgUser("IdUser", iduser);
                    return dgvListConversation.Rows[rowIndex].Cells["NameCon"].ToolTipText = "آخرین بازدید: " + Time.convertMiladiToShamsi(Convert.ToDateTime(DataBase.dataTable.Rows[0]["LastSeen"].ToString()));
                }
                catch { return ""; }
            }
        }

        private void isActiveParUser(string refUserPar)
        {
            rtxtNewMessage.Enabled = true;
            tsSendMessage.Enabled = true;
            if (!DataBase.findActiveUser(refUserPar))
            {
                rtxtNewMessage.Enabled = false;
                tsSendMessage.Enabled = false;
            }
        }

        private void cbtnDelConversation_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "1")
                {
                    DialogResult result = MessageBox.Show("آیا مایل به حذف این مکالمه هستید؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Conversation.deleteConversation();
                        dgvConversation.Rows.Clear();
                        dgvListConversation.Rows.Remove(dgvListConversation.SelectedRows[0]);
                        //load_Conversations();
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void cbtnClearHistory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "1")
                {
                    DialogResult result = MessageBox.Show("آیا مایل به پاک کردن این تاریخچه هستید؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Conversation.clearHistory();
                        dgvConversation.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            { }
        }
        #endregion

        #region ... Detail Conversation

        private void dgvConversation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openFile();
        }

        private void cmsConversationText_Opening(object sender, CancelEventArgs e)
        {
            cmsConversation.Items["cbtnDownloadFile"].Visible = true;
            cmsConversation.Items["cbtnOpenFile"].Visible = true;
            if (dgvConversation.SelectedRows.Count != 1 || dgvConversation.SelectedRows[0].Cells["Type"].Value.ToString() != "2")
            {
                cmsConversation.Items["cbtnDownloadFile"].Visible = false;
                cmsConversation.Items["cbtnOpenFile"].Visible = false;
            }
        }

        private void dgvConversation_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvConversation_DragDrop(object sender, DragEventArgs e)
        {
            if (rtxtNewMessage.Enabled && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                send_Files(files);
            }
        }

        private void dgvConversation_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == 0)
            {
                load_OldesMessages();
            }
        }

        private void cmsListConversation_Opening(object sender, CancelEventArgs e)
        {
            //cmsListConversation.Items["cbtnDelConversation"].Visible = true;
            //cmsListConversation.Items["cbtnClearHistory"].Visible = true;
            //cmsListConversation.Visible = true;
            //if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() != "1")
            //{
            //    cmsListConversation.Items["cbtnDelConversation"].Visible = false;
            //    cmsListConversation.Items["cbtnClearHistory"].Visible = false;
            //    cmsListConversation.Visible = false;
            //}
        }
        #endregion

        #region ... Message

        public void load_Messages()
        {
            try
            {
                string namedate = "";
                dgvConversation.Rows.Clear();
                dgvConversation.Tag = 25;
                checkedItemListConversation("1", Main.idConversation[1]);
                DataBase.searchMsgMessage("RefConversation", Main.idConversation[1], dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), dgvConversation.Tag.ToString());
                DataTable table = DataBase.dataTable;

                //effectMessages(dgvConversation.RowCount - 1);
                foreach (DataRow drow in table.Rows)
                {
                    namedate = Time.convertMiladiToShamsi(Convert.ToDateTime(drow["CreateDate"]));
                    dgvConversation.Rows.Insert(0, drow["RefTypeMessage"].ToString(), drow["readMessage"].ToString(), drow["refUser"].ToString(), drow["IdMessage"].ToString(), imlTypeMessage.Images[1], imlReadMessage.Images[0], namedate, AesCryp.decode(drow["TextMessage"].ToString()), namedate);
                    effectMessages(0);
                }

                // for multi line in grid
                dgvConversation.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                selectRow(dgvConversation.Rows.Count - 1);
            }
            catch { }
        }

        public void load_OldesMessages()
        {
            string namedate = ""; int existsRow = dgvConversation.Rows.Count;
            dgvConversation.Tag = Convert.ToInt32(dgvConversation.Tag) + 25;
            checkedItemListConversation("1", Main.idConversation[1]);
            DataBase.searchMsgMessage("RefConversation", Main.idConversation[1], dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), dgvConversation.Tag.ToString());
            DataTable table = DataBase.dataTable;

            if (table.Rows.Count > existsRow)
            {
                for (int i = existsRow; i < table.Rows.Count; i++)
                {
                    DataRow drow = table.Rows[i];
                    namedate = Time.convertMiladiToShamsi(Convert.ToDateTime(drow["CreateDate"]));
                    dgvConversation.Rows.Insert(0, drow["RefTypeMessage"].ToString(), drow["readMessage"].ToString(), drow["refUser"].ToString(), drow["IdMessage"].ToString(), imlTypeMessage.Images[1], imlReadMessage.Images[0], namedate, AesCryp.decode(drow["TextMessage"].ToString()), namedate);
                    effectMessages(0);
                }
                selectRow(table.Rows.Count - existsRow);
            }
        }

        public void effectMessages(int rowNo)
        {
            try
            {
                DataGridViewRow grow = dgvConversation.Rows[rowNo];

                dgvConversation.Columns["TextDate"].DefaultCellStyle.ForeColor = dgvConversation.Columns["TextDatePar"].DefaultCellStyle.ForeColor = Color.Gray;
                dgvConversation.Columns["TextDate"].DefaultCellStyle.Font = dgvConversation.Columns["TextDatePar"].DefaultCellStyle.Font = new Font("Tahoma", 6);

                if (grow.Cells["Type"].Value.ToString() == "1" || grow.Cells["Type"].Value.ToString() == "3")
                {
                    if (grow.Cells["IdUserMes"].Value.ToString() == idUser)
                    {
                        //if (!DataBase.findMsgUnReadMessage(idConversation, dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), grow.Cells["Id"].Value.ToString()))
                        //{
                        //    grow.Cells["SeenMessage"].ToolTipText = "1";
                        //}
                        //else
                        //{
                        //    grow.Cells["SeenMessage"].Value = imlUnReadMessage.Images[0];
                        //}
                        if(grow.Cells["Seen"].Value.ToString() == "0")
                        {
                            grow.Cells["SeenMessage"].Value = imlUnReadMessage.Images[0];
                        }
                        grow.Cells["TextMessage"].Style.ForeColor = Color.OrangeRed;
                        grow.Cells["TextDatePar"].Value = "";
                    }
                    else
                    {
                        grow.Cells["SeenMessage"].Value = imlUnReadMessage.Images[0];
                        grow.Cells["TextMessage"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        grow.Cells["TextMessage"].Style.ForeColor = Color.ForestGreen;
                        grow.Cells["TextDate"].Value = "";
                    }
                    if (grow.Cells["Type"].Value.ToString() == "3")
                    {
                        grow.Cells["TypeMessage"].Value = imlTypeMessage.Images[3];
                        //grow.Cells["TextMessage"].Style.BackColor = Color.LightYellow;
                        DataBase.searchMsgRemMessage("refMessage", grow.Cells["Id"].Value.ToString());
                        if (DataBase.dataTable.Rows.Count == 1)
                        {
                            grow.Cells["TextMessage"].ToolTipText = AesCryp.decode(DataBase.dataTable.Rows[0]["ReminderText"].ToString()) + "\n" + Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime(DataBase.dataTable.Rows[0]["ReminderDate"]));
                        }
                    }
                }
                else if (grow.Cells["Type"].Value.ToString() == "2")
                {
                    grow.Cells["TypeMessage"].Value = imlTypeMessage.Images[2];
                    grow.Cells["TextMessage"].Style.ForeColor = Color.Blue;
                    grow.Cells["TextMessage"].Style.Font = new Font("Tahoma", 9, FontStyle.Underline);

                    if (grow.Cells["IdUserMes"].Value.ToString() == idUser)
                    {

                        //if (!DataBase.findMsgUnReadMessage(idConversation, dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), grow.Cells["Id"].Value.ToString()))
                        //{
                        //    grow.Cells["SeenMessage"].ToolTipText = "1";
                        //    if (DataBase.findMsgDownloadedFile(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), grow.Cells["Id"].Value.ToString()))
                        //    {
                        //        grow.Cells["TypeMessage"].Value = imlTypeMessage.Images[0];
                        //        //grow.Cells["TextMessage"].Style.ForeColor = Color.Black;
                        //    }
                        //    //else
                        //    //{
                        //    //    grow.Cells["TextMessage"].Style.ForeColor = Color.Blue;
                        //    //}
                        //}
                        //else
                        //{
                        //    grow.Cells["SeenMessage"].Value = imlUnReadMessage.Images[0];
                        //}
                        if(grow.Cells["Seen"].Value.ToString() == "0")
                        {
                            grow.Cells["SeenMessage"].Value = imlUnReadMessage.Images[0];
                        }
                        else
                        {
                            if (DataBase.findMsgDownloadedFile(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), grow.Cells["Id"].Value.ToString()))
                            {
                                grow.Cells["TypeMessage"].Value = imlTypeMessage.Images[0];
                            }
                        }
                        grow.Cells["TextDatePar"].Value = "";
                    }
                    else
                    {
                        grow.Cells["SeenMessage"].Value = imlUnReadMessage.Images[0];
                        grow.Cells["TextMessage"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        //grow.Cells["TextMessage"].Style.ForeColor = Color.Blue;
                        grow.Cells["TextDate"].Value = "";
                    }
                }
            }
            catch { }
        }

        public void load_newMessages()
        {
            int countUnRead = 0;
            string namedate = "";

            foreach (DataGridViewRow grow in dgvListConversation.Rows)
            {
                if (grow.Cells["TypeCon"].Value.ToString() == "1")
                {
                    countUnRead = DataBase.searchMsgUnReadMessage(grow.Cells["IdCon"].Value.ToString(), idUser);
                    DataTable table = new DataTable();
                    table = DataBase.dataTable;
                    if (countUnRead != 0)
                    {
                        if (grow.Cells["IdCon"].Value.ToString() != idConversation[1])
                        {
                            grow.Cells["NameCon"].Value = grow.Cells["ToolTipCon"].Value.ToString() + "(" + countUnRead + ")";

                            newMessage newM = newMessage.findFromListConversation(grow.Cells["IdCon"].Value.ToString());
                            if (newM != null && newM.table.Rows.Count < table.Rows.Count)
                            {
                                popupWindow();
                                show_Conversation();
                            }
                            else if (newM == null)
                            {
                                popupWindow();
                                show_Conversation();
                            }
                            newMessage.updateListConversation(new newMessage(grow.Cells["IdCon"].Value.ToString(), table));
                        }
                        else
                        {
                            //load_Messages();
                            foreach (DataRow drow in table.Rows)
                            {
                                namedate = Time.convertMiladiToShamsi(Convert.ToDateTime(drow["CreateDate"]));
                                dgvConversation.Rows.Add(drow["RefTypeMessage"].ToString(), "0", drow["refUser"].ToString(), drow["IdMessage"].ToString(), imlTypeMessage.Images[1], imlReadMessage.Images[0], namedate, AesCryp.decode(drow["TextMessage"].ToString()), namedate);
                                effectMessages(dgvConversation.RowCount - 1);
                                selectRow(dgvConversation.Rows.Count - 1);
                            }
                            Message.read_message(table);
                            popupWindow();
                            show_Conversation();
                        }
                    }
                }
            }
        }

        private void addDateToForwardTable(int rowIndex)
        {
            DataRow drow;
            forwardMes = new DataTable();

            foreach (DataGridViewColumn gcol in dgvConversation.Columns)
            {
                forwardMes.Columns.Add(gcol.Name);
            }
            if (rowIndex >= 0)
            {
                drow = forwardMes.NewRow();
                foreach (DataGridViewCell gcell in dgvConversation.Rows[rowIndex].Cells)
                {
                    drow[dgvConversation.Columns[gcell.ColumnIndex].Name] = gcell.Value;
                }
                forwardMes.Rows.Add(drow);
            }
        }

        private void forwardMessage()
        {
            if (forwardMes.Rows.Count > 0)
            {
                if (forwardMes.Rows[0]["Type"].ToString() == "1")
                {
                    rtxtNewMessage.Text = forwardMes.Rows[0]["TextMessage"].ToString();
                }
                else if (forwardMes.Rows[0]["Type"].ToString() == "2")
                {
                    DialogResult result = MessageBox.Show("آیا مایل به ارسال فایل هستید؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataBase.searchMsgFile("RefMessage", forwardMes.Rows[0]["Id"].ToString());
                        DataTable table = DataBase.dataTable;
                        if (table.Rows.Count > 0)
                        {
                            insertFile(AesCryp.decode(table.Rows[0]["TextMessage"].ToString()), (byte[])table.Rows[0]["FileSource"]);
                        }
                    }
                }
                else if (forwardMes.Rows[0]["Type"].ToString() == "3")
                {
                    DataBase.searchMsgRemMessage("RefMessage", forwardMes.Rows[0]["Id"].ToString());
                    DataTable table = DataBase.dataTable;
                    btnReminder_Click(null, null);
                    rtxtNewMessage.Text = forwardMes.Rows[0]["TextMessage"].ToString();
                    if (table.Rows.Count > 0)
                    {
                        txtReminderText.Text = AesCryp.decode(table.Rows[0]["ReminderText"].ToString());
                        dtpReminder.SetSelectedDate(Convert.ToDateTime(table.Rows[0]["ReminderDate"].ToString()));
                    }
                }
                addDateToForwardTable(-1);
            }
        }

        private void send_Message()
        {
            if (!tlpReminderMessage.Visible)
            {
                send_TextMessage();
            }
            else
            {
                send_ReminderMessage();
            }
        }

        private void checkSeenMessage()
        {
            try
            {
                int mesCount = dgvConversation.RowCount;
                for (int i = mesCount - 1; i >= 0; i--)
                {
                    if (dgvConversation.Rows[i].Cells["Seen"].Value.ToString() == "0" && dgvConversation.Rows[i].Cells["IdUserMes"].Value.ToString() == idUser && !DataBase.findMsgUnReadMessage(idConversation[1], dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), dgvConversation.Rows[i].Cells["Id"].Value.ToString()))
                    {
                        dgvConversation.Rows[i].Cells["SeenMessage"].Value = imlReadMessage.Images[0];
                        dgvConversation.Rows[i].Cells["Seen"].Value = "1";
                    }
                    else if (dgvConversation.Rows[i].Cells["Seen"].Value.ToString() == "1")
                    {
                        break;
                    }
                }
            }
            catch { }
        }

        private void deleteMessage()
        {
            DialogResult result = MessageBox.Show("آیا مایل به حذف این متن هستید؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow grow in dgvConversation.SelectedRows)
                {
                    DataBase.insertIntoMsgDelMessage(grow.Cells["Id"].Value.ToString(), DateTime.Now);
                    dgvConversation.Rows.Remove(grow);
                }
            }
            //load_Messages();
        }

        private void completeDeleteMessage()
        {
            string id = "";
            DialogResult result = MessageBox.Show("آیا مایل به حذف این پیام به صورت کامل هستید؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow grow in dgvConversation.SelectedRows)
                {
                    id = grow.Cells["Id"].Value.ToString();
                    if (!DataBase.findMsgMessage(id, Main.idUser))
                    {
                        continue;
                    }
                    if (grow.Cells["Type"].Value.ToString() == "1")
                    {
                        DataBase.DeleteFromMsgMessage(id);
                    }
                    else if (grow.Cells["Type"].Value.ToString() == "2")
                    {
                        DataBase.searchMsgFileWithoutFile("refMessage", id);
                        DataTable table = DataBase.dataTable;
                        if (table.Rows.Count == 1)
                        {
                            DataBase.DeleteFromMsgFile(table.Rows[0]["IdFile"].ToString(), id);
                        }
                    }
                    else if (grow.Cells["Type"].Value.ToString() == "3")
                    {
                        DataBase.searchMsgRemMessage("refMessage", id);
                        DataTable table = DataBase.dataTable;
                        if (table.Rows.Count == 1)
                        {
                            DataBase.DeleteFromMsgRemMessage(table.Rows[0]["IdRemMessage"].ToString(), id);
                        }
                    }
                    dgvConversation.Rows.Remove(grow);
                }
            }
            //load_Messages();
        }

        private void tiNewMessage_Tick(object sender, EventArgs e)
        {
            checkLogOnline();

            load_ListConversations();
            load_newMessages();

            checkSeenMessage();
            checkDownloadedFile();

            load_OnlineUserListConversation();
            load_OnlineUser();

            checkedItemListConversation("1", idConversation[1]);
        }

        private void cbtnDeleteText_Click(object sender, EventArgs e)
        {
            deleteMessage();
        }

        private void cbtnCompleteDeleteText_Click(object sender, EventArgs e)
        {
            completeDeleteMessage();
        }

        private void cbtnForwardMes_Click(object sender, EventArgs e)
        {
            if (dgvConversation.SelectedRows.Count > 0)
            {
                addDateToForwardTable(dgvConversation.SelectedRows[0].Index);
                MessageBox.Show("لطفا مکالمه مورد نظر را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region ... Text Message

        private void send_TextMessage()
        {
            if (checkSendMessage("1"))
            {
                int idMes = 0;
                string namedate = "";
                if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "1")
                {
                    Conversation.checkActiveConversation(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString());
                    idMes = DataBase.insertIntoMsgMessage(Main.idConversation[1], rtxtNewMessage.Text, DateTime.Now);
                    if (DataBase.findMsgMessage(idMes.ToString(), Main.idUser))
                    {
                        DataRow drow = DataBase.dataTable.Rows[0];
                        namedate = Time.convertMiladiToShamsi(Convert.ToDateTime(drow["CreateDate"]));
                        dgvConversation.Rows.Add("1", "0", drow["refUser"].ToString(), drow["IdMessage"].ToString(), imlTypeMessage.Images[1], imlReadMessage.Images[0], namedate, AesCryp.decode(drow["TextMessage"].ToString()), namedate);
                        effectMessages(dgvConversation.RowCount - 1);
                        selectRow(dgvConversation.Rows.Count - 1);
                    }
                    //load_Messages();
                }
                else if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "2")
                {
                    Message.sendGroupTextMessage(dgvListConversation.SelectedRows[0].Cells["IdCon"].Value.ToString(), rtxtNewMessage.Text);
                }
                clearRTXTNewMessage();
            }
        }

        private bool checkSendMessage(string typeMessage)
        {
            if (idConversation[1] == "" || idConversation[1] == null || rtxtNewMessage.Text.Trim() == "")
            {
                return false;
            }
            if (typeMessage == "3" && (DateTime.Compare(dtpReminder.GetSelectedDateInDateTime().Date, DateTime.Now.Date) < 0 || DateTime.Compare(dtpReminderFrom.GetSelectedDateInDateTime().Date, DateTime.Now.Date) < 0))
            {
                MessageBox.Show("تاریخ انتخاب شده قبل از تاریخ جاری است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (typeMessage == "3" && DateTime.Compare(dtpReminder.GetSelectedDateInDateTime().Date, dtpReminderFrom.GetSelectedDateInDateTime().Date) < 0)
            {
                MessageBox.Show("تاریخ اول بعد از تاریخ دوم است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (typeMessage == "3" && txtReminderText.Text.Trim() == "")
            {
                MessageBox.Show("عنوان یادآوری را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void rtxtNewMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                send_Message();
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            send_Message();
        }

        private void cbtnCopyText_Click(object sender, EventArgs e)
        {
            if (dgvConversation.SelectedRows.Count > 0)
            {
                Clipboard.SetText(dgvConversation.SelectedRows[0].Cells["TextMessage"].Value.ToString());
            }
        }
        #endregion

        #region ... Reminder Message

        private void send_ReminderMessage()
        {
            if (checkSendMessage("3"))
            {
                int idMes = 0;
                string namedate = "";
                if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "1")
                {
                    Conversation.checkActiveConversation(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString());

                    idMes = DataBase.insertIntoMsgRemMessage(idConversation[1], rtxtNewMessage.Text, DateTime.Now, txtReminderText.Text, getHourInterval(), dtpReminder.GetSelectedDateInDateTime(), dtpReminderFrom.GetSelectedDateInDateTime(), getUserInterval());
                    if (DataBase.findMsgMessage(idMes.ToString(), idUser))
                    {
                        DataRow drow = DataBase.dataTable.Rows[0];
                        namedate = Time.convertMiladiToShamsi(Convert.ToDateTime(drow["CreateDate"]));
                        dgvConversation.Rows.Add("3", "0", drow["refUser"].ToString(), drow["IdMessage"].ToString(), imlTypeMessage.Images[1], imlReadMessage.Images[0], namedate, AesCryp.decode(drow["TextMessage"].ToString()), namedate);
                        effectMessages(dgvConversation.RowCount - 1);
                        selectRow(dgvConversation.Rows.Count - 1);
                    }
                }
                else if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "2")
                {
                    Message.sendGroupReminder(dgvListConversation.SelectedRows[0].Cells["IdCon"].Value.ToString(), rtxtNewMessage.Text, txtReminderText.Text, getHourInterval(), dtpReminder.GetSelectedDateInDateTime(), dtpReminderFrom.GetSelectedDateInDateTime(), cbUserInterval.SelectedItem.ToString());
                }
                clearReminderItem();
                clearRTXTNewMessage();
            }
        }

        private int getHourInterval()
        {
            if (cbInterval.SelectedItem.ToString() == "ساعت")
            {
                return (int)nudHourInterval.Value;
            }
            else if (cbInterval.SelectedItem.ToString() == "روز")
            {
                return (int)nudHourInterval.Value * 24;
            }
            return 1;
        }

        private string getUserInterval()
        {
            if (cbUserInterval.SelectedItem.ToString() == "دریافت کننده")
            {
                return DataBase.insertIntoMsgRemUser(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString());
            }
            else if (cbUserInterval.SelectedItem.ToString() == "ارسال کننده")
            {
                return DataBase.insertIntoMsgRemUser(idUser);
            }
            else if (cbUserInterval.SelectedItem.ToString() == "هر دو")
            {
                return DataBase.insertIntoMsgRemUser(idUser) + DataBase.insertIntoMsgRemUser(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString());
            }
            return "";
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            tlpReminderMessage.Visible = !tlpReminderMessage.Visible;
        }

        private void btnShowReminder_Click(object sender, EventArgs e)
        {
            Reminder rem = new Reminder("");
            rem.ShowDialog();
        }

        private void tiReminder_Tick(object sender, EventArgs e)
        {
            Message.alarmReminder();
        }
        #endregion

        #region ... File

        private void send_Files(string[] paths)
        {
            if (idConversation[1] == "" || idConversation[1] == null)
            {
                MessageBox.Show("مکالمه مورد نظر را انتخاب کنید");
                return;
            }
            try
            {
                if (Message.sizeAllFiles(idUser) > limitSizeAllFile)
                {
                    MessageBox.Show("حجم فایل های شما بیش از 500 مگابایت می باشد");
                    return;
                }
                if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "1")
                {
                    Conversation.checkActiveConversation(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString());
                    FileStream stream;
                    BinaryReader reader;
                    foreach (string path in paths)
                    {
                        byte[] file;
                        stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                        if (stream.Length > limitSizeFile)
                        {
                            MessageBox.Show("حجم فایل نباید بیش از 5 مگابایت باشد");
                            continue;
                        }
                        reader = new BinaryReader(stream);
                        file = reader.ReadBytes((int)stream.Length);
                        insertFile(Path.GetFileName(path), file);
                    }
                }
                else if (dgvListConversation.SelectedRows[0].Cells["TypeCon"].Value.ToString() == "2")
                {
                    Message.sendGroupFile(dgvListConversation.SelectedRows[0].Cells["IdCon"].Value.ToString(), paths);
                }
            }
            catch (Exception me)
            {
                //MessageBox.Show(me.Message);
                MessageBox.Show("مشکل در ارسال فایل مورد نظر");
            }
        }

        private void insertFile(string fileName, byte[] file)
        {
            string namedate = "";
            int idFi = DataBase.insertIntoMsgFile(idConversation[1], fileName, file, DateTime.Now);
            if (DataBase.findMsgFile(idFi.ToString(), idUser))
            {
                DataRow drow = DataBase.dataTable.Rows[0];
                namedate = Time.convertMiladiToShamsi(Convert.ToDateTime(drow["CreateDate"]));
                dgvConversation.Rows.Add("2", "0", drow["refUser"].ToString(), drow["IdMessage"].ToString(), imlTypeMessage.Images[1], imlReadMessage.Images[0], namedate, AesCryp.decode(drow["TextMessage"].ToString()), namedate);
                effectMessages(dgvConversation.RowCount - 1);
                selectRow(dgvConversation.Rows.Count - 1);
            }
        }

        private void checkDownloadedFile()
        {
            try
            {
                foreach (DataGridViewRow grow in dgvConversation.Rows)
                {
                    if (grow.Cells["Type"].Value.ToString() == "2")
                    {

                        if (DataBase.findMsgDownloadedFile(dgvListConversation.SelectedRows[0].Cells["refUser"].Value.ToString(), grow.Cells["Id"].Value.ToString()))
                        {
                            grow.Cells["TypeMessage"].Value = imlTypeMessage.Images[0];
                            //grow.Cells["TextMessage"].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
            catch { }
        }

        private void openFile()
        {
            try
            {
                string fileName = dgvConversation.SelectedRows[0].Cells["TextMessage"].Value.ToString();
                if (Message.downloadFile(Path.GetTempPath() + @"\" + fileName, dgvConversation.SelectedRows[0].Cells["Id"].Value.ToString(), dgvConversation.SelectedRows[0].Cells["Type"].Value.ToString()))
                {
                    Process.Start(Path.GetTempPath() + @"\" + fileName);
                }
            }
            catch (Exception me)
            {
                //MessageBox.Show(me.Message);
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            ofdSelectFile.Title = "Open File";
            if (ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                send_Files(ofdSelectFile.FileNames);
                ofdSelectFile.Dispose();
            }
        }

        private void cbtnDownloadFile_Click(object sender, EventArgs e)
        {
            sfdSaveFile.FileName = dgvConversation.SelectedRows[0].Cells["TextMessage"].Value.ToString();// DataBase.dataTable.Rows[0]["NameFile"].ToString();
            sfdSaveFile.ShowDialog();
            Message.downloadFile(sfdSaveFile.FileName, dgvConversation.SelectedRows[0].Cells["Id"].Value.ToString(), dgvConversation.SelectedRows[0].Cells["Type"].Value.ToString());
        }

        private void cbtnOpenFile_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void btnFileManagement_Click(object sender, EventArgs e)
        {
            FileManagement fileM = new FileManagement();
            fileM.ShowDialog();
        }
        #endregion

        #region ... Operation

        private void Buzzer()
        {
            //Console.Beep();
            //SoundPlayer player = new SoundPlayer(@"Sound\1.wav");
            //player.Play();
            //if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            //{
            //    System.Deployment.Application.ApplicationDeployment cd =
            //    System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
            //    MessageBox.Show(cd.CurrentVersion.ToString());
            //}
        }

        public void selectRow(int rowNo)
        {
            //dgvConversation.Rows.Count - 1
            if (dgvConversation.Rows.Count > 0)
            {
                dgvConversation.Rows[rowNo].Selected = true;
                dgvConversation.CurrentCell = dgvConversation.Rows[rowNo].Cells["TextMessage"];
            }
        }

        private void DGVSelectionStyle()
        {
            dgvConversation.DefaultCellStyle.SelectionBackColor = dgvConversation.DefaultCellStyle.BackColor;
            dgvConversation.DefaultCellStyle.SelectionForeColor = dgvConversation.DefaultCellStyle.ForeColor;

            dgvListConversation.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvListConversation.DefaultCellStyle.SelectionForeColor = dgvListConversation.DefaultCellStyle.ForeColor;

            dgvListUser.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvListUser.DefaultCellStyle.SelectionForeColor = dgvListUser.DefaultCellStyle.ForeColor;
        }
        private void popupWindow()
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            TopMost = true;
            TopMost = false;
        }

        public void clearRTXTNewMessage()
        {
            rtxtNewMessage.Clear();
            rtxtNewMessage.Multiline = false;
            rtxtNewMessage.Multiline = true;
        }
        private void clearReminderItem()
        {
            txtReminderText.Clear();
            cbInterval.SelectedIndex = 1;
            cbUserInterval.SelectedIndex = 0;
            dtpReminder.SetSelectedDate(DateTime.Now);
            dtpReminderFrom.SetSelectedDate(DateTime.Now);
            nudHourInterval.Value = 0;
            tlpReminderMessage.Visible = false;
            btnReminder.Checked = false;
        }

        public void checkedItemListConversation(string type, string id)
        {
            foreach (DataGridViewRow grow in dgvListConversation.Rows)
            {
                //grow.Selected = false;
                grow.DefaultCellStyle.BackColor = Color.White;
                if (grow.Cells["TypeCon"].Value.ToString() == type && grow.Cells["IdCon"].Value.ToString() == id)
                {
                    //grow.Selected = true;
                    grow.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

        private bool isApplicationOpen()
        {
            int count = 0;
            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == "Messenger")
                {
                    count++;
                }
                //Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            if (count > 1)
            {
                return true;
            }
            return false;
        }

        private void addToStartup()
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("Messenger", @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\KCIG\KCIGMessenger.appref-ms");
            }
            catch (Exception)
            { }
        }

        private void Exit()
        {
            isClose = true;
            Close();
        }

        #endregion

        #region ... Help About     

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Time.convertShamsiToMiladi("1397/02/31 08:45").ToString());
            //MessageBox.Show(DateTime.Now.ToString());
            About about = new About();
            about.Show();
            //dgvConversation[7, 2] = new DataGridViewImageCell();
            //dgvConversation[7, 2].Value = imlTypeMessage.Images[0];
        }
        #endregion

    }
}
