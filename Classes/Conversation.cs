using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Messenger
{
    class Conversation
    {
        static public void deleteConversation()
        {
            clearHistory();
            DataBase.insertIntoMsgDelConversation(DateTime.Now);
            Main.idConversation[1] = "";
        }

        static public void clearHistory()
        {
            DataBase.searchMsgMessage("RefConversation", Main.idConversation[1]);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                DataBase.insertIntoMsgDelMessage(drow["IdMessage"].ToString(), DateTime.Now);
            }
        }

        static public void checkActiveConversation(string refUser)
        {
            string idDel = DataBase.findMsgDelConversation(Main.idConversation[1], refUser);
            if (idDel != "")
            {
                DataBase.DeleteFromMsgDelConversation(idDel);
            }
        }

        static public void startNewConversation(string idUserPar)
        {
            //if (load_OldConversation(idUserPar) != 0)
            //{
            //    return;
            //}
            DataBase.searchAllConversation(Main.idUser, idUserPar);
            if (DataBase.dataTable.Rows.Count == 1)
            {
                string idCon = DataBase.dataTable.Rows[0]["IdConversation"].ToString();
                string idDel = DataBase.findMsgDelConversation(idCon, Main.idUser);
                if (idDel != "")
                {
                    DataBase.DeleteFromMsgDelConversation(idDel);
                }
                return;
            }
            else if (DataBase.dataTable.Rows.Count == 0)
            {
                DataBase.insertIntoMsgConversation("", DateTime.Now, idUserPar, DateTime.Now);
                return;
            }
            else
            {
                MessageBox.Show("مشکل در ایجاد مکالمه");
            }
        }
        //static private int load_OldConversation(string idUserPar)
        //{
        //    DataBase.searchOldConversation(Main.idUser, idUserPar);
        //    if (DataBase.dataTable.Rows.Count == 1)
        //    {
        //        return Convert.ToInt32(DataBase.dataTable.Rows[0]["IdConversation"].ToString());
        //    }
        //    else if (DataBase.dataTable.Rows.Count == 0)
        //    {
        //        return 0;
        //    }
        //    MessageBox.Show("مشکل در ایجاد مکالمه");
        //    return -1;
        //}
    }
}
