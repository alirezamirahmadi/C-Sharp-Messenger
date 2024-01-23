using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Messenger
{
    class newMessage
    {
        public string idCon;
        public DataTable table;

        public newMessage(string _idCon, DataTable _table)
        {
            idCon = _idCon;
            table = _table;
        }

        static public void updateListConversation(newMessage temp)
        {
            bool isOld = false;
            foreach (newMessage me in Main.listOfConversation)
            {
                if (temp.idCon == me.idCon)
                {
                    isOld = true;
                    me.table = new DataTable();
                    me.table = temp.table;
                }
            }
            if (!isOld)
            {
                Main.listOfConversation.Add(temp);
            }
        }

        static public newMessage findFromListConversation(string id)
        {
            foreach (newMessage me in Main.listOfConversation)
            {
                if (id == me.idCon)
                {
                    return me;
                }
            }
            return null;
        }

        static public void clearFromListConversation(newMessage temp)
        {
            Main.listOfConversation.Remove(temp);
            //foreach (newMessage me in Main.listOfConversation)
            //{
            //    if (temp.idCon == me.idCon)
            //    {
            //        me.table = new DataTable();
            //    }
            //}
        }
        static public void clearFromListConversation(string id)
        {
            foreach (newMessage me in Main.listOfConversation)
            {
                if (id == me.idCon)
                {
                    Main.listOfConversation.Remove(me);
                }
            }
        }
    }
}
