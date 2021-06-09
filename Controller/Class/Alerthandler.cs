using System;
using System.Collections.Generic;

namespace Controller.Class
{
    public class Alerthandler
    {
        public static string date = DateTime.Now.ToString("dd/MM/yyyy");
        public static string filename = "ErrorLogFile_"+date.Replace('/','_')+".txt";
        public static string directoryPath = "C://XAppTemp//";
        public static string filePath = directoryPath+filename;
        public List<string[]> SList = new List<string[]>();
        public Alerthandler()
        {
            
        }
        //Work in Progress
    }
}
