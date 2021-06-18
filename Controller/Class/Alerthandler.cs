using System;
using System.Collections.Generic;
using Controller.Properties;

namespace Controller.Class
{
    public class Alerthandler
    {
        public static string date = DateTime.Now.ToString("dd/MM/yyyy");
        public static string filename = "ErrorLogFile_" + date.Replace('/', '_') + ".txt";
        public static string directoryPath = "C://XAppTemp//";
        public static string filePath = directoryPath + filename;
        public List<string[]> SList = new List<string[]>();
        private string conString;

        public Alerthandler()
        {

        }
        //Work in Progress
        public string ConString { get => conString; set => conString = value; }
        public static bool ChangeDBConn(string NewConnection)
        {
            Settings.Default.CS = NewConnection;
            Settings.Default.Save();

            if(Settings.Default.CS == NewConnection)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetCurrentCS()
        {
            return Settings.Default.CS;
        }
    }
}
