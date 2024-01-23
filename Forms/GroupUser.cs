using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Messenger
{
    public partial class GroupUser : Form
    {
        public GroupUser()
        {
            InitializeComponent();
        }

        #region ... Load

        private void GroupUser_Load(object sender, EventArgs e)
        {
            load_Users();
            load_Groups();
        }

        private void load_Users()
        {
            lvUsers.Clear();
            DataBase.searchMsgUser("All", "");
            foreach (DataRow drow in DataBase.dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = drow["FirstName"].ToString() + " " + drow["LastName"].ToString();
                item.Name = drow["IdUser"].ToString();

                if (drow["IdUser"].ToString() == Main.idUser)
                {
                    continue;
                }
                lvUsers.Items.Add(item);
            }
        }

        private void load_Groups()
        {
            lvGroup.Clear();
            DataBase.searchMsgGroup("All", "");
            foreach (DataRow drow in DataBase.dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = drow["GroupName"].ToString();
                item.Name = drow["IdGroup"].ToString();
                lvGroup.Items.Add(item);
            }
        }

        private void load_UserGroup(string idGroup)
        {
            lvUserGroup.Clear();
            DataBase.searchMsgUserGroup(idGroup);
            foreach (DataRow drow in DataBase.dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = drow["FirstName"].ToString() + " " + drow["LastName"].ToString();
                item.Name = drow["refUser"].ToString();
                lvUserGroup.Items.Add(item);
            }
        }

        private int load_OldConversation(string idUserPar)
        {
            DataBase.searchOldConversation(Main.idUser, idUserPar);
            if (DataBase.dataTable.Rows.Count == 1)
            {
                return Convert.ToInt32(DataBase.dataTable.Rows[0]["IdConversation"].ToString());
            }
            return -1;
        }
        #endregion

        #region ... Operation

        private void send_Message()
        {
            try
            {
                //int idCon = 0;
                //foreach (ListViewItem item in lvUserGroup.CheckedItems)
                //{
                //    idCon = startNewChat(item.Name);
                //    DataBase.insertIntoMsgMessage(idCon.ToString(), rtxtNewMessage.Text, DateTime.Now);
                //}

                //rtxtNewMessage.Clear();
                //rtxtNewMessage.Multiline = false;
                //rtxtNewMessage.Multiline = true;
                //MessageBox.Show("پیام مورد نظر ارسال شد");
            }
            catch (Exception)
            {
                MessageBox.Show("مشکل در ارسال پیام مورد نظر");
            }
        }

        //private void send_File(string fileName, byte[] file)
        //{
        //    int idCon = 0;
        //    foreach (ListViewItem item in lvUserGroup.CheckedItems)
        //    {
        //        idCon = startNewChat(item.Name);
        //        DataBase.insertIntoMsgFile(idCon.ToString(), fileName, file, DateTime.Now);
        //    }
        //}

        private int new_Conversation(string refUser, string name)
        {
            return DataBase.insertIntoMsgConversation(name, DateTime.Now, refUser, DateTime.Now);
        }

        public int startNewChat(string idUserPar)
        {
            int temp = load_OldConversation(idUserPar);
            if (temp != -1)
            {
                return temp;
            }
            return new_Conversation(idUserPar, "");
        }
        #endregion

        #region ... Event

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            lvGroup.Items.Add("گروه جدید");
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("آیا مایل به حذف این گروه کاربران هستید؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes && lvGroup.CheckedItems.Count == 1 && lvGroup.CheckedItems[0].Name != "")
                {
                    DataBase.DeleteFromMsgGroup(lvGroup.CheckedItems[0].Name);
                    load_Groups();
                }
            }
            catch(Exception)
            {

            }
        }

        private void btnAddToGroup_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem gitem in lvGroup.CheckedItems)
            {
                if (gitem.Name != "")
                {
                    foreach (ListViewItem uitem in lvUsers.CheckedItems)
                    {
                        if (!DataBase.findMsgUserGroup(gitem.Name, uitem.Name))
                        {
                            DataBase.insertIntoMsgUserGroup(gitem.Name, uitem.Name, DateTime.Now);
                            
                        }
                    }
                }
                load_UserGroup(gitem.Name);
            }        
        }

        private void btnDelFromGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvGroup.SelectedItems[0].Name != "")
                {
                    foreach (ListViewItem uitem in lvUserGroup.CheckedItems)
                    {
                        DataBase.DeleteFromMsguserGroup(lvGroup.SelectedItems[0].Name, uitem.Name);
                    }
                }
                load_UserGroup(lvGroup.SelectedItems[0].Name);
            }
            catch(Exception)
            { }
        }

        private void lvGroup_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if(e.Label==null)
            {
                return;
            }
            if(lvGroup.Items[e.Item].Name=="")
            {
                DataBase.insertIntoMsgGroup(e.Label, "");
            }
            else
            {
                DataBase.updateMsgGroup(lvGroup.Items[e.Item].Name, e.Label, "");
            }
            load_Groups();
        }

        private void lvGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroup.SelectedItems.Count == 1 && lvGroup.SelectedItems[0].Name != "")
            {
                load_UserGroup(lvGroup.SelectedItems[0].Name);
            }
        }

        //private void rtxtNewMessage_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyValue == 13)
        //    {
        //        send_Message();
        //    }
        //}

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            load_Users();
            foreach (ListViewItem item in lvUsers.Items)
            {
                if (!item.Text.Contains(txtSearchUser.Text))
                {
                    item.Remove();
                }
            }
        }

        //private void btnSendMessage_Click(object sender, EventArgs e)
        //{
        //    send_Message();
        //}

        //private void btnBrowseFile_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (lvUserGroup.CheckedItems.Count == 0)
        //        {
        //            return;
        //        }
        //        ofdSelectFile.Title = "Open File";
        //        if (ofdSelectFile.ShowDialog() == DialogResult.OK)
        //        {
        //            foreach (string path in ofdSelectFile.FileNames)
        //            {
        //                byte[] file;
        //                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
        //                {
        //                    using (var reader = new BinaryReader(stream))
        //                    {
        //                        file = reader.ReadBytes((int)stream.Length);
        //                    }
        //                }
        //                send_File(Path.GetFileName(path), file);
        //                //DataBase.insertIntoMsgFile(Path.GetFileName(path), file, DateTime.Now);
        //            }
        //            ofdSelectFile.Dispose();
        //            MessageBox.Show("فایل با موفقیت ارسال شد");
        //        }
        //    }
        //    catch(Exception)
        //    {
        //        MessageBox.Show("مشکل در ارسال فایل مورد نظر");
        //    }
        //}
        #endregion
    }
}
