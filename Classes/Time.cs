using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Windows.Forms;

/// <summary>
/// Summary description for Time
/// </summary>
public class Time
{
    static public string sd;
    static public string Date(int plusDay)
    {
        PersianCalendar PerCal = new PersianCalendar();
        string Year, Day, Month;
        Year = PerCal.GetYear(DateTime.Now).ToString();
        Month = PerCal.GetMonth(DateTime.Now).ToString();
        Day = PerCal.GetDayOfMonth(DateTime.Now.AddDays(plusDay)).ToString();
        Day = (Day.Length == 1) ? "0" + Day : Day;
        Month = (Month.Length == 1) ? "0" + Month : Month;
        return (Year + '/' + Month + '/' + Day);
    }

    //static public DateTime convertShamsiToMiladi(string date)
    //{
    //    int year = 0, month = 0, day = 0;
    //    string startShift = "06:00:00";
    //    DateTime dt = new DateTime();
    //    //if (date.Length > 11)
    //    //{
    //    //    dt = Convert.ToDateTime(date);
    //    //}
    //    //else
    //    //{
    //    //    dt = Convert.ToDateTime(date + " " + "06:00:00");
    //    //}
    //    PersianCalendar x = new PersianCalendar();
    //    //dt = x.ToDateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
    //    ExtractDate(date, out year, out month, out day);
    //    dt = x.ToDateTime(year, month, day, Convert.ToInt32(startShift.Substring(0, 2)), Convert.ToInt32(startShift.Substring(3, 2)), Convert.ToInt32(startShift.Substring(6, 2)), 0);
    //    return Convert.ToDateTime(dt.ToString(@"yyyy/MM/dd hh:mm:ss tt", new CultureInfo("en-US")));
    //}

    static public DateTime convertShamsiToMiladi(string date)
    {
        try
        {
            int year = 0, month = 0, day = 0;
            string startShift = "06:00:00";
            DateTime dt = new DateTime();
            PersianCalendar x = new PersianCalendar();
            if (date.Length > 11)
            {
                //dt = Convert.ToDateTime(date);
                //dt = x.ToDateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
                ExtractDate(date.Substring(0, 10), out year, out month, out day);
                dt = x.ToDateTime(year, month, day, Convert.ToInt32(date.Substring(11, 2)), Convert.ToInt32(date.Substring(14, 2)), 0, 0);
            }
            else
            {
                ExtractDate(date, out year, out month, out day);
                dt = x.ToDateTime(year, month, day, Convert.ToInt32(startShift.Substring(0, 2)), Convert.ToInt32(startShift.Substring(3, 2)), Convert.ToInt32(startShift.Substring(6, 2)), 0);
            }
            return Convert.ToDateTime(dt.ToString(@"yyyy/MM/dd hh:mm:ss tt", new CultureInfo("en-US")));
        }
        catch (Exception me)
        {
            MessageBox.Show(me.Message);
            return DateTime.Now.AddYears(-100);
        }
    }

    static public string Today(int plus)
    {
        DateTime startShift = Convert.ToDateTime("06:00:00");

        DateTime today = startShift.AddDays(plus);
        //today = today.AddHours(-today.Hour + hour);
        //today = today.AddMinutes(-today.Minute);
        //today = today.AddSeconds(-today.Second);
        today.ToUniversalTime();
        string str = today.ToString(@"yyyy/MM/dd hh:mm:ss tt", new CultureInfo("en-US"));
        sd = str;
        return str;
    }

    static public string convertMiladiToShamsi(DateTime datetime)
    {
        PersianCalendar PerCal = new PersianCalendar();
        string Year, Day, Month;
        Year = PerCal.GetYear(datetime).ToString();
        Month = PerCal.GetMonth(datetime).ToString();
        Day = PerCal.GetDayOfMonth(datetime).ToString();
        Day = (Day.Length == 1) ? "0" + Day : Day;
        Month = (Month.Length == 1) ? "0" + Month : Month;
        return (Year + '/' + Month + '/' + Day) + " " + datetime.ToShortTimeString();
    }

    static public string convertMiladiToShamsiOnlyDate(DateTime datetime)
    {
        PersianCalendar PerCal = new PersianCalendar();
        string Year, Day, Month;
        Year = PerCal.GetYear(datetime).ToString();
        Month = PerCal.GetMonth(datetime).ToString();
        Day = PerCal.GetDayOfMonth(datetime).ToString();
        Day = (Day.Length == 1) ? "0" + Day : Day;
        Month = (Month.Length == 1) ? "0" + Month : Month;
        return (Year + '/' + Month + '/' + Day);
    }

    static public void ExtractDate(string date, out int yaer, out int month, out int day)
    {
        if (date.Length == 10)
        {
            yaer = Convert.ToInt32(date.Substring(0, 4));
            month = Convert.ToInt32(date.Substring(5, 2));
            day = Convert.ToInt32(date.Substring(8, 2));
        }
        else if (date.Length == 8)
        {
            yaer = Convert.ToInt32(date.Substring(0, 4));
            month = Convert.ToInt32(date.Substring(5, 1));
            day = Convert.ToInt32(date.Substring(7, 1));
        }
        else if (date.Length == 9)
        {
            yaer = Convert.ToInt32(date.Substring(0, 4));
            if (date[7] == '/')
            {
                month = Convert.ToInt32(date.Substring(5, 2));
                day = Convert.ToInt32(date.Substring(8, 1));
            }
            else
            {
                month = Convert.ToInt32(date.Substring(5, 1));
                day = Convert.ToInt32(date.Substring(7, 2));
            }
        }
        else
        {
            yaer = 0;
            month = 0;
            day = 0;
        }
    }

