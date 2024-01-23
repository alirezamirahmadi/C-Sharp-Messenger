//#define Demo
//#define HardWareLock
//#define Login
//#define ConStr

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;



namespace Messenger
{

    partial class About : Form
    {
        [DllImport("IBECoHL.dll")]
        static extern int ProductDateAndTime(out int Min, out int Hour, out int Day, out int Month, out int Year);
        [DllImport("IBECoHL.dll")]
        static extern int GetExpiryDateAndTime(out byte Min, out byte Hour, out byte Day, out byte Month, out byte Year, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int GetFirstUseDateAndTime(out byte Min, out byte Hour, out byte Day, out byte Month, out byte Year, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int ReadString([MarshalAs(UnmanagedType.LPArray)] byte[] Str2Read, byte BlockNo, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int ReadStringEx([MarshalAs(UnmanagedType.LPArray)] byte[] Str2Read, int Len, int Offset, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int WriteString([MarshalAs(UnmanagedType.LPArray)] byte[] Str2Write, byte BlockNo, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int WriteStringEx([MarshalAs(UnmanagedType.LPArray)] byte[] Str2Write, int Len, int Offset, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int GetLastUseDateAndTime(out byte Min, out byte Hour, out byte Day, out byte Month, out byte Year, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int GetProgramDateAndTime(out byte Min, out byte Hour, out byte Day, out byte Month, out byte Year, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int GetResetCounter(out int ResetCounter);
        [DllImport("IBECoHL.dll")]
        static extern int CheckAlg(int R1, int R2, int R3, int R4, out int A1, out int A2, out int A3, out int A4, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int ReadDeviceID([MarshalAs(UnmanagedType.LPArray)] byte[] ID);
        [DllImport("IBECoHL.dll")]
        static extern int SetFirstUseDateAndTime(byte Min, byte Hour, byte Day, byte Month, byte Year, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int SetLastUseDateAndTime(byte Min, byte Hour, byte Day, byte Month, byte Year, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int DecCharge(out ushort ChargeValue, int pass1, int pass2);
        [DllImport("IBECoHL.dll")]
        static extern int Get_Device_Count(out byte Cnt);
        [DllImport("IBECoHL.dll")]
        static extern int Select_Device(byte Dev);

        public About()
        {
            InitializeComponent();
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        static public string readVersion()
        {
            int r = 0;
            string version = "";
            byte[] DeviceID = new Byte[11];
            r = ReadDeviceID(DeviceID);
            if (r == 0)
            {
                for (int i = 0; i < 11; ++i)
                {
                    version += Convert.ToChar(DeviceID[i]);
                }
            }
            return version;// == "IBECo651300";
        }

        static public string readName()
        {
            int r = 0;
            string name = "";
            byte[] Str2Read = new Byte[4];
            for (int i = 1; i <= 64; ++i)
            {
                r = ReadString(Str2Read, (byte)i, 55831011, 55831011);
                if (r == 0)
                {
                    for (int j = 0; j < 4; ++j)
                    {
                        name += Convert.ToChar(Str2Read[j]);
                    }
                }
            }
            return name;
        }

        static public bool A_One()
        {
            #if HardWareLock
            return readVersion() == "IBECo651300"; // 1 ostandari
            //return readVersion() == "IBECo651330"; // 2 ostandari
            #else
                return true;
            #endif
        }

        static public bool isLogin()
        {
            #if Login
                return true;
            #else
                return false;
            #endif
        }

        static public string CS()
        {
            #if ConStr
                return "server=10.10.11.43; database=Manage-Employee; user Id=sa; password=kermanrose";
            #else
                return "server=localhost; database=Manage-Employee;integrated security=SSPI";
            #endif
        }

        static public bool checkCountUser()
        {
            #if Demo
                int count = DataBase.countUser();
                if (count > 9)
                {
                    return false;
                }
            #endif
            return true;
        }

        static public bool checkCountTerm()
        {
            #if Demo
                int count = DataBase.countTerm();
                if (count > 4)
                {
                    return false;
                }
            #endif
            return true;
        }

        private void About_Load(object sender, EventArgs e)
        {
            labelVersion.Text = "Version " + Application.ProductVersion;
            //backColor();
        }

        private void backColor()
        {
            try
            {
                //BackColor = Color.FromArgb(Options.backColor);
                tableLayoutPanel.BackColor = BackColor;
            }
            catch (Exception)
            {
            }
        }
    }
}
