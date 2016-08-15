using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

/// <summary>
/// Summary description for Utility
/// </summary>
public static class Utility
{
    public static string MakeLogFileDate()
    {
        string year, month, day, date;
        year = DateTime.Now.Year.ToString();
        month = DateTime.Now.Month.ToString();
        day = DateTime.Now.Day.ToString();
        date = month + day + year;
        return date;
    }
    public static string CurrentTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
    public static string GetIPAddress()
    {
        //get the current context
        System.Web.HttpContext context = System.Web.HttpContext.Current;

        //grab the IP forwarded from any proxies or routers 
        string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        //if there are atleast 1...
        if (!string.IsNullOrEmpty(ipAddress))
        {
            string[] addresses = ipAddress.Split(',');
            if (addresses.Length != 0)
            {
                //...return the IP
                return addresses[0];
            }
        }

        //otherwise, simply return the remote address for this context
        return context.Request.ServerVariables["REMOTE_ADDR"];
    }
    public static void CreateAppendLogFile(string action)
    {
        
        StreamWriter log = new StreamWriter(HttpContext.Current.Server.MapPath("~/logs/") + MakeLogFileDate() + ".log", true);

        log.WriteLine(CurrentTime() + " - Site visited by: " + GetIPAddress() + "\tAction: " + action);
        log.Flush();
        log.Close();
        
    }
}