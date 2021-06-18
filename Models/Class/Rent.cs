using System;

namespace Models.Class
{
    public class Rent
    {
        private int id;
        private int consolaId;
        private TimeSpan timeStart;
        private TimeSpan timeFinish;
        private TimeSpan timeWorked;
        private string nombreConsola;
        private DateTime startTime;
        private string rentInfo;

        public string RentInfo { get => rentInfo; set => rentInfo = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public string NombreConsola { get => nombreConsola; set => nombreConsola = value; }
        public int Id { get => id; set => id = value; }
        public int ConsolaId { get => consolaId; set => consolaId = value; }
        public TimeSpan TimeStart { get => timeStart; set => timeStart = value; }
        public TimeSpan TimeFinish { get => timeFinish; set => timeFinish = value; }
        public TimeSpan TimeWorked { get => timeWorked; set => timeWorked = value; }

        public static string GetTime()
        {
            string TimeOnly;
            TimeOnly = DateTime.Now.ToString("hh:mm");
            return TimeOnly;
        }

    }
}
