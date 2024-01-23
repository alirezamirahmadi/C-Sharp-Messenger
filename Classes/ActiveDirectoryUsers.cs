using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.Security.Principal;

namespace Messenger
{
    class ActiveDirectoryUsers
    {
        static public ArrayList ListAllUser()
        {
            ArrayList listUsers = new ArrayList();
            DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.UserDomainName);
            //string userNames = "";
            //string authenticationType = "";
            foreach (DirectoryEntry child in directoryEntry.Children)
            {
                if (child.SchemaClassName == "User")
                {
                    //userNames += child.Name + Environment.NewLine; //Iterates and binds all user using a newline
                    //authenticationType += child. + Environment.NewLine;
                    listUsers.Add(child.Name + Environment.NewLine);
                }
            }
            
            //Console.WriteLine("************************Users************************");
            //Console.WriteLine(userNames);
            //Console.WriteLine("*****************Authentication Type*****************");
            //Console.WriteLine(authenticationType);

            return listUsers;
        }

        static public bool findUser(string username)
        {
            DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.UserDomainName);
            foreach (DirectoryEntry child in directoryEntry.Children)
            {
                if (child.SchemaClassName == "User" && child.Name == username)
                {
                    //userNames += child.Name + Environment.NewLine; //Iterates and binds all user using a newline
                    //authenticationType += child. + Environment.NewLine;
                    //listUsers.Add(child.Name + Environment.NewLine);
                    return true;
                }
            }
            return false;
        }

        static public bool validateUser(string username, string password)
        {
            bool validation;
            try
            {
                LdapConnection lcon = new LdapConnection(new LdapDirectoryIdentifier("192.168.5.62", false, false));
                NetworkCredential nc = new NetworkCredential(username, password, "KCIG");
                lcon.Credential = nc;
                lcon.AuthType = AuthType.Negotiate;
                // user has authenticated at this point,
                // as the credentials were used to login to the dc.
                lcon.Bind(nc);
                validation = true;
            }
            catch (LdapException me)
            {
                //MessageBox.Show(me.Message);
                validation = false;
            }
            return validation;
        }

        public static string detailsUser(string username, string item)
        {
            DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.UserDomainName);
            foreach (DirectoryEntry child in directoryEntry.Children)
            {
                //return IsAccountDisabled(child).ToString();
                if (child.SchemaClassName == "User" && child.Name == username)
                {
                    return child.Properties[item].Value.ToString();
                }
            }
            return "";
        }

        public static void fnGetListOfUsers(string username)
        {
            //string temp = "";
            //PropertyCollection pc;
            //DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.UserDomainName);
            //foreach (DirectoryEntry child in directoryEntry.Children)
            //{
            //    if (child.SchemaClassName == "User" && child.Name == username)
            //    {
            //        pc = child.Properties;

            //    }
            //    pc = child.Properties;
            //}
            //pc = child.Properties;
            //foreach (object st in pc)
        }  

        static public string getCurrentUser()
        {
            string[] user = new string[2];
            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            user = wi.Name.Split('\\');
            return user[1];
        }   
    }
}
