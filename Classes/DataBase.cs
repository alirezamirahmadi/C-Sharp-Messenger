using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Messenger
{
    class DataBase
    {
        //static private string connectionstring;
        //private const string connectionstring = "server=localhost; database=Kerman_Cement;integrated security=SSPI";

        //private const string connectionstring = "server=192.168.70.101; database=Kerman_Cement_t;user Id=sa; password=ADMIN@kcc";

        private const string connectionstring = "server=192.168.5.115; database=Kerman_Cement; user Id=sa; password=srvDBS@kcc";

        static private SqlConnection connection;
        static private SqlCommand objCommand;
        static private SqlDataAdapter dataAdapter;
        static public DataTable dataTable = new DataTable();
        static public DataSet dataSet = new DataSet();

        static public bool Check = false;
        static public string message;

        static public void Connect()
        {
            try
            {
                connection = new SqlConnection(connectionstring);
            }
            catch { }
        }

        #region ... Change & Search 

        static private int Change(string query)
        {
            int rowEffect = 0;
            objCommand = new SqlCommand();
            try
            {
                connection.Close();
                connection.Open();
                objCommand.Connection = connection;
                objCommand.CommandText = query;

                rowEffect = objCommand.ExecuteNonQuery();
                Check = true;
                connection.Close();
            }
            catch (SqlException sqlExceptionError)
            {
                //MessageBox.Show(sqlExceptionError.Message);
                Check = false;
                connection.Close();
            }
            return rowEffect;
        }

        static private void ChangeWithItem(string query, int[] maxId, DateTime[] date, byte[] file)
        {
            int count = 0;
            Check = false;
            objCommand = new SqlCommand();
            try
            {
                connection.Close();
                connection.Open();
                objCommand.Connection = connection;
                objCommand.CommandText = query;
                if (maxId != null)
                {
                    foreach (int id in maxId)
                    {
                        count++;
                        objCommand.Parameters.Add("@maxId" + count, SqlDbType.Int).Value = id;
                        //objCommand.Parameters["@maxId" + count].Value = id;
                    }
                }
                count = 0;
                if (date != null)
                {
                    foreach (DateTime dTime in date)
                    {
                        count++;
                        objCommand.Parameters.Add("@date" + count, SqlDbType.DateTime).Value = dTime;
                        //objCommand.Parameters["@date" + count].Value = dTime;
                    }
                }

                if (file != null)
                {
                    objCommand.Parameters.Add("@file1", SqlDbType.VarBinary, file.Length).Value = file;
                }

                message = objCommand.ExecuteNonQuery().ToString();
                Check = true;
                connection.Close();
            }
            catch (SqlException sqlExceptionError)
            {
                message = sqlExceptionError.Message;
                Check = false;
                connection.Close();
                //MessageBox.Show(message);
            }
        }

        static private int Search(string Text)
        {
            try
            {
                dataTable = new DataTable();
                objCommand = connection.CreateCommand();
                objCommand.CommandText = Text;

                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = objCommand;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataTable = dataSet.Tables[0];
                return dataTable.Rows.Count;
            }
            catch (Exception Error)
            {
                //MessageBox.Show(Error.Message);
                return 0;
            }
        }


        static private void SearchWithDate(string text, DateTime fromDate, DateTime toDate)
        {
            try
            {
                dataTable = new DataTable();
                objCommand = connection.CreateCommand();
                objCommand.CommandText = text;
                objCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
                objCommand.Parameters["@fromdate"].Value = fromDate;

                objCommand.Parameters.Add("@todate", SqlDbType.DateTime);
                objCommand.Parameters["@todate"].Value = toDate;


                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = objCommand;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataTable = dataSet.Tables[0];
            }
            catch (Exception Error)
            {
                //message = Error.Message;
            }
        }
        static private void SearchWithDate(string text, DateTime date)
        {
            try
            {
                dataTable = new DataTable();
                objCommand = connection.CreateCommand();
                objCommand.CommandText = text;
                objCommand.Parameters.Add("@date", SqlDbType.DateTime);
                objCommand.Parameters["@date"].Value = date;

                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = objCommand;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataTable = dataSet.Tables[0];
            }
            catch (Exception Error)
            {
                //message = Error.Message;
            }
        }
        #endregion

        #region ... Change Query 

        static public int Insert(string tableName, string[] fieldValues)
        {
            int fieldCount = fieldValues.Length;
            string insertText = " insert into " + tableName + " values ('" + fieldValues[0] + "'";
            for (int i = 1; i < fieldCount; i++)
            {
                insertText += ", '" + fieldValues[i] + "'";
            }
            insertText += ")";
            return Change(insertText);
        }

        static public int Update(string tableName, string[] fields, string[] condition)
        {
            int fieldCount = fields.Length;
            int conditionCount = condition.Length;
            string updatetText = " update " + tableName + " set " + fields[0] + "='" + fields[1] + "' ";
            for (int i = 2; i < fieldCount; i += 2)
            {
                updatetText += ", " + fields[i] + "='" + fields[i + 1] + "'";
            }
            updatetText += " where " + condition[0] + "='" + condition[1] + "'";
            for (int i = 2; i < conditionCount; i += 2)
            {
                updatetText += " and " + condition[i] + "='" + condition[i + 1] + "'";
            }
            return Change(updatetText);
        }

        static public int Delete(string tableName, string[] condition)
        {
            int conditionCount = condition.Length;
            string deleteText = " delete from " + tableName + " where " + condition[0] + "='" + condition[1] + "'";

            for (int i = 2; i < conditionCount; i += 2)
            {
                deleteText += " and " + condition[i] + "='" + condition[i + 1] + "'";
            }
            return Change(deleteText);
        }

        static public void Search(string tableName, string field, string text)
        {
            string searchText = "select * from " + tableName + " where " + field + "='" + text + "'";
            if (field == "")
            {
                searchText = "select * from " + tableName;
            }
            Search(searchText);
        }

        static private int maxId(string tableName, string fieldName)
        {
            try
            {
                string text = "select max(" + fieldName + ") from " + tableName;
                Search(text);
                DataRow row = dataTable.Rows[0];
                text = row[0].ToString();
                return (Convert.ToInt32(text) + 1);
            }
            catch (Exception)
            {
                return 1;
            }
        }
        #endregion

        #region ... User 

        static public void updateMsgUser(DateTime LastSeen)
        {
            string text = " update Msg.MsgUser set Version = '" + Application.ProductVersion + "', LastSeen = @date1 where IdUser = " + Main.idUser;
            ChangeWithItem(text, null, new[] { LastSeen }, null);
        }

        static public bool findMsgUser(string username)
        {
            string textSearch = "select * from Msg.MsgUser where UserName ='" + username + "'";
            Search(textSearch);
            if (dataTable.Rows.Count == 1)
            {
                
                Main.idUser = dataTable.Rows[0][0].ToString();
                return true;
            }
            return false;
        }

        static public bool findActiveUser(string IdUser)
        {
            string textSearch = "select * from Msg.MsgUser where IdUser ='" + IdUser + "' and Active = 'True'";
            Search(textSearch);
            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        static public void searchMsgUser(string field, string text)
        {
            string textSearch = "select * from Msg.MsgUser u, Msg.MsgProfile p where u.IdUser = p.RefUser and Active = 'True'";
            if (field != "All")
            {
                textSearch += " and " + field + " = '" + text + "' ";
            }
            textSearch += " order by p.LastName asc ";
            Search(textSearch);
        }
        #endregion

        #region ... Profile

        static public string insertIntoCrtCalibrationItm(int IdCalibrationItm, double Range, string ItemValues, double Uncertainty)
        {
            return " insert into Crt.CrtCalibrationItm values ( " + IdCalibrationItm + ", @maxId," + Range + ",'" + ItemValues + "'," + Uncertainty + " ) ";
        }

        static public string updateCrtCalibrationItm(int IdCalibrationItm, double Range, string ItemValues, double Uncertainty)
        {
            return " update Crt.CrtCalibrationItm set Range = " + Range + ", ItemValues = '" + ItemValues + "', Uncertainty = " + Uncertainty + " where IdCalibrationItm = " + IdCalibrationItm;
        }

        static public void searchMsgProfile(string field, string text)
        {
            string textSearch = "select * from Msg.MsgProfile where " + field + " = '" + text + "'";
            Search(textSearch);
        }

        static public void searchMsgProfile(string FLName)
        {
            string textSearch = "select * from Msg.MsgProfile where FirstName like '%" + FLName + "%' or LastName like '%" + FLName + "%'";
            Search(textSearch);
        }
        #endregion

        #region ... Conversation

        static public int insertIntoMsgConversation(string title, DateTime CreateDateCon, string refUser, DateTime CreateDatePar)
        {
            int maxConversation = maxId("Msg.MsgConversation", "IdConversation");
            int maxParticipant = maxId("Msg.MsgParticipant", "IdParticipant");
            string text = "begin tran "
                + " insert into Msg.MsgConversation values (@maxId1," + Main.idUser + ",'" + title + "', @date1) "
                + " insert into Msg.MsgParticipant values (@maxId2, @maxId1, " + refUser + ", @date2)"
                + " IF(@@error <> 0) BEGIN ROLLBACK TRAN RETURN END COMMIT TRAN ";
            ChangeWithItem(text, new[] { maxConversation, maxParticipant}, new[] { CreateDateCon, CreateDatePar}, null);
            return maxConversation;
        }

        static public void searchMsgConversation(string idUser)
        {
            string textSearch = "select c.IdConversation, c.Title, c.CreateDate, pf.refUser, pf.FirstName, pf.LastName from Msg.MsgConversation c, Msg.MsgParticipant p, Msg.MsgProfile pf where p.RefUser = pf.RefUser and c.IdConversation = p.RefConversation and c.IdConversation not in (select dc.RefConversation from Msg.MsgDelConversation dc where dc.refUser = c.refUser) and c.refUser = " + idUser + " "
                + " union select c.IdConversation, c.Title, c.CreateDate, pf.refUser, pf.FirstName, pf.LastName from Msg.MsgConversation c, Msg.MsgParticipant p, Msg.MsgProfile pf where c.RefUser = pf.RefUser and c.IdConversation = p.RefConversation and c.IdConversation not in (select dc.RefConversation from Msg.MsgDelConversation dc where dc.refUser = p.refUser) and p.refUser = " + idUser + " order by c.CreateDate desc ";
            Search(textSearch);
            //message = textSearch;
        }

        static public void searchOldConversation(string idUserCon, string idUserPar)
        {
            string textSearch = "select * from Msg.MsgConversation c, Msg.MsgParticipant p where c.IdConversation = p.RefConversation and c.IdConversation not in (select dc.RefConversation from Msg.MsgDelConversation dc where dc.refUser=c.refUser) and c.refUser = " + idUserCon + " and p.refUser = " + idUserPar + " "
                + " union select * from Msg.MsgConversation c, Msg.MsgParticipant p where c.IdConversation = p.RefConversation and c.IdConversation not in (select dc.RefConversation from Msg.MsgDelConversation dc where dc.refUser=p.refUser) and c.refUser = " + idUserPar + " and p.refUser = " + idUserCon;
            Search(textSearch);
            //message = textSearch;
        }

        static public void searchAllConversation(string idUserCon, string idUserPar)
        {
            string textSearch = "select * from Msg.MsgConversation c, Msg.MsgParticipant p where c.IdConversation = p.RefConversation and c.refUser = " + idUserCon + " and p.refUser = " + idUserPar + " "
                + " union select * from Msg.MsgConversation c, Msg.MsgParticipant p where c.IdConversation = p.RefConversation and c.refUser = " + idUserPar + " and p.refUser = " + idUserCon;
            Search(textSearch);
            //message = textSearch;
        }
        #endregion

        #region ... Delete Conversation

        static public void insertIntoMsgDelConversation(DateTime DeleteDate)
        {
            int maxDelConversation = maxId("Msg.MsgDelConversation", "IdDelConversation");
            string text = " insert into Msg.MsgDelConversation values (@maxId1," + Main.idConversation[1] + "," + Main.idUser + ", @date1)";
            //ChangeWithMaxIdAndDate(text, maxDelConversation, DeleteDate);
            ChangeWithItem(text, new[] { maxDelConversation }, new[] { DeleteDate }, null);
        }

        static public int DeleteFromMsgDelConversation(string IdDelConversation)
        {
            string text = "delete from Msg.MsgDelConversation where IdDelConversation = " + IdDelConversation;
            return Change(text);
        }

        static public string findMsgDelConversation(string IdConversation, string IdUser)
        {
            string textSearch = "select * from Msg.MsgDelConversation dm where dm.RefConversation = '" + IdConversation + "' and dm.RefUser = '" + IdUser + "' ";
            Search(textSearch);
            if (dataTable.Rows.Count == 1)
            {
                return dataTable.Rows[0]["IdDelConversation"].ToString();
            }
            return "";
        }
        #endregion

        #region ... Message

        //static public void codeMessage()
        //{
        //    string textSearch = "select * from Msg.MsgMessage ";
        //    Search(textSearch);
        //    foreach(DataRow drow in dataTable.Rows)
        //    {
        //        textSearch = "update Msg.MsgMessage set TextMessage = '" + AesCryp.code(drow["TextMessage"].ToString()) + "' where IdMessage = " + drow["IdMessage"];
        //        Change(textSearch);
        //    }
        //}

        //static public void codeRemMessage()
        //{
        //    string textSearch = "select * from Msg.MsgRemMessage ";
        //    Search(textSearch);
        //    foreach (DataRow drow in dataTable.Rows)
        //    {
        //        textSearch = "update Msg.MsgRemMessage set ReminderText = '" + AesCryp.code(drow["ReminderText"].ToString()) + "' where IdRemMessage = " + drow["IdRemMessage"];
        //        Change(textSearch);
        //    }
        //}

        static public int insertIntoMsgMessage(string idConversation, string TextMessage, DateTime CreateDate)
        {
            int maxMessage = maxId("Msg.MsgMessage", "IdMessage");
            string text = " insert into Msg.MsgMessage values (@maxId1, 1," + idConversation + "," + Main.idUser + ", '" + AesCryp.code(TextMessage) + "', @date1)";
            ChangeWithItem(text, new[] { maxMessage }, new[] { CreateDate }, null);
            return maxMessage;
        }

        static public int DeleteFromMsgMessage(string IdMessage)
        {
            //string textSearch = " delete from Msg.MsgMessage where " + field + "='" + text + "'";
            string text = "begin tran "
                + " delete from Msg.MsgReadMessage where RefMessage = " + IdMessage
                + " delete from Msg.MsgReply where RefMessage = " + IdMessage
                + " delete from Msg.MsgDelMessage where RefMessage = " + IdMessage
                + " delete from Msg.MsgMessage where IdMessage = " + IdMessage;
            text += " IF(@@error <> 0) BEGIN ROLLBACK TRAN RETURN END COMMIT TRAN ";
            return Change(text);
        }

        static public int searchMsgMessage(string field, string text, string refUser, string rowCount)
        {
            string textSearch = "";
            textSearch += " "
                + " select top " + rowCount + " * from ("
                + " select 0 readMessage, m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser=p.RefUser and m.IdMessage not in (select dm.RefMessage from Msg.MsgDelMessage dm where dm.refUser= " + Main.idUser + ") and m.RefUser <> " + Main.idUser + " and " + field + " = '" + text + "' "
                + " union select 1 readMessage, m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser=p.RefUser and m.IdMessage not in (select dm.RefMessage from Msg.MsgDelMessage dm where dm.refUser= " + Main.idUser + ") and m.IdMessage in (select rm.RefMessage from Msg.MsgReadMessage rm where rm.RefUser = " + refUser + ") and m.RefUser = " + Main.idUser + " and " + field + " = '" + text + "' "
                + " union select 0 readMessage, m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser=p.RefUser and m.IdMessage not in (select dm.RefMessage from Msg.MsgDelMessage dm where dm.refUser= " + Main.idUser + ") and m.IdMessage not in (select rm.RefMessage from Msg.MsgReadMessage rm where rm.RefUser = " + refUser + ") and m.RefUser = " + Main.idUser + " and " + field + " = '" + text + "' "
                + " ) temp "
                + " order by CreateDate desc";
            return Search(textSearch); // 0=unReadMessage 1=readMessage
        }

        static public int searchMsgMessage(string field, string text)
        {
            string textSearch = "select m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser=p.RefUser and m.IdMessage not in (select dm.RefMessage from Msg.MsgDelMessage dm where dm.refUser= " + Main.idUser + ") and " + field + " = '" + text + "' order by CreateDate asc";
            return Search(textSearch);
        }

        //static public int searchMsgMessage(string field, string text)
        //{
        //    string textSearch = "select m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser=p.RefUser and m.IdMessage not in (select dm.RefMessage from Msg.MsgDelMessage dm where dm.refUser= " + Main.idUser + ") and " + field + " = '" + text + "' order by CreateDate asc";
        //    return Search(textSearch);
        //}

        static public bool findMsgMessage(string IdMessage, string IdUser)
        {
            string textSearch = "select * from Msg.MsgMessage where IdMessage =" + IdMessage + " and refUser = "+IdUser;
            Search(textSearch);
            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ... Read Message

        static public void insertIntoMsgReadMessage(string IdMessage, DateTime ReadDate)
        {
            //int maxReadMessage = maxId("Msg.MsgReadMessage", "IdReadMessage");
            //string text = " insert into Msg.MsgReadMessage values (@maxId," + IdMessage + "," + Main.idUser + ", @date1)";
            //ChangeWithMaxIdAndDate(text, maxReadMessage, ReadDate);

            int maxReadMessage = maxId("Msg.MsgReadMessage", "IdReadMessage");
            string text = " insert into Msg.MsgReadMessage values (@maxId1," + IdMessage + "," + Main.idUser + ", @date1)";
            //ChangeWithMaxIdAndDate(text, maxReadMessage, ReadDate);
            ChangeWithItem(text, new[] { maxReadMessage}, new[] { ReadDate}, null);
        }

        static public int searchMsgUnReadMessage(string IdConversation, string IdUser)
        {
            //string textSearch = "select 1 as typem, m.IdMessage, m.TextMessage, m.CreateDate, p.RefUser, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser = p.RefUser and m.IdMessage not in (select rm.RefMessage from Msg.MsgReadMessage rm where rm.RefUser = " + IdUser + ") and m.RefConversation = '" + IdConversation + "' and m.RefUser <> '" + IdUser + "' "
            //    + " union select 2 as typem, m.IdFile, m.NameFile, m.CreateDate, p.RefUser, p.FirstName, p.LastName from db_Files.Msg.MsgFile m, Msg.MsgProfile p where m.RefUser = p.RefUser and m.IdFile not in (select rm.RefFile from db_Files.Msg.MsgReadFile rm where rm.RefUser = " + IdUser + ") and m.RefConversation = '" + IdConversation + "' and m.RefUser <> '" + IdUser + "' order by CreateDate asc";

            string textSearch = "select RefTypeMessage, m.IdMessage, m.TextMessage, m.CreateDate, p.RefUser, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser = p.RefUser and m.IdMessage not in (select rm.RefMessage from Msg.MsgReadMessage rm where rm.RefUser = " + IdUser + ") and m.RefConversation = '" + IdConversation + "' and m.RefUser <> '" + IdUser + "'  order by CreateDate asc";
            return Search(textSearch);// 1=message 2=file
        }

        static public bool findMsgUnReadMessage(string IdConversation, string refUser, string IdMessage)
        {
            string textSearch = "select * from Msg.MsgMessage m where m.IdMessage not in (select rm.RefMessage from Msg.MsgReadMessage rm where rm.RefUser = " + refUser + ") and m.RefConversation = '" + IdConversation + "' and m.RefUser <> '" + refUser + "' and m.IdMessage = '" + IdMessage + "' ";
            Search(textSearch);
            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        static public bool findMsgReadMessage(string refUser, string refMessage)
        {
            string textSearch = "select * from Msg.MsgReadMessage rm where rm.RefUser = " + refUser + " and rm.refMessage = '" + refMessage + "' ";
            Search(textSearch);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ... Delete Message

        static public void insertIntoMsgDelMessage(string idMessage, DateTime DeleteDate)
        {
            int maxDelMessage = maxId("Msg.MsgDelMessage", "IdDelMessage");
            string text = " insert into Msg.MsgDelMessage values (@maxId1," + idMessage + "," + Main.idUser + ", @date1)";
            //ChangeWithMaxIdAndDate(text, maxDelMessage, DeleteDate);
            ChangeWithItem(text, new[] { maxDelMessage}, new[] { DeleteDate}, null);
        }

        #endregion

        #region ... Group

        static public void insertIntoMsgGroup(string groupName, string about)
        {
            int maxGroup = maxId("Msg.MsgGroup", "IdGroup");
            string text = " insert into Msg.MsgGroup values (@maxId1," + Main.idUser + ",'" + groupName + "','" + about + "')";
            //ChangeWithMaxId(text, maxGroup);
            ChangeWithItem(text, new[] { maxGroup }, null, null);
        }

        static public void updateMsgGroup(string IdGroup, string GroupName, string About)
        {
            string text = "update Msg.MsgGroup set GroupName='" + GroupName + "', About='" + About + "' where IdGroup=" + IdGroup;
            Change(text);
        }

        static public int DeleteFromMsgGroup(string IdGroup)
        {
            string text = "begin tran "
                + " delete from Msg.MsgUserGroup where RefGroup = " + IdGroup
                + " delete from Msg.MsgGroup where IdGroup = " + IdGroup;
            text += " IF(@@error <> 0) BEGIN ROLLBACK TRAN RETURN END COMMIT TRAN ";
            return Change(text);
        }

        static public void searchMsgGroup(string field, string text)
        {
            string textSearch = "select * from Msg.MsgGroup g where g.RefUser = " + Main.idUser;
            if (field != "All")
            {
                textSearch += " and " + field + " like '%" + text + "%' ";
            }
            Search(textSearch);
            
        }
        #endregion

        #region ... User Group

        static public void insertIntoMsgUserGroup(string idGroup, string idUser, DateTime CreateDate)
        {
            int maxUserGroup = maxId("Msg.MsgUserGroup", "IdUserGroup");
            string text = " insert into Msg.MsgUserGroup values (@maxId1," + idGroup + "," + idUser + ", @date1)";
            //ChangeWithMaxIdAndDate(text, maxUserGroup, CreateDate);
            ChangeWithItem(text, new[] { maxUserGroup }, new[] { CreateDate }, null);
        }

        static public int DeleteFromMsguserGroup(string IdGroup, string IdUser)
        {
            string text = "delete from Msg.MsgUserGroup where RefGroup = " + IdGroup + " and RefUser = " + IdUser;
            return Change(text);
        }

        static public void searchMsgUserGroup(string IdGroup)
        {
            string textSearch = "select * from Msg.MsgUserGroup u, Msg.MsgProfile p where u.refUser=p.refUser and u.refGroup = " + IdGroup;
            Search(textSearch);

        }

        static public bool findMsgUserGroup(string RefGroup, string RefUser)
        {
            string textSearch = "select * from Msg.MsgUserGroup ug where RefGroup =" + RefGroup + " and RefUser = " + RefUser;
            Search(textSearch);
            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ... Files

        static public int insertIntoMsgFile(string idConversation, string TextMessage, byte[] file, DateTime CreateDate)
        {
            //int maxFile = maxIdFile("Msg.MsgFile", "IdFile");
            //string text = " insert into Msg.MsgFile values (@maxId," + Main.idConversation[1] + "," + Main.idUser + ", '" + fileName + "', @file1, @date1)";
            //ChangeFilesWithMaxidFileDate(text, maxFile, file, CreateDate);
            //return maxFile;

            int maxMessage = maxId("Msg.MsgMessage", "IdMessage");
            int maxFile = maxId("db_Files.Msg.MsgFile", "IdFile");
            string text = "begin tran "
                + " insert into Msg.MsgMessage values (@maxId1, 2, " + idConversation + "," + Main.idUser + ", '" + AesCryp.code(TextMessage) + "', @date1)"
                + " insert into db_Files.Msg.MsgFile values (@maxId2, @maxId1, @file1)"
                + " IF(@@error <> 0) BEGIN ROLLBACK TRAN RETURN END COMMIT TRAN ";
            ChangeWithItem(text, new[] { maxMessage, maxFile }, new[] { CreateDate }, file);
            return maxFile;
        }

        //static public void insertIntoMsgFile(string idConversation, string fileName, byte[] file, DateTime CreateDate)
        //{
        //    int maxFile = maxIdFile("Msg.MsgFile", "IdFile");
        //    string text = " insert into Msg.MsgFile values (@maxId," + idConversation + "," + Main.idUser + ", '" + fileName + "', @file1, @date1)";
        //    ChangeFilesWithMaxidFileDate(text, maxFile, file, CreateDate);
        //}

        static public int DeleteFromMsgFile(string IdFile, string IdMessage)
        {
            string text = "begin tran "
                + " delete from db_Files.Msg.MsgDownloadFile where RefFile = " + IdFile
                + " delete from Msg.MsgReadMessage where RefMessage = " + IdMessage
                + " delete from Msg.MsgDelMessage where RefMessage = " + IdMessage
                + " delete from db_Files.Msg.MsgFile where IdFile = " + IdFile
                + " delete from Msg.MsgMessage where IdMessage = " + IdMessage
                + " IF(@@error <> 0) BEGIN ROLLBACK TRAN RETURN END COMMIT TRAN ";
            return Change(text);
        }

        static public int searchMsgFile(string field, string text)
        {
            string textSearch = "select * from db_Files.Msg.MsgFile m , Msg.MsgMessage where IdMessage = RefMessage and " + field + " = '" + text + "' ";
            return Search(textSearch);
        }

        static public int searchMsgFileWithoutFile(string field, string text)
        {
            string textSearch = "select IdFile, RefMessage, me.* from db_Files.Msg.MsgFile m , Msg.MsgMessage me where IdMessage = RefMessage and " + field + " = '" + text + "' ";
            return Search(textSearch);
        }

        static public int searchMsgMyFile(string idUser)
        {
            string textSearch = "select m.IdMessage, f.IdFile, f.FileSource, m.TextMessage, m.CreateDate, pf.refUser, pf.FirstName + ' ' + pf.LastName Receiver from db_Files.Msg.MsgFile f , Msg.MsgMessage m, Msg.MsgParticipant p, Msg.MsgProfile pf where m.IdMessage = f.RefMessage and m.RefConversation = p.RefConversation and m.refUser <> p.refUser and p.refUser = pf.refUser and m.refUser = '" + idUser + "'"
                + " union select m.IdMessage, f.IdFile, f.FileSource, m.TextMessage, m.CreateDate, pf.refUser, pf.FirstName + ' ' + pf.LastName Receiver from db_Files.Msg.MsgFile f , Msg.MsgMessage m, Msg.MsgConversation c, Msg.MsgProfile pf where m.IdMessage = f.RefMessage and m.RefConversation = c.IdConversation and m.refUser <> c.refUser and c.refUser = pf.refUser and m.refUser = '" + idUser + "' order by CreateDate";
            //Clipboard.SetText(textSearch);
            return Search(textSearch);
        }

        static public bool findMsgFile(string IdFile, string IdUser)
        {
            //string textSearch = "select * from Msg.MsgFile where IdFile =" + IdFile + " and refUser = " + IdUser;
            //SearchFile(textSearch);
            //if (dataTable.Rows.Count == 1)
            //{
            //    return true;
            //}
            //return false;

            string textSearch = "select IdFile, RefMessage, me.* from db_Files.Msg.MsgFile, Msg.MsgMessage me where IdMessage = RefMessage and IdFile =" + IdFile + " and refUser = " + IdUser;
            Search(textSearch);
            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ... Read File

        //static public void insertIntoMsgReadFile(string IdFile, DateTime ReadDate)
        //{
        //    int maxReadFile = maxIdFile("Msg.MsgReadFile", "IdReadFile");
        //    string text = " insert into Msg.MsgReadFile values (@maxId," + IdFile + "," + Main.idUser + ", @date1)";
        //    ChangeFilesWithMaxidDate(text, maxReadFile, ReadDate);
        //}

        //static public bool findMsgUnReadFile(string IdConversation, string refUser, string IdFile)
        //{
        //    string textSearch = "select * from db_Files.Msg.MsgFile m  where m.IdFile not in (select rm.RefFile from Msg.MsgReadFile rm where rm.RefUser = " + refUser + ") and m.RefConversation = '" + IdConversation + "' and m.RefUser <> '" + refUser + "' and m.IdFile = '" + IdFile + "' ";
        //    SearchFile(textSearch);
        //    if (dataTable.Rows.Count == 1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //static public int searchMsgUnReadFile(string IdConversation, string IdUser)
        //{
        //    string textSearch = "select m.IdMessage, m.TextMessage, p.RefUser, p.FirstName, p.LastName from Msg.MsgMessage m, Msg.MsgProfile p where m.RefUser = p.RefUser and m.IdMessage not in (select rm.RefMessage from Msg.MsgReadMessage rm where rm.RefUser = " + IdUser + ") and m.RefConversation = " + IdConversation + " and m.RefUser <> " + IdUser;
        //    return SearchFile(textSearch);
        //}
        #endregion

        #region ... Delete File

        //static public void insertIntoMsgDelFile(string idFile, DateTime DeleteDate)
        //{
        //    int maxDelFile = maxIdFile("Msg.MsgDelFile", "IdDelFile");
        //    string text = " insert into Msg.MsgDelFile values (@maxId," + idFile + "," + Main.idUser + ", @date1)";
        //    ChangeFilesWithMaxidDate(text, maxDelFile, DeleteDate);
        //}
        #endregion

        #region ... Download File

        static public void insertIntoMsgDownloadFile(string IdFile, DateTime CreateDate)
        {
            int maxDownloadFile = maxId("db_Files.Msg.MsgDownloadFile", "IdDownloadFile");
            string text = " insert into db_Files.Msg.MsgDownloadFile values (@maxId1," + IdFile + "," + Main.idUser + ", @date1)";
            ChangeWithItem(text, new[] { maxDownloadFile }, new[] { CreateDate }, null);
        }

        static public bool findMsgDownloadedFile(string refUser, string IdMessage)
        {
            //string textSearch = "select * from db_Files.Msg.MsgFile m , Msg.MsgMessage where IdMessage = RefMessage and m.IdFile in (select df.RefFile from db_Files.Msg.MsgDownloadFile df where df.RefUser = " + refUser + ") and RefUser <> '" + refUser + "' and IdMessage = '" + IdMessage + "' ";
            string textSearch = "select IdFile, RefMessage, me.* from db_Files.Msg.MsgFile m , Msg.MsgMessage me where IdMessage = RefMessage and m.IdFile in (select df.RefFile from db_Files.Msg.MsgDownloadFile df where df.RefUser = " + refUser + ") and RefUser = '" + Main.idUser + "' and IdMessage = '" + IdMessage + "' ";
            Search(textSearch);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        static public bool findMsgDownloadedFile(string IdMessage)
        {
            string textSearch = "select IdFile, RefMessage, me.* from db_Files.Msg.MsgFile m , Msg.MsgMessage me where IdMessage = RefMessage and m.IdFile in (select df.RefFile from db_Files.Msg.MsgDownloadFile df where df.RefUser = " + Main.idUser + ") and RefUser <> '" + Main.idUser + "' and IdMessage = '" + IdMessage + "' ";
            Search(textSearch);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ... Reminder Message

        static public int insertIntoMsgRemMessage(string idConversation, string TextMessage, DateTime CreateDate, string RemMessage, int hour, DateTime RemDate, DateTime RemFromDate, string RemUser)
        {
            int maxMessage = maxId("Msg.MsgMessage", "IdMessage");
            int maxReminder = maxId("Msg.MsgRemMessage", "IdRemMessage");
            string text = "begin tran "
                + " insert into Msg.MsgMessage values (@maxId1, 3, " + idConversation + "," + Main.idUser + ", '" + AesCryp.code(TextMessage) + "', @date1)"
                + " insert into Msg.MsgRemMessage values (@maxId2, @maxId1, '" + AesCryp.code(RemMessage) + "', " + hour + ", @date2, @date3)"
                + RemUser
                + " IF(@@error <> 0) BEGIN ROLLBACK TRAN RETURN END COMMIT TRAN ";
            //ChangeWithTwoMaxIdTwoDate(text, maxMessage, maxReminder, CreateDate, RemDate);
            ChangeWithItem(text, new[] { maxMessage, maxReminder }, new[] { CreateDate, RemDate, RemFromDate }, null);
            return maxMessage;
        }

        static public int DeleteFromMsgRemMessage(string IdRemMessage, string IdMessage)
        {
            string text = "begin tran "
                + " delete from Msg.MsgRemUser where RefRemMessage = " + IdRemMessage
                + " delete from Msg.MsgReadMessage where RefMessage = " + IdMessage
                + " delete from Msg.MsgDelMessage where RefMessage = " + IdMessage
                + " delete from Msg.MsgRemMessage where IdRemMessage = " + IdRemMessage
                + " delete from Msg.MsgMessage where IdMessage = " + IdMessage
                + " IF(@@error <> 0) BEGIN ROLLBACK TRAN RETURN END COMMIT TRAN ";
            return Change(text);
        }

        static public string insertIntoMsgRemUser(string refUser)
        {
            return " insert into Msg.MsgRemUser values (@maxId2, " + refUser + ") ";
        }

        static public void searchMsgRemMessage(string field, string text)
        {
            string textSearch = "select * from Msg.MsgRemMessage , Msg.MsgMessage where IdMessage = RefMessage and " + field + " = '" + text + "' ";
            Search(textSearch);
        }

        static public int searchMsgRemMessage(string idUser, int temp)
        {
            string textSearch = "select m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName + ' ' + p.LastName Sender, rm.IdRemMessage, rm.ReminderText, rm.ReminderDate, rm.HourInterval, pf.FirstName + ' ' + pf.LastName Receiver from Msg.MsgMessage m, Msg.MsgProfile p, Msg.MsgRemMessage rm, Msg.MsgParticipant pt, Msg.MsgProfile pf where m.RefUser=p.RefUser and m.IdMessage = rm.RefMessage and m.RefConversation = pt.RefConversation and pt.RefUser=pf.RefUser and m.refUser <> pt.refUser and m.RefTypeMessage = 3 ";
            if (temp == 0)
            {
                textSearch += " and CONVERT (date, GETDATE()) <= CONVERT (date, rm.ReminderDate)";
            }
            textSearch += " and (m.RefUser =" + idUser + " or pt.RefUser =" + idUser + ") ";

            textSearch += " union select m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName + ' ' + p.LastName Sender, rm.IdRemMessage, rm.ReminderText, rm.ReminderDate, rm.HourInterval, pf.FirstName + ' ' + pf.LastName Receiver from Msg.MsgMessage m, Msg.MsgProfile p, Msg.MsgRemMessage rm, Msg.MsgConversation c, Msg.MsgProfile pf where m.RefUser=p.RefUser and m.IdMessage = rm.RefMessage and m.RefConversation = c.IdConversation and c.RefUser=pf.RefUser and m.refUser <> c.refUser and m.RefTypeMessage = 3 ";
            if (temp == 0)
            {
                textSearch += " and CONVERT (date, GETDATE()) <= CONVERT (date, rm.ReminderDate)";
            }
            textSearch += " and (m.RefUser =" + idUser + " or c.RefUser =" + idUser + ") order by CreateDate asc"; 

            return Search(textSearch);
        }

        static public int searchMsgPopRemMessage(string idUser)
        {
            string textSearch = "select m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName + ' ' + p.LastName Sender, rm.IdRemMessage, rm.ReminderText, rm.ReminderDate, rm.ReminderFromDate, rm.HourInterval, pf.FirstName + ' ' + pf.LastName Receiver from Msg.MsgMessage m, Msg.MsgProfile p, Msg.MsgRemMessage rm, Msg.MsgParticipant pt, Msg.MsgProfile pf, Msg.MsgRemUser ru where m.RefUser=p.RefUser and m.IdMessage = rm.RefMessage and m.RefConversation = pt.RefConversation and pt.RefUser=pf.RefUser and rm.IdRemMessage = ru.RefRemMessage and m.refUser <> pt.refUser and m.RefTypeMessage = 3 "
                + " and ru.RefUser = " + idUser + " and CONVERT (date, GETDATE()) <= CONVERT (date, rm.ReminderDate) and (m.RefUser =" + idUser + " or pt.RefUser =" + idUser + ") "

                + " union select m.RefTypeMessage, m.IdMessage, m.RefConversation, m.RefUser, m.TextMessage, m.CreateDate, p.IdProfile, p.FirstName + ' ' + p.LastName Sender, rm.IdRemMessage, rm.ReminderText, rm.ReminderDate, rm.ReminderFromDate, rm.HourInterval, pf.FirstName + ' ' + pf.LastName Receiver from Msg.MsgMessage m, Msg.MsgProfile p, Msg.MsgRemMessage rm, Msg.MsgConversation c, Msg.MsgProfile pf, Msg.MsgRemUser ru where m.RefUser=p.RefUser and m.IdMessage = rm.RefMessage and m.RefConversation = c.IdConversation and c.RefUser=pf.RefUser and rm.IdRemMessage = ru.RefRemMessage and m.refUser <> c.refUser and m.RefTypeMessage = 3 "
                + " and ru.RefUser = " + idUser + " and CONVERT (date, GETDATE()) <= CONVERT (date, rm.ReminderDate) and (m.RefUser =" + idUser + " or c.RefUser =" + idUser + ") order by CreateDate asc";
            return Search(textSearch);
        }
        #endregion

        #region ... Online User

        static public void insertIntoMsgOnlineUser(DateTime CreateDate)
        {
            string text = " insert into Msg.MsgOnlineUser values (" + Main.idUser + ",'" + Dns.GetHostAddresses(Environment.MachineName)[1].ToString() + "','" + Environment.MachineName + "','" + Application.ProductVersion + "', @date1)";
            //ChangeWithDate(text, CreateDate);
            ChangeWithItem(text, null, new[] { CreateDate }, null);
        }

        static public int DeleteFromOnlineUser()
        {
            string text = "delete from Msg.MsgOnlineUser where RefUser = " + Main.idUser;
            return Change(text);
        }

        static public bool findMsgOnlineUser(string IdUser)
        {
            string textSearch = "select * from Msg.MsgOnlineUser where RefUser = " + IdUser;
            Search(textSearch);
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