    static public int PersianYear(DateTime miladiDate)
    {
        int year = 0, month = 0, day = 0;
        string date = convertMiladiToShamsi(miladiDate).Substring(0, 10);
        ExtractDate(date, out year, out month, out day);
        return year;
    }

    static public int compareDate(string dateOne, string dateTwo)
    {
        try
        {
            int year1 = 0, month1 = 0, day1 = 0, year2 = 0, month2 = 0, day2 = 0;
            ExtractDate(dateOne, out year1, out month1, out day1);
            ExtractDate(dateTwo, out year2, out month2, out day2);

            if (year1 > year2 || (year1 == year2 && month1 > month2) || (year1 == year2 && month1 == month2 && day1 > day2))
            {
                return 1;
            }
            if (year1 < year2 || (year1 == year2 && month1 < month2) || (year1 == year2 && month1 == month2 && day1 < day2))
            {
                return -1;
            }
            return 0;
        }
        catch { return -10; }
    }

    static public bool isDate(string date)
    {
        try
        {
            if (date.Length != 10)
            {
                return false;
            }
            if (IsDijit(date[0].ToString()) == false || IsDijit(date[1].ToString()) == false || IsDijit(date[2].ToString()) == false || IsDijit(date[3].ToString()) == false || IsDijit(date[5].ToString()) == false || IsDijit(date[6].ToString()) == false || IsDijit(date[8].ToString()) == false || IsDijit(date[9].ToString()) == false)
            {
                return false;
            }
            if (date[4].ToString() != "/" || date[7].ToString() != "/")
            {
                return false;
            }
            if (Convert.ToInt32(date[5].ToString()) * 10 + Convert.ToInt32(date[6].ToString()) > 12)
            {
                return false;
            }
            if (Convert.ToInt32(date[8].ToString()) * 10 + Convert.ToInt32(date[9].ToString()) > 31)
            {
                return false;
            }
            return true;
        }
        catch { return false; }
    }

    static public string time()
    {
        string hour = setTime(DateTime.Now.Hour);
        string min = setTime(DateTime.Now.Minute);
        string second = setTime(DateTime.Now.Second);
        return second + " : " + min + " : " + hour;
    }

    static private string setTime(int index)
    {
        if (index >= 10)
        {
            return index.ToString();
        }
        return "0" + index.ToString();
    }

    static public string day()
    {
        string temp = DateTime.Now.DayOfWeek.ToString();
        if (temp == "Saturday") { return "شنبه"; }
        else if (temp == "Sunday") { return "یکشنبه"; }
        else if (temp == "Monday") { return "دوشنبه"; }
        else if (temp == "Tuesday") { return "سه شنبه"; }
        else if (temp == "Wednesday") { return "چهار شنبه"; }
        else if (temp == "Thursday") { return "پنج شنبه"; }
        else { return "جمعه"; }
    }

    static public void thisWeek(DateTime today, out DateTime start, out DateTime end)
    {
        string temp = today.DayOfWeek.ToString();
        if (temp == "Saturday")
        { start = today; end = today.AddDays(6); }
        else if (temp == "Sunday")
        { start = today.AddDays(-1); end = today.AddDays(5); }
        else if (temp == "Monday")
        { start = today.AddDays(-2); end = today.AddDays(4); }
        else if (temp == "Tuesday")
        { start = today.AddDays(-3); end = today.AddDays(3); }
        else if (temp == "Wednesday")
        { start = today.AddDays(-4); end = today.AddDays(2); }
        else if (temp == "Thursday")
        { start = today.AddDays(-5); end = today.AddDays(1); }
        else
        { start = today.AddDays(-6); end = today.AddDays(0); }
    }

    static public void thisMonth(DateTime today, out DateTime start, out DateTime end)
    {
        int year = 0, month = 0, day = 0;
        ExtractDate(convertMiladiToShamsi(today).Substring(0, 10), out year, out month, out day);

        if (month <= 6)
        { start = today.AddDays(-(day - 1)); end = today.AddDays(31 - day); }
        else if (month <= 11)
        { start = today.AddDays(-(day - 1)); end = today.AddDays(30 - day); }
        else
        { start = today.AddDays(-(day - 1)); end = today.AddDays(29 - day); }
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

    static public DateTime startReservation(DateTime start)
    {
        start = Convert.ToDateTime(start.ToShortDateString() + " 13:00:00");
        return start;
    }

    static public DateTime EndReservation(DateTime end)
    {
        end = Convert.ToDateTime(end.ToShortDateString() + " 10:00:00");
        return end;
    }

    static public DateTime TimeService(DateTime end)
    {
        end = Convert.ToDateTime(end.ToShortDateString() + " 18:00:00");
        return end;
    }

}