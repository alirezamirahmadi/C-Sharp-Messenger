using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Messenger
{
    class Texts
    {
        static public void extractNameAndFamily(string text, out string name, out string family)
        {
            int i = 0;
            name = "";
            family = "";
            while (text[i] != ' ')
            {
                name += text[i];
                i++;
            }
            for (int j = ++i; j < text.Length; j++)
            {
                family += text[j];
            }
        }

        static public bool IsDijit(string Text)
        {
            //0=48, 9=57
            int temp = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                temp = (int)Text[i];
                if (temp < 48 || temp > 57)
                {
                    return false;
                }
            }
            return true;
        }

        static public void Farsi_Convert()
        {
            System.PlatformID platform = Environment.OSVersion.Platform;
            System.String windowsType = platform.ToString();
            if (windowsType == "Win32NT")
                Win32.LoadKeyboardLayoutA("00000429", 1);  //xp , 2000
            if (windowsType == "Win32Windows" || windowsType == "Win32S")
                Win32.LoadKeyboardLayoutA("00000401", 1);  //95 98
        }
        public class Win32
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int LoadKeyboardLayoutA(string pwszKLID, int Flags);
        }
        static public void English_Convert()
        {
            Win32.LoadKeyboardLayoutA("00000409", 1);
        }
    }
}
